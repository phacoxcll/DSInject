using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;

namespace DSInject
{
    public class DSInjector
    {
        public const string Release = "1.2 debug"; //CllVersionReplace "major.minor stability"

        public string BasePath;
        public string ShortName;
        public string LongName;
        public string InPath;
        public string RomPath;
        public string BootTvPath;
        public string BootDrcPath;
        public string IconPath;
        public string OutPath;
        public bool Encrypt;

        private VCNDS _base;
        public RomNDS Rom;
        public BootImage BootTvImg;
        public BootImage BootDrcImg;
        public IconImage IconImg;


        public bool BaseIsLoaded
        {
            get { return _base != null; }
        }

        public bool RomIsLoaded
        {
            get { return Rom != null && Rom.IsValid; }
        }

        public string LoadedBase
        {
            get
            {
                if (_base != null)
                    return _base.ToString();
                else
                    return "";
            }
        }

        public string ShortNameASCII
        {
            get
            {
                char[] array = Useful.Windows1252ToASCII(ShortName, '_').ToCharArray();
                char[] invalid = Path.GetInvalidFileNameChars();

                for (int i = 0; i < array.Length; i++)
                {
                    foreach (char c in invalid)
                    {
                        if (array[i] == c)
                            array[i] = '_';
                    }
                }

                return new string(array);
            }
        }

        public string TitleId
        {
            get
            {
                if (BaseIsLoaded && RomIsLoaded)
                    return "00050000D5" + Rom.HashCRC16.ToString("X4") + _base.Index.ToString("X2");
                else
                    return "";
            }
        }


        public DSInjector()
        {
            BasePath = null;
            ShortName = null;
            LongName = null;
            InPath = null;
            RomPath = null;
            IconPath = null;
            BootTvPath = null;
            BootDrcPath = null;
            OutPath = null;
            Encrypt = true;

            _base = GetLoadedBase();
            Rom = null;
            BootTvImg = new BootImage();
            BootDrcImg = new BootImage();
            IconImg = new IconImage();
        }

        public bool Inject()
        {
            _base = GetLoadedBase();
            bool _continue = BaseIsLoaded;
            if (_continue)
            {
                Cll.Log.WriteLine("Base info:");
                Cll.Log.WriteLine(_base.ToString());
            }
            else
                Cll.Log.WriteLine("The base is not loaded.");

            if (_continue)
                _continue = InjectImages();

            if (_continue)
                _continue = InjectMeta();

            if (_continue)
                _continue = InjectRom();

            if (_continue)
            {
                if (Encrypt)
                {
                    Cll.Log.WriteLine("Creating encrypted output.");
                    string inPath = Environment.CurrentDirectory + "\\base";
                    _continue = NusContent.Encrypt(inPath, OutPath);
                }
                else
                {
                    Cll.Log.WriteLine("Creating unencrypted output.");
                    _continue = Useful.DirectoryCopy("base", OutPath, true);
                }
            }

            if (_continue)
                Cll.Log.WriteLine("Injection completed successfully!");
            else
                Cll.Log.WriteLine("The injection failed.\nCheck the log file \"" + Cll.Log.Filename + "\".");

            return _continue;
        }

        private bool InjectImages()
        {
            string currentDir = Environment.CurrentDirectory;
            Bitmap bootTvImg;
            Bitmap bootDrcImg;
            Bitmap iconImg;
            Bitmap tmp;
            Graphics g;

            try
            {
                Cll.Log.WriteLine("Creating bitmaps.");

                if (BootTvPath != null)
                    tmp = new Bitmap(BootTvPath);
                else
                    tmp = BootTvImg.Create();
                bootTvImg = new Bitmap(1280, 720, PixelFormat.Format24bppRgb);
                g = Graphics.FromImage(bootTvImg);
                g.DrawImage(tmp, new Rectangle(0, 0, 1280, 720));
                g.Dispose();
                tmp.Dispose();

                if (BootDrcPath != null)
                    tmp = new Bitmap(BootDrcPath);
                else
                    tmp = BootDrcImg.Create();
                bootDrcImg = new Bitmap(854, 480, PixelFormat.Format24bppRgb);
                g = Graphics.FromImage(bootDrcImg);
                g.DrawImage(tmp, new Rectangle(0, 0, 854, 480));
                g.Dispose();
                tmp.Dispose();

                if (IconPath != null)
                    tmp = new Bitmap(IconPath);
                else
                    tmp = IconImg.Create();
                iconImg = new Bitmap(128, 128, PixelFormat.Format32bppArgb);
                g = Graphics.FromImage(iconImg);
                g.DrawImage(tmp, new Rectangle(0, 0, 128, 128));
                g.Dispose();
                tmp.Dispose();

                Cll.Log.WriteLine("Bitmaps created.");
            }
            catch
            {
                Cll.Log.WriteLine("Error creating bitmaps.");
                return false;
            }

            if (!NusContent.ConvertToTGA(bootTvImg, currentDir + "\\base\\meta\\bootTvTex.tga"))
            {
                Cll.Log.WriteLine("Error creating \"bootTvTex.tga\" file.");
                return false;
            }
            if (!NusContent.ConvertToTGA(bootDrcImg, currentDir + "\\base\\meta\\bootDrcTex.tga"))
            {
                Cll.Log.WriteLine("Error creating \"bootDrcTex.tga\" file.");
                return false;
            }
            if (!NusContent.ConvertToTGA(iconImg, currentDir + "\\base\\meta\\iconTex.tga"))
            {
                Cll.Log.WriteLine("Error creating \"iconTex.tga\" file.");
                return false;
            }

            Cll.Log.WriteLine("Injected TGA files.");

            return true;
        }

