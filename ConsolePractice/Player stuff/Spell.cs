namespace Game
{
    public class Spell
    {
        public string Description { get; set; }
        public int Power { get; set; }
        public int Cost { get; set; }
        private SortedDictionary<string, int> Types = new()
        {
            {"Magic Missile", 4 },
            {"Flaming Ray", 8},
            {"Dark Explosion", 12},
            {"Frost Fire", 20 },
            {"Apocalypse", 65}
        };
        public Spell()
        {
            Random seed = new();
            int newType = seed.Next(1, 5);
            Description = Types.ElementAt(newType).Key;
            Power = Types.ElementAt(newType).Value;
            Cost = Power * 2;
        }
    }
}
