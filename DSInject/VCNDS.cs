
namespace DSInject
{
    public class VCNDS
    {
        public readonly uint HashCRC32;
        public readonly string Title;
        public readonly string Info;

        public VCNDS(uint hashCRC32, string info, string title)
        {
            HashCRC32 = hashCRC32;
            Title = title;
            Info = info;
        }

        public override string ToString()
        {
            return Title + "\nCRC32: " + HashCRC32.ToString("X8") + " " + Info;
        }

        public static readonly VCNDS BigBrainAcademy        = new VCNDS(0xCD2CFD15, "Release date: 2015-04-01", "Big Brain Academy (USA/EUR/JPN)/Yoshi’s Island DS (USA/EUR/JPN)/WarioWare: Touched! (USA/EUR/JPN)");
        public static readonly VCNDS MarioKartDS            = new VCNDS(0x8071CB03, "Release date: 2015-04-02", "Mario Kart DS (USA/EUR/JPN)/New Super Mario Bros. (USA/JPN)");
        public static readonly VCNDS BrainAge               = new VCNDS(0x9454C9D0, "Release date: 2015-04-09", "Brain Age: Train Your Brain in Minutes a Day! (USA/EUR/JPN)/Yoshi Touch & Go (USA/EUR/JPN)");
        public static readonly VCNDS PartnersInTime         = new VCNDS(0xE0207B48, "Release date: 2015-06-10", "Mario & Luigi: Partners in Time (USA/EUR/JPN)");
        public static readonly VCNDS StarFoxCommand         = new VCNDS(0xDBF04FD0, "Release date: 2015-06-25", "Star Fox Command (USA/EUR/JPN)");
        public static readonly VCNDS KirbySqueakSquad       = new VCNDS(0x70AB80AC, "Release date: 2015-06-25", "Kirby: Squeak Squad (USA/EUR/JPN)");
        public static readonly VCNDS FEShadowDragon         = new VCNDS(0x99D0711F, "Release date: 2015-07-02", "Fire Emblem: Shadow Dragon (USA/EUR/JPN)");
        public static readonly VCNDS DKJungleClimber        = new VCNDS(0xDCB3AB59, "Release date: 2015-07-08", "DK: Jungle Climber (USA/EUR/JPN)");
        public static readonly VCNDS WarioMasterOfDisguise  = new VCNDS(0xEF47DDC4, "Release date: 2015-08-20", "Wario: Master of Disguise (USA/EUR/JPN)");
        public static readonly VCNDS MarioVsDK2             = new VCNDS(0x71110CE9, "Release date: 2015-09-17", "Mario vs. Donkey Kong 2: March of the Minis (USA/EUR/JPN)");
        public static readonly VCNDS MetroidPrimeHunters    = new VCNDS(0xEEEB4E36, "Release date: 2015-09-30", "Metroid Prime Hunters (USA/EUR/JPN)");
        public static readonly VCNDS PhantomHourglass       = new VCNDS(0x9566F967, "Release date: 2015-11-13", "The Legend of Zelda: Phantom Hourglass (USA/EUR/JPN)");
        public static readonly VCNDS SpiritTracks           = new VCNDS(0x746411E4, "Release date: 2015-11-13", "The Legend of Zelda: Spirit Tracks (USA/EUR/JPN)");
        public static readonly VCNDS ACWildWorld            = new VCNDS(0x16B0D355, "Release date: 2015-11-19", "Animal Crossing: Wild World (USA/EUR/JPN)");
        public static readonly VCNDS SuperMario64DS         = new VCNDS(0xDA012FA8, "Release date: 2015-12-03", "Super Mario 64 DS (USA/EUR/JPN)/Kirby: Canvas Curse (USA/EUR/JPN)");
        public static readonly VCNDS KirbyMassAttack        = new VCNDS(0x76949547, "Release date: 2015-12-03", "Kirby: Mass Attack (USA/EUR/JPN)");
        public static readonly VCNDS NewSuperMarioBros      = new VCNDS(0x4489EF3E, "Release date: 2015-12-17", "New Super Mario Bros. (EUR)");
        public static readonly VCNDS PokemonRangerU         = new VCNDS(0x52DEFCB3, "Release date: 2016-02-11", "Pokémon Ranger (USA)/Pokémon Mystery Dungeon: Blue Rescue Team (USA/EUR)");
        public static readonly VCNDS PokemonRangerE         = new VCNDS(0x595D3B65, "Release date: 2016-02-25", "Pokémon Ranger (EUR)");
        public static readonly VCNDS PokemonRangerJ         = new VCNDS(0x320B05E2, "Release date: 2016-03-23", "Pokémon Ranger (JPN)/Pokémon Mystery Dungeon: Blue Rescue Team (JPN)/");
        public static readonly VCNDS MarioPartyDS           = new VCNDS(0xFF82AF20, "Release date: 2016-04-21", "Mario Party DS (USA/EUR/JPN)");
        public static readonly VCNDS StyleSavvyU            = new VCNDS(0x70783B5F, "Release date: 2016-05-05", "Style Savvy (USA/EUR)");
        public static readonly VCNDS MarioHoops3On3         = new VCNDS(0x2FF26429, "Release date: 2016-05-11", "Mario Hoops 3-on-3 (USA/EUR/JPN)");
        public static readonly VCNDS AdvanceWarsDualStrike  = new VCNDS(0x816543BD, "Release date: 2016-05-11", "Advance Wars: Dual Strike (USA/EUR/JPN)");
        public static readonly VCNDS PokemonRanger3J        = new VCNDS(0x563921C1, "Release date: 2016-06-09", "Pokémon Ranger: Guardian Signs (JPN)/Shadows of Almia (USA/EUR/JPN)/Pokémon MD: Explorers of Sky (USA/EUR/JPN)");
        public static readonly VCNDS PokemonRanger3U        = new VCNDS(0x52319B0A, "Release date: 2016-06-09", "Pokémon Ranger: Guardian Signs (USA/EUR)");
        public static readonly VCNDS StyleSavvyJ            = new VCNDS(0xB8454E86, "Release date: 2016-07-13", "Style Savvy (JPN)/Picross 3D (USA/EUR/JPN)");
    }
}
