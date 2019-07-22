
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

        public static readonly VCNDS YoshiIslandDS         = new VCNDS(0xCD2CFD15, "Release date: 2015-04-01", "Yoshi’s Island DS (USA)");
        public static readonly VCNDS YoshiTouchAndGo       = new VCNDS(0x9454C9D0, "Release date: 2015-04-09", "Yoshi Touch && Go (USA)");
        public static readonly VCNDS MarioKartDS           = new VCNDS(0x8071CB03, "Release date: 2015-04-23", "Mario Kart DS (USA)");
        public static readonly VCNDS PartnersInTime        = new VCNDS(0xE0207B48, "Release date: 2015-06-25", "Mario && Luigi: Partners in Time (USA)");
        public static readonly VCNDS StarFoxCommand        = new VCNDS(0xDBF04FD0, "Release date: 2015-06-25", "Star Fox Command (USA)");
        public static readonly VCNDS DKJungleClimber       = new VCNDS(0xDCB3AB59, "Release date: 2015-07-23", "DK: Jungle Climber (USA)");
        public static readonly VCNDS KirbySqueakSquad      = new VCNDS(0x70AB80AC, "Release date: 2015-07-30", "Kirby: Squeak Squad (USA)");
        public static readonly VCNDS MarioPartyDS          = new VCNDS(0xFF82AF20, "Release date: 2016-04-21", "Mario Party DS (USA)");
        public static readonly VCNDS StyleSavvy            = new VCNDS(0x70783B5F, "Release date: 2016-05-05", "Style Savvy (USA)");
        public static readonly VCNDS PhantomHourglass      = new VCNDS(0x9566F967, "Release date: 2016-05-12", "The Legend of Zelda: Phantom Hourglass (USA)");
        public static readonly VCNDS MetroidPrimeHunters   = new VCNDS(0xEEEB4E36, "Release date: 2016-06-02", "Metroid Prime Hunters (USA)");
        public static readonly VCNDS WarioMasterOfDisguise = new VCNDS(0xEF47DDC4, "Release date: 2016-06-09", "Wario: Master of Disguise (USA)");
        public static readonly VCNDS PMDBlueRescueTeam     = new VCNDS(0x52DEFCB3, "Release date: 2016-06-23", "Pokémon Mystery Dungeon: Blue Rescue Team (USA)");
        public static readonly VCNDS PMDExplorersOfSky     = new VCNDS(0x563921C1, "Release date: 2016-06-23", "Pokémon Mystery Dungeon: Explorers of Sky (USA)");
        public static readonly VCNDS KirbyMassAttack       = new VCNDS(0x76949547, "Release date: 2016-07-28", "Kirby: Mass Attack (USA)");
        public static readonly VCNDS PRGuardianSigns       = new VCNDS(0x52319B0A, "Release date: 2016-08-18", "Pokémon Ranger: Guardian Signs (USA)");
        public static readonly VCNDS SuperMario64DS        = new VCNDS(0xDA012FA8, "Release date: 2016-08-25", "Super Mario 64 DS (USA)");
        public static readonly VCNDS MarioVsDK2            = new VCNDS(0x71110CE9, "Release date: 2016-10-06", "Mario vs. Donkey Kong 2: March of the Minis (USA)");
        public static readonly VCNDS ACWildWorld           = new VCNDS(0x16B0D355, "Release date: 2016-10-13", "Animal Crossing: Wild World (USA)");
        public static readonly VCNDS SpiritTracks          = new VCNDS(0x746411E4, "Release date: 2016-10-20", "The Legend of Zelda: Spirit Tracks (USA)");
        public static readonly VCNDS MarioHoops3On3        = new VCNDS(0x2FF26429, "Release date: 2016-11-03", "Mario Hoops 3-on-3 (USA)");
        public static readonly VCNDS AdvanceWarsDualStrike = new VCNDS(0x816543BD, "Release date: 2016-12-01", "Advance Wars: Dual Strike (USA)");
        public static readonly VCNDS FEShadowDragon        = new VCNDS(0x99D0711F, "Release date: 2016-12-08", "Fire Emblem: Shadow Dragon (USA)");
        public static readonly VCNDS Picross3D             = new VCNDS(0xB8454E86, "Release date: 2017-03-16", "Picross 3D (USA)");
    }
}
