namespace Game
{
    public class Armor
    {
        public string Description { get; set; }
        public int Value { get; set; }
        public int Cost { get; set; }
        private SortedDictionary<string, int> Types = new()
        {
            {"Leather", 3 },
            {"Iron", 5},
            {"Plate Mail", 10},
            {"Tempered",20 },
            {"Legendary", 50}
        };
        public Armor()
        {
            Random seed = new();
            int newType = seed.Next(1, 5);
            Description = Types.ElementAt(newType).Key;
            Value = Types.ElementAt(newType).Value;
            Cost = Value * 2;
        }
    }
}
