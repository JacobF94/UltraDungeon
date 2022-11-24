namespace Game
{
    public class Player
    {
        public string Name { get; }
        public int Health { get; set; }
        public int Gold { get; set; }
        public int Mana { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public int Score { get; set; }
        public int Speed { get; set; }
        public Dictionary<int, string> Titles = new()
        {
            { 1, "Novice"},
            { 2, "Journeyman(woman)"},
            { 3, "Adept"},
            { 4, "Skilled"},
            { 5, "Master"},
            { 6, "Brave"},
            { 7, "Sage"},
            { 8, "Unstoppable"},
            { 9, "Incredible"},
            { 10, "Ultimate"}
        };
        public List<Armor> Armors = new List<Armor>();
        public List<Spell> Spells = new List<Spell>();
        public List<Weapon> Weapons = new List<Weapon>();
        public Player(string name)
        {
            Name = name;
            Health = 10;
            Gold = 0;
            Mana = 0;
            Exp = 0;
            Level = 1;
            Score = 0;
        }
        public string GetPlayerStatus()
        {
            string currentTitle = Titles.FirstOrDefault(x => x.Key == Level).Value;
            return $"{Name} the {currentTitle} has {Health} health, {Gold} gold, and {Mana} mana!";
        }
    }
}