        private bool InjectMeta()
        {
            string titleId = TitleId;
            byte[] id = Useful.StrHexToByteArray(titleId, "");

            XmlWriterSettings xmlSettings = new XmlWriterSettings
            {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\n",
                NewLineHandling = NewLineHandling.Replace
            };

            XmlDocument xmlApp = new XmlDocument();
            XmlDocument xmlMeta = new XmlDocument();

            try
            {
                Cll.Log.WriteLine("Editing \"app.xml\" and \"meta.xml\" files.");

                xmlApp.Load("base\\code\\app.xml");
                xmlMeta.Load("base\\meta\\meta.xml");

                XmlNode app_title_id = xmlApp.SelectSingleNode("app/title_id");
                XmlNode app_group_id = xmlApp.SelectSingleNode("app/group_id");

                XmlNode meta_product_code = xmlMeta.SelectSingleNode("menu/product_code");
                XmlNode meta_title_id = xmlMeta.SelectSingleNode("menu/title_id");
                XmlNode meta_group_id = xmlMeta.SelectSingleNode("menu/group_id");
                XmlNode meta_longname_ja = xmlMeta.SelectSingleNode("menu/longname_ja");
                XmlNode meta_longname_en = xmlMeta.SelectSingleNode("menu/longname_en");
                XmlNode meta_longname_fr = xmlMeta.SelectSingleNode("menu/longname_fr");
                XmlNode meta_longname_de = xmlMeta.SelectSingleNode("menu/longname_de");
                XmlNode meta_longname_it = xmlMeta.SelectSingleNode("menu/longname_it");
                XmlNode meta_longname_es = xmlMeta.SelectSingleNode("menu/longname_es");
                XmlNode meta_longname_zhs = xmlMeta.SelectSingleNode("menu/longname_zhs");
                XmlNode meta_longname_ko = xmlMeta.SelectSingleNode("menu/longname_ko");
                XmlNode meta_longname_nl = xmlMeta.SelectSingleNode("menu/longname_nl");
                XmlNode meta_longname_pt = xmlMeta.SelectSingleNode("menu/longname_pt");
                XmlNode meta_longname_ru = xmlMeta.SelectSingleNode("menu/longname_ru");
                XmlNode meta_longname_zht = xmlMeta.SelectSingleNode("menu/longname_zht");
                XmlNode meta_shortname_ja = xmlMeta.SelectSingleNode("menu/shortname_ja");
                XmlNode meta_shortname_en = xmlMeta.SelectSingleNode("menu/shortname_en");
                XmlNode meta_shortname_fr = xmlMeta.SelectSingleNode("menu/shortname_fr");
                XmlNode meta_shortname_de = xmlMeta.SelectSingleNode("menu/shortname_de");
                XmlNode meta_shortname_it = xmlMeta.SelectSingleNode("menu/shortname_it");
                XmlNode meta_shortname_es = xmlMeta.SelectSingleNode("menu/shortname_es");
                XmlNode meta_shortname_zhs = xmlMeta.SelectSingleNode("menu/shortname_zhs");
                XmlNode meta_shortname_ko = xmlMeta.SelectSingleNode("menu/shortname_ko");
                XmlNode meta_shortname_nl = xmlMeta.SelectSingleNode("menu/shortname_nl");
                XmlNode meta_shortname_pt = xmlMeta.SelectSingleNode("menu/shortname_pt");
                XmlNode meta_shortname_ru = xmlMeta.SelectSingleNode("menu/shortname_ru");
                XmlNode meta_shortname_zht = xmlMeta.SelectSingleNode("menu/shortname_zht");

                app_title_id.InnerText = titleId;
                app_group_id.InnerText = "0000" + id[5].ToString("X2") + id[6].ToString("X2");

                meta_product_code.InnerText = "WUP-N-" + Rom.ProductCode;
                meta_title_id.InnerText = titleId;
                meta_group_id.InnerText = "0000" + id[5].ToString("X2") + id[6].ToString("X2");
                meta_longname_ja.InnerText = LongName;
                meta_longname_en.InnerText = LongName;
                meta_longname_fr.InnerText = LongName;
                meta_longname_de.InnerText = LongName;
                meta_longname_it.InnerText = LongName;
                meta_longname_es.InnerText = LongName;
                meta_longname_zhs.InnerText = LongName;
                meta_longname_ko.InnerText = LongName;
                meta_longname_nl.InnerText = LongName;
                meta_longname_pt.InnerText = LongName;
                meta_longname_ru.InnerText = LongName;
                meta_longname_zht.InnerText = LongName;
                meta_shortname_ja.InnerText = ShortName;
                meta_shortname_en.InnerText = ShortName;
                meta_shortname_fr.InnerText = ShortName;
                meta_shortname_de.InnerText = ShortName;
                meta_shortname_it.InnerText = ShortName;
                meta_shortname_es.InnerText = ShortName;
                meta_shortname_zhs.InnerText = ShortName;
                meta_shortname_ko.InnerText = ShortName;
                meta_shortname_nl.InnerText = ShortName;
                meta_shortname_pt.InnerText = ShortName;
                meta_shortname_ru.InnerText = ShortName;
                meta_shortname_zht.InnerText = ShortName;

                XmlWriter app = XmlWriter.Create("base\\code\\app.xml", xmlSettings);
                XmlWriter meta = XmlWriter.Create("base\\meta\\meta.xml", xmlSettings);

                xmlApp.Save(app);
                xmlMeta.Save(meta);

                app.Close();
                meta.Close();

                Cll.Log.WriteLine("\"app.xml\" and \"meta.xml\" files editing successfully.");

                return true;
            }
            catch
            {
                Cll.Log.WriteLine("Error editing \"app.xml\" and \"meta.xml\" files.");
            }

            return false;
        }

