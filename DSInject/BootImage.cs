using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DSInject
{
    public class BootImage : IDisposable
    {
        private bool disposed = false;

        private Bitmap _frame;
        private Bitmap _titleScreen;

        public Bitmap Frame
        {
            set
            {
                if (_frame != null)
                    _frame.Dispose();
                _frame = value;
            }
            get { return _frame; }
        }
        public Bitmap TitleScreen
        {
            set
            {
                if (_titleScreen != null)
                    _titleScreen.Dispose();
                _titleScreen = value;
            }
            get { return _titleScreen; }
        }
        public string NameLine1;
        public string NameLine2;
        public int Released;
        public bool Longname;
        public bool IsDefault;

        public BootImage()
        {
            _frame = null;
            _titleScreen = null;
            NameLine1 = null;
            NameLine2 = null;
            Released = 0;
            Longname = false;
            IsDefault = true;
        }

        ~BootImage()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (Frame != null)
                    {
                        Frame.Dispose();
                        Frame = null;
                    }
                    if (TitleScreen != null)
                    {
                        TitleScreen.Dispose();
                        TitleScreen = null;
                    }
                }
                disposed = true;
            }
        }

        public Bitmap Create()
        {
            Bitmap img = new Bitmap(1280, 720);
            Graphics g = Graphics.FromImage(img);
            g.PixelOffsetMode = PixelOffsetMode.Half;
            //g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            GraphicsPath nl1 = new GraphicsPath();
            GraphicsPath nl2 = new GraphicsPath();
            GraphicsPath r = new GraphicsPath();
            GraphicsPath p = new GraphicsPath();

            Font font = new Font("Trebuchet MS", 10.0F, FontStyle.Regular, GraphicsUnit.Point);
            Rectangle rectangleNL1 = Longname ? new Rectangle(578, 313, 640, 50) : new Rectangle(578, 340, 640, 50);
            Rectangle rectangleNL2 = new Rectangle(578, 368, 640, 50);
            Rectangle rectangleR = new Rectangle(586, 450, 250, 40);
            Rectangle rectangleP = new Rectangle(586, 496, 200, 40);
            SolidBrush brush = new SolidBrush(Color.FromArgb(32, 32, 32));
            Pen outlineBold = new Pen(Color.FromArgb(222, 222, 222), 5.0F);
            Pen shadowBold = new Pen(Color.FromArgb(190, 190, 190), 7.0F);
            Pen outline = new Pen(Color.FromArgb(222, 222, 222), 4.0F);
            Pen shadow = new Pen(Color.FromArgb(190, 190, 190), 6.0F);
            StringFormat format = new StringFormat();

            g.Clear(Color.White);

            if (Frame == null)
            {
                GraphicsPath vc = new GraphicsPath();
                GraphicsPath n = new GraphicsPath();
                GraphicsPath sf = new GraphicsPath();
                GraphicsPath sfi = new GraphicsPath();

                Font fontVC = new Font("Arial", 10.0F, FontStyle.Regular, GraphicsUnit.Point);
                Font fontDS = new Font("Arial Black", 10.0F, FontStyle.Regular, GraphicsUnit.Point);
                Rectangle rectangleVC = new Rectangle(60, 105, 400, 50);
                Rectangle rectangleN = new Rectangle(580, 247, 215, 40);
                Rectangle rectangleDS = new Rectangle(774, 230, 120, 90);
                Rectangle rectangleDSI = new Rectangle(1075, 645, 150, 40);
                SolidBrush brushVC = new SolidBrush(Color.FromArgb(147, 149, 152));
                SolidBrush brushN = new SolidBrush(Color.FromArgb(35, 25, 22));
                SolidBrush brushDS = new SolidBrush(Color.FromArgb(35, 25, 22));
                SolidBrush brushDSI = new SolidBrush(Color.FromArgb(213, 213, 213));
                Pen outlineDSI = new Pen(Color.FromArgb(150, 150, 150), 2.0F);

                g.Clear(Color.FromArgb(226, 226, 226));
                g.FillRectangle(new SolidBrush(Color.FromArgb(200, 200, 200)), 61, 192, 1162, 421);
                g.FillRectangle(new SolidBrush(Color.FromArgb(226, 226, 226)), 66, 197, 1152, 411);

                vc.AddString("Virtual Console", fontVC.FontFamily,
                    (int)(FontStyle.Bold | FontStyle.Italic),
                    g.DpiY * 37.4F / 72.0F, rectangleVC, format);
                g.FillPath(brushVC, vc);

                n.AddString("NINTENDO", fontVC.FontFamily,
                    (int)(FontStyle.Regular),
                    g.DpiY * 27.9F / 72.0F, rectangleN, format);
                g.FillPath(brushN, n);

                sf.AddString("DS", fontDS.FontFamily,
                    (int)(FontStyle.Bold),
                    g.DpiY * 46.0F / 72.0F, rectangleDS, format);
                g.FillPath(brushDS, sf);

                sfi.AddString("DSInject", font.FontFamily,
                    (int)(FontStyle.Regular),
                    g.DpiY * 26.0F / 72.0F, rectangleDSI, format);
                g.DrawPath(outlineDSI, sfi);
                g.FillPath(brushDSI, sfi);
            }

            if (TitleScreen != null)
            {
                if (TitleScreen.Width > TitleScreen.Height)
                {
                    g.DrawImage(TitleScreen, 131, 249, 400, 300);
                }
                else if (TitleScreen.Width < TitleScreen.Height)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), 131, 249, 400, 300);
                    g.DrawImage(TitleScreen, 218, 249, 225, 300);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.Black), 131, 249, 400, 300);
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.DrawImage(TitleScreen, new Rectangle(203, 271, 256, 256));
                    g.InterpolationMode = InterpolationMode.Default;
                }                
            }
            else
                g.FillRectangle(new SolidBrush(Color.Black), 131, 249, 400, 300);

            if (Frame != null)
                g.DrawImage(Frame, new Rectangle(0, 0, 1280, 720));

            if (NameLine1 != null && NameLine2 != null)
            {
                if (Longname)
                {
                    nl1.AddString(NameLine1, font.FontFamily,
                        (int)(FontStyle.Bold),
                        g.DpiY * 37.0F / 72.0F, rectangleNL1, format);
                    g.DrawPath(shadowBold, nl1);
                    g.DrawPath(outlineBold, nl1);
                    g.FillPath(brush, nl1);
                    nl2.AddString(NameLine2, font.FontFamily,
                        (int)(FontStyle.Bold),
                        g.DpiY * 37.0F / 72.0F, rectangleNL2, format);
                    g.DrawPath(shadowBold, nl2);
                    g.DrawPath(outlineBold, nl2);
                    g.FillPath(brush, nl2);
                }
                else
                {
                    nl1.AddString(NameLine1, font.FontFamily,
                        (int)(FontStyle.Bold),
                        g.DpiY * 37.0F / 72.0F, rectangleNL1, format);
                    g.DrawPath(shadowBold, nl1);
                    g.DrawPath(outlineBold, nl1);
                    g.FillPath(brush, nl1);
                }
            }

            if (Released > 2003)
            {
                r.AddString("Released: " + Released.ToString(), font.FontFamily,
                    (int)(FontStyle.Regular),
                    g.DpiY * 25.0F / 72.0F, rectangleR, format);
                g.DrawPath(shadow, r);
                g.DrawPath(outline, r);
                g.FillPath(brush, r);
            }

            return img;
        }
    }
}
