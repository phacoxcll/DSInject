using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;

namespace DSInject
{
    public class DSInjector
    {
        public const string Release = "1.1 debug"; //CllVersionReplace "major.minor stability"

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
                ulong crc;

                if (BaseIsLoaded)
                    crc = _base.HashCRC32;
                else
                    crc = Cll.Security.ComputeCRC32(new byte[] { }, 0, 0);

                if (RomIsLoaded)
                    crc += Rom.HashCRC32;
                else
                    crc += Cll.Security.ComputeCRC32(new byte[] { }, 0, 0);
                crc >>= 1;

                byte[] b = BitConverter.GetBytes((uint)crc);
                ushort id = (ushort)((((b[3] << 8) + (b[2])) + ((b[1] << 8) + (b[0]))) >> 1);

                int flags = 0;
                flags |= IconImg.IsDefault ? 0 : 0x10;
                flags |= BootTvImg.IsDefault ? 0 : 8;
                flags |= BootDrcImg.IsDefault ? 0 : 4;

                return "00050000D5" + id.ToString("X4") + ((byte)(flags)).ToString("X2");
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
            Cll.Log.WriteLine("The base is ready: " + _continue.ToString());

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
                XmlNode meta_longname_en = xmlMeta.SelectSingleNode("menu/longname_en");
                XmlNode meta_shortname_en = xmlMeta.SelectSingleNode("menu/shortname_en");

                app_title_id.InnerText = titleId;
                app_group_id.InnerText = "0000" + id[5].ToString("X2") + id[6].ToString("X2");

                meta_product_code.InnerText = "WUP-N-" + Rom.ProductCode;
                meta_title_id.InnerText = titleId;
                meta_group_id.InnerText = "0000" + id[5].ToString("X2") + id[6].ToString("X2");
                meta_longname_en.InnerText = LongName;
                meta_shortname_en.InnerText = ShortName;

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
                Directory.CreateDirectory("base\\content\\0010\\rom");

                File.Copy(RomPath, "base\\content\\0010\\rom\\U" + Rom.ProductCodeVersion + ".nds");

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

