using Game;

namespace ConsolePractice.Evil
{
    public class Monster
    {
        public Dictionary<int, string> NameParts = new()
        {
            {1, "shal" },
            {2, "borg" },
            {3, "naw" },
            {4, "sman" },
            {5, "tors" },
            {6, "pal" },
            {7, "roo" },
            {8, "ble" },
            {9, "try" },
            {10, "eeeee" },
            {11, "scu" },
            {12, "e'ta" },
            {13, "shwa" },
            {14, "pete-rat" },
            {15, "oska" }
        };
        public Dictionary<int, string> Descriptors = new()
        {
            {1, "Dragon" },
            {2, "Vampire" },
            {3, "Unicorn" },
            {4, "Warewolf" },
            {5, "Succubus" },
            {6, "Slime" },
            {7, "Zombie" },
            {8, "Evil Knight" },
            {9, "Wizard" },
            {10, "Sorcerer" },
            {11, "Freak" },
            {12, "Police Officer" }
        };
        public string Name { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int Str { get; set; }
        public int Speed { get; set; }

        public Monster()
        {
            Random seed = new();
            Name = NameParts[seed.Next(1, 15)] + NameParts[seed.Next(1, 15)] + NameParts[seed.Next(1, 15)] + NameParts[seed.Next(1, 15)];
            Description = Descriptors[seed.Next(1, 12)];
        }
        public string Status()
        {
            return $"The monster {Name} is a {Description}!! It has {HP} health and {Str} attacking power.";
        }
    }
}