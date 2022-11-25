using Game;

namespace ConsolePractice.Evil
{
    public class Monster
    {
        public string[] NameParts = 
            {"shal", "borg", "naw", "sman", "tors", "pal", "roo", "ble", "try", "eeeee", "scu", "e'ta", "shwa", "pete-rat", "oska"};
        public string[] Descriptors =
            {"Dragon", "Vampire", "Unicorn", "Warewolf", "Succubus", "Slime", "Zombie", "Evil Knight", "Wizard", "Sorcerer", "Freak", "Police Officer"};
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