                if (hash == VCNDS.BigBrainAcademy.HashCRC32)
                    return VCNDS.BigBrainAcademy;
                else if (hash == VCNDS.MarioKartDS.HashCRC32)
                    return VCNDS.MarioKartDS;
                else if (hash == VCNDS.BrainAge.HashCRC32)
                    return VCNDS.BrainAge;
                else if (hash == VCNDS.PartnersInTime.HashCRC32)
                    return VCNDS.PartnersInTime;
                else if (hash == VCNDS.StarFoxCommand.HashCRC32)
                    return VCNDS.StarFoxCommand;
                else if (hash == VCNDS.KirbySqueakSquad.HashCRC32)
                    return VCNDS.KirbySqueakSquad;
                else if (hash == VCNDS.FEShadowDragon.HashCRC32)
                    return VCNDS.FEShadowDragon;
                else if (hash == VCNDS.DKJungleClimber.HashCRC32)
                    return VCNDS.DKJungleClimber;
                else if (hash == VCNDS.WarioMasterOfDisguise.HashCRC32)
                    return VCNDS.WarioMasterOfDisguise;
                else if (hash == VCNDS.MarioVsDK2.HashCRC32)
                    return VCNDS.MarioVsDK2;
                else if (hash == VCNDS.MetroidPrimeHunters.HashCRC32)
                    return VCNDS.MetroidPrimeHunters;
                else if (hash == VCNDS.PhantomHourglass.HashCRC32)
                    return VCNDS.PhantomHourglass;
                else if (hash == VCNDS.SpiritTracks.HashCRC32)
                    return VCNDS.SpiritTracks;
                else if (hash == VCNDS.ACWildWorld.HashCRC32)
                    return VCNDS.ACWildWorld;
                else if (hash == VCNDS.SuperMario64DS.HashCRC32)
                    return VCNDS.SuperMario64DS;
                else if (hash == VCNDS.KirbyMassAttack.HashCRC32)
                    return VCNDS.KirbyMassAttack;
                else if (hash == VCNDS.NewSuperMarioBros.HashCRC32)
                    return VCNDS.NewSuperMarioBros;
                else if (hash == VCNDS.PokemonRangerU.HashCRC32)
                    return VCNDS.PokemonRangerU;
                else if (hash == VCNDS.PokemonRangerE.HashCRC32)
                    return VCNDS.PokemonRangerE;
                else if (hash == VCNDS.PokemonRangerJ.HashCRC32)
                    return VCNDS.PokemonRangerJ;
                else if (hash == VCNDS.MarioPartyDS.HashCRC32)
                    return VCNDS.MarioPartyDS;
                else if (hash == VCNDS.StyleSavvyU.HashCRC32)
                    return VCNDS.StyleSavvyU;
                else if (hash == VCNDS.MarioHoops3On3.HashCRC32)
                    return VCNDS.MarioHoops3On3;
                else if (hash == VCNDS.AdvanceWarsDualStrike.HashCRC32)
                    return VCNDS.AdvanceWarsDualStrike;
                else if (hash == VCNDS.PokemonRanger3J.HashCRC32)
                    return VCNDS.PokemonRanger3J;
                else if (hash == VCNDS.PokemonRanger3U.HashCRC32)
                    return VCNDS.PokemonRanger3U;
                else if (hash == VCNDS.StyleSavvyJ.HashCRC32)
                    return VCNDS.StyleSavvyJ;
                else
                {
                    Cll.Log.WriteLine("The base is valid but was not defined in the program code.");
                    return new VCNDS(hash, "", "**Unidentified**");
                }
            }
            else
                return null;
        }

        #endregion

        #region Validations

        private bool IsValidBase(string path)
        {
            if (File.Exists(path + "\\code\\app.xml") &&
                File.Exists(path + "\\code\\cos.xml") &&
                File.Exists(path + "\\code\\hachihachi_ntr.rpx") &&
                Directory.Exists(path + "\\content\\0010\\assets") &&
                Directory.Exists(path + "\\content\\0010\\data") &&
                File.Exists(path + "\\content\\0010\\configuration_cafe.json") &&
                File.Exists(path + "\\content\\0010\\rom.zip") &&
                File.Exists(path + "\\meta\\iconTex.tga") &&
                File.Exists(path + "\\meta\\bootTvTex.tga") &&
                File.Exists(path + "\\meta\\bootDrcTex.tga") &&
                File.Exists(path + "\\meta\\meta.xml"))
                return true;
            else
            {
                Cll.Log.WriteLine("The base is invalid.");
                Cll.Log.WriteLine("Some of the following files or folders are missing:");
                Cll.Log.WriteLine(path + "\\code\\app.xml");
                Cll.Log.WriteLine(path + "\\code\\cos.xml");
                Cll.Log.WriteLine(path + "\\code\\hachihachi_ntr.rpx");
                Cll.Log.WriteLine(path + "\\content\\0010\\assets");
                Cll.Log.WriteLine(path + "\\content\\0010\\data");
                Cll.Log.WriteLine(path + "\\content\\0010\\configuration_cafe.json");
                Cll.Log.WriteLine(path + "\\content\\0010\\rom.zip");
                Cll.Log.WriteLine(path + "\\meta\\iconTex.tga");
                Cll.Log.WriteLine(path + "\\meta\\bootTvTex.tga");
                Cll.Log.WriteLine(path + "\\meta\\bootDrcTex.tga");
                Cll.Log.WriteLine(path + "\\meta\\meta.xml");
                return false;
            }
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

        public bool IsValidCode(string code)
        {
            if (code.Length == 4)
            {
                foreach (char c in code)
                {
                    if ((c < 'A' || c > 'Z') && (c < '0' || c > '9'))
                        return false;
                }
            }
            else
                return false;

            return true;
        }

        #endregion
    }
}