        private bool InjectRom()
        {
            bool injected = true;

            try
            {
                Cll.Log.WriteLine("Empty \"base\\content\\config\" folder.");
                if (Directory.Exists("base\\content\\0010\\rom"))
                    Directory.Delete("base\\content\\0010\\rom", true);

                if (File.Exists("base\\content\\0010\\rom.zip"))
                {
                    Cll.Log.WriteLine("Erasing \"base\\content\\0010\\rom.zip\" file.");
                    File.Delete("base\\content\\0010\\rom.zip");
                }

                Cll.Log.WriteLine("Injecting ROM.");
                Cll.Log.WriteLine("CRC16: " + Rom.HashCRC16.ToString("X4"));

                Directory.CreateDirectory("base\\content\\0010\\rom");

                Cll.Log.WriteLine("In: \"base\\content\\0010\\rom\\U" + Rom.ProductCodeVersion + ".nds\"");
                File.Copy(RomPath, "base\\content\\0010\\rom\\U" + Rom.ProductCodeVersion + ".nds");

                Cll.Log.WriteLine("Compressed in: \"base\\content\\0010\\rom.zip\"");
                ZipFile.CreateFromDirectory("base\\content\\0010\\rom", "base\\content\\0010\\rom.zip");

                if (Directory.Exists("base\\content\\0010\\rom"))
                    Directory.Delete("base\\content\\0010\\rom", true);

                Cll.Log.WriteLine("Injected ROM.");
            }
            catch
            {
                Cll.Log.WriteLine("Error injecting ROM.");
                injected = false;
            }

            return injected;
        }


        #region Loads

        public bool LoadBase(string path)
        {
            if (Directory.Exists("base"))
            {
                Directory.Delete("base", true);
                Cll.Log.WriteLine("Previous base deleted.");
            }

            if (IsValidBase(path))
            {
                Cll.Log.WriteLine("The \"" + path + "\" folder contains a valid base.");
                Useful.DirectoryCopy(path, "base", true);
            }
            else if (IsValidEncryptedBase(path))
            {
                Cll.Log.WriteLine("The \"" + path + "\" folder contains a valid encrypted base.");
                NusContent.Decrypt(path, "base");
            }
            else
                Cll.Log.WriteLine("The \"" + path + "\" folder not contains a valid base.");

            _base = GetLoadedBase();

            return BaseIsLoaded;
        }

