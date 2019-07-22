﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DSInject
{
    public class IconImage : IDisposable
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
        public bool IsDefault;

        public IconImage()
        {
            _frame = null;
            _titleScreen = null;
            IsDefault = true;
        }

        ~IconImage()
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
            Bitmap img = new Bitmap(128, 128);
            Graphics g = Graphics.FromImage(img);
            g.PixelOffsetMode = PixelOffsetMode.Half;
            //g.InterpolationMode = InterpolationMode.NearestNeighbor;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            GraphicsPath vc = new GraphicsPath();

            Font font = new Font("Arial", 10.0F, FontStyle.Regular, GraphicsUnit.Point);
            Rectangle rectangleVC = new Rectangle(0, 101, 128, 27);
            //Rectangle rectangleTS = new Rectangle(3, 9, 122, 92);
            SolidBrush brush = new SolidBrush(Color.FromArgb(147, 149, 152));
            Pen pen = new Pen(Color.Black, 2.0F);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            g.Clear(Color.FromArgb(30, 30, 30));

            if (TitleScreen != null)
            {
                if (TitleScreen.Width > TitleScreen.Height)
                {
                    g.DrawImage(TitleScreen, 3, 9, 122, 92);
                }
                else if (TitleScreen.Width < TitleScreen.Height)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), 3, 9, 122, 92);
                    g.DrawImage(TitleScreen, 30, 9, 69, 92);
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(37, 37, 37)), 3, 9, 122, 92);
                    g.FillRectangle(new SolidBrush(Color.Black), 5, 11, 118, 88);
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.DrawImage(TitleScreen, new Rectangle(32, 23, 64, 64));
                    g.InterpolationMode = InterpolationMode.Default;
                }
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(37, 37, 37)), 3, 9, 122, 92);
                g.FillRectangle(new SolidBrush(Color.Black), 5, 11, 118, 88);
            }

            if (Frame == null)
            {
                vc.AddString("Virtual Console.", font.FontFamily,
                (int)(FontStyle.Bold | FontStyle.Italic),
                g.DpiY * 9.2F / 72.0F, rectangleVC, format);
                g.DrawPath(pen, vc);
                g.FillPath(brush, vc);
            }
            else
                g.DrawImage(Frame, new Rectangle(0, 0, 128, 128));

            return img;
        }
    }
}
