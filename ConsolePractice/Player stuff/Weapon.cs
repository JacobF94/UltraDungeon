namespace Game
{
    public class Weapon
    {
        public string Description { get; set; }
        public int Power { get; set; }
        public int Cost { get; set; }
        private SortedDictionary<string, int> Types = new()
        {
            {"Iron Sword", 3 },
            {"Steel Dagger", 5},
            {"Magic Mace", 10},
            {"Erudite Staff",20 },
            {"Excalipoor", 50}
        };
        public Weapon()
        {
            Random seed = new();
            int newType = seed.Next(1, 5);
            Description = Types.ElementAt(newType).Key;
            Power = Types.ElementAt(newType).Value;
            Cost = Power * 2;
        }
    }
}