        private VCNDS GetLoadedBase()
        {
            if (IsValidBase("base"))
            {
                FileStream fs = File.Open("base\\code\\hachihachi_ntr.rpx", FileMode.Open);
                uint hash = Cll.Security.ComputeCRC32(fs);
                fs.Close();

                switch (hash)
                {
                    case 0xCD2CFD15: return VCNDS.Title01;
                    case 0x8071CB03: return VCNDS.Title02;
                    case 0x9454C9D0: return VCNDS.Title03;
                    case 0xE0207B48: return VCNDS.Title04;
                    case 0xDBF04FD0: return VCNDS.Title05;
                    case 0x70AB80AC: return VCNDS.Title06;
                    case 0x99D0711F: return VCNDS.Title07;
                    case 0xDCB3AB59: return VCNDS.Title08;
                    case 0xEF47DDC4: return VCNDS.Title09;
                    case 0x71110CE9: return VCNDS.Title10;
                    case 0xEEEB4E36: return VCNDS.Title11;
                    case 0x9566F967: return VCNDS.Title12;
                    case 0x746411E4: return VCNDS.Title13;
                    case 0x16B0D355: return VCNDS.Title14;
                    case 0xDA012FA8: return VCNDS.Title15;
                    case 0x76949547: return VCNDS.Title16;
                    case 0x4489EF3E: return VCNDS.Title17;
                    case 0x52DEFCB3: return VCNDS.Title18;
                    case 0x595D3B65: return VCNDS.Title19;
                    case 0x320B05E2: return VCNDS.Title20;
                    case 0xFF82AF20: return VCNDS.Title21;
                    case 0x70783B5F: return VCNDS.Title22;
                    case 0x2FF26429: return VCNDS.Title23;
                    case 0x816543BD: return VCNDS.Title24;
                    case 0x563921C1: return VCNDS.Title25;
                    case 0x52319B0A: return VCNDS.Title26;
                    case 0xB8454E86: return VCNDS.Title27;
                    default:
                        Cll.Log.WriteLine("The base is valid but was not defined in the program code.");
                        return new VCNDS(hash);
                }
            }
            else
                return null;
        }

        #endregion

        #region Validations

        private bool IsValidBase(string path)
        {
            bool valid = true;
            string[] folders = {
                path + "\\content\\0010\\assets",
                path + "\\content\\0010\\data"
            };
            string[] files = {
                path + "\\code\\app.xml",
                path + "\\code\\cos.xml",
                path + "\\code\\hachihachi_ntr.rpx",
                path + "\\content\\0010\\configuration_cafe.json",
                path + "\\content\\0010\\rom.zip",
                path + "\\meta\\iconTex.tga",
                path + "\\meta\\bootTvTex.tga",
                path + "\\meta\\bootDrcTex.tga",
                path + "\\meta\\meta.xml"
            };

            foreach (string folder in folders)
            {
                if (!Directory.Exists(folder))
                {
                    valid = false;
                    Cll.Log.WriteLine("This folder is missing: \"" + folder + "\"");
                }
            }

            foreach (string file in files)
            {
                if (!File.Exists(file))
                {
                    valid = false;
                    Cll.Log.WriteLine("This file is missing: \"" + file + "\"");
                }
            }

            if (!valid)
                Cll.Log.WriteLine("The base is invalid.");

            return valid;
        }

        private bool IsValidEncryptedBase(string path)
        {
            string titleId = NusContent.CheckEncrypted(path);
            if (titleId != null &&
                NusContent.CheckCommonKeyFiles() &&
                File.Exists("resources\\jnustool\\JNUSTool.jar"))
            {
                string name = NusContent.JNUSToolWrapper(path, 400, 32768, titleId, "/code/cos.xml");

                if (name != null && File.Exists(name + "\\code\\cos.xml"))
                {
                    XmlDocument xmlCos = new XmlDocument();
                    xmlCos.Load(name + "\\code\\cos.xml");
                    XmlNode cos_argstr = xmlCos.SelectSingleNode("app/argstr");

                    Directory.Delete(name, true);

                    if (cos_argstr.InnerText == "hachihachi_ntr.rpx")
                        return true;
                    else
                    {
                        Cll.Log.WriteLine("\"" + path + "\" does not contain a NDS Wii U VC game.");
                        return false;
                    }
                }
                else if (name != null)
                {
                    Cll.Log.WriteLine("The NUS CONTENT does not contains \"cos.xml\" file.");
                    Directory.Delete(name, true);
                    return false;
                }
                else
                {
                    Cll.Log.WriteLine("JNUSToolWrapper could not decipher the NUS CONTENT.");
                    return false;
                }
            }
            else
            {
                Cll.Log.WriteLine("Some of the following files are missing:");
                Cll.Log.WriteLine(path + "\\title.tmd");
                Cll.Log.WriteLine(path + "\\title.tik");
                Cll.Log.WriteLine(path + "\\title.cert");
                return false;
            }
        }

        #endregion
    }
}
