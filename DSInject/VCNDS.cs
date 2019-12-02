using System;

namespace DSInject
{
    public class VCNDS
    {
        public readonly int Index;
        public readonly uint Hash;
        public readonly DateTime Date;
        public readonly string Title;

        public VCNDS(int index, uint hash, DateTime date, string title)
        {
            Index = index;
            Hash = hash;
            Date = date;
            Title = title;
        }

        public VCNDS(uint hash)
        {
            Index = 0;
            Hash = hash;
            Date = new DateTime();
            Title = "Unknown";
        }

        public override string ToString()
        {
            return "Hash: " + Hash.ToString("X8") + ", Release date: " + Date.ToString("yyyy/MM/dd") + " \nTitle: " + Title;
        }

        /// <summary>Big Brain Academy (USA/EUR/JPN)/WarioWare: Touched! (USA/EUR/JPN)/Yoshi’s Island DS (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title01 = new VCNDS(01, 0xCD2CFD15, new DateTime(2015, 4, 1), "Big Brain Academy (USA/EUR/JPN)/WarioWare: Touched! (USA/EUR/JPN)\nYoshi’s Island DS (USA/EUR/JPN)");
        /// <summary>Mario Kart DS (USA/EUR/JPN)/New Super Mario Bros. (USA/JPN)</summary>
        public static readonly VCNDS Title02 = new VCNDS(02, 0x8071CB03, new DateTime(2015, 4, 2), "Mario Kart DS (USA/EUR/JPN)/New Super Mario Bros. (USA/JPN)");
        /// <summary>Brain Age: Train Your Brain in Minutes a Day! (USA/EUR/JPN)/Yoshi Touch and Go (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title03 = new VCNDS(03, 0x9454C9D0, new DateTime(2015, 4, 9), "Brain Age: Train Your Brain in Minutes a Day! (USA/EUR/JPN)\nYoshi Touch & Go (USA/EUR/JPN)");
        /// <summary>Mario and Luigi: Partners in Time (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title04 = new VCNDS(04, 0xE0207B48, new DateTime(2015, 6, 10), "Mario & Luigi: Partners in Time (USA/EUR/JPN)");
        /// <summary>Star Fox Command (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title05 = new VCNDS(05, 0xDBF04FD0, new DateTime(2015, 6, 25), "Star Fox Command (USA/EUR/JPN)");
        /// <summary>Kirby: Squeak Squad (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title06 = new VCNDS(06, 0x70AB80AC, new DateTime(2015, 6, 25), "Kirby: Squeak Squad (USA/EUR/JPN)");
        /// <summary>Fire Emblem: Shadow Dragon (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title07 = new VCNDS(07, 0x99D0711F, new DateTime(2015, 7, 2), "Fire Emblem: Shadow Dragon (USA/EUR/JPN)");
        /// <summary>DK: Jungle Climber (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title08 = new VCNDS(08, 0xDCB3AB59, new DateTime(2015, 7, 8), "DK: Jungle Climber (USA/EUR/JPN)");
        /// <summary>Wario: Master of Disguise (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title09 = new VCNDS(09, 0xEF47DDC4, new DateTime(2015, 8, 20), "Wario: Master of Disguise (USA/EUR/JPN)");
        /// <summary>Mario vs. Donkey Kong 2: March of the Minis (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title10 = new VCNDS(10, 0x71110CE9, new DateTime(2015, 9, 17), "Mario vs. Donkey Kong 2: March of the Minis (USA/EUR/JPN)");
        /// <summary>Metroid Prime Hunters (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title11 = new VCNDS(11, 0xEEEB4E36, new DateTime(2015, 9, 30), "Metroid Prime Hunters (USA/EUR/JPN)");
        /// <summary>The Legend of Zelda: Phantom Hourglass (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title12 = new VCNDS(12, 0x9566F967, new DateTime(2015, 11, 13), "The Legend of Zelda: Phantom Hourglass (USA/EUR/JPN)");
        /// <summary>The Legend of Zelda: Spirit Tracks (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title13 = new VCNDS(13, 0x746411E4, new DateTime(2015, 11, 13), "The Legend of Zelda: Spirit Tracks (USA/EUR/JPN)");
        /// <summary>Animal Crossing: Wild World (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title14 = new VCNDS(14, 0x16B0D355, new DateTime(2015, 11, 19), "Animal Crossing: Wild World (USA/EUR/JPN)");
        /// <summary>Super Mario 64 DS (USA/EUR/JPN)/Kirby: Canvas Curse (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title15 = new VCNDS(15, 0xDA012FA8, new DateTime(2015, 12, 3), "Super Mario 64 DS (USA/EUR/JPN)/Kirby: Canvas Curse (USA/EUR/JPN)");
        /// <summary>Kirby: Mass Attack (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title16 = new VCNDS(16, 0x76949547, new DateTime(2015, 12, 3), "Kirby: Mass Attack (USA/EUR/JPN)");
        /// <summary>New Super Mario Bros. (EUR)</summary>
        public static readonly VCNDS Title17 = new VCNDS(17, 0x4489EF3E, new DateTime(2015, 12, 17), "New Super Mario Bros. (EUR)");
        /// <summary>Pokémon Ranger (USA)/Pokémon Mystery Dungeon: Blue Rescue Team (USA/EUR)</summary>
        public static readonly VCNDS Title18 = new VCNDS(18, 0x52DEFCB3, new DateTime(2016, 2, 11), "Pokémon Ranger (USA)/Pokémon Mystery Dungeon: Blue Rescue Team (USA/EUR)");
        /// <summary>Pokémon Ranger (EUR)</summary>
        public static readonly VCNDS Title19 = new VCNDS(19, 0x595D3B65, new DateTime(2016, 2, 25), "Pokémon Ranger (EUR)");
        /// <summary>Pokémon Ranger (JPN)/Pokémon Mystery Dungeon: Blue Rescue Team (JPN)</summary>
        public static readonly VCNDS Title20 = new VCNDS(20, 0x320B05E2, new DateTime(2016, 3, 23), "Pokémon Ranger (JPN)/Pokémon Mystery Dungeon: Blue Rescue Team (JPN)");
        /// <summary>Mario Party DS (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title21 = new VCNDS(21, 0xFF82AF20, new DateTime(2016, 4, 21), "Mario Party DS (USA/EUR/JPN)");
        /// <summary>Style Savvy (USA/EUR)</summary>
        public static readonly VCNDS Title22 = new VCNDS(22, 0x70783B5F, new DateTime(2016, 5, 5), "Style Savvy (USA/EUR)");
        /// <summary>Mario Hoops 3-on-3 (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title23 = new VCNDS(23, 0x2FF26429, new DateTime(2016, 5, 11), "Mario Hoops 3-on-3 (USA/EUR/JPN)");
        /// <summary>Advance Wars: Dual Strike (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title24 = new VCNDS(24, 0x816543BD, new DateTime(2016, 5, 11), "Advance Wars: Dual Strike (USA/EUR/JPN)");
        /// <summary>Pokémon Ranger: Guardian Signs (JPN)/Pokémon Ranger: Shadows of Almia (USA/EUR/JPN)/Pokémon Mystery Dungeon: Explorers of Sky (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title25 = new VCNDS(25, 0x563921C1, new DateTime(2016, 6, 9), "Pokémon Ranger: Guardian Signs (JPN)/Pokémon Ranger: Shadows of Almia (USA/EUR/JPN)\nPokémon Mystery Dungeon: Explorers of Sky (USA/EUR/JPN)");
        /// <summary>Pokémon Ranger: Guardian Signs (USA/EUR)</summary>
        public static readonly VCNDS Title26 = new VCNDS(26, 0x52319B0A, new DateTime(2016, 6, 9), "Pokémon Ranger: Guardian Signs (USA/EUR)");
        /// <summary>Style Savvy (JPN)/Picross 3D (USA/EUR/JPN)</summary>
        public static readonly VCNDS Title27 = new VCNDS(27, 0xB8454E86, new DateTime(2016, 7, 13), "Style Savvy (JPN)/Picross 3D (USA/EUR/JPN)");
    }
}
