namespace Game
{
    public class Armor
    {
        //Thinking I'll have two dictionaries - both have the item's name as the key and the two values will be armor type and then how much it increases player HP
        //Alternatively I could do a generic class for armor and then the consructor accepts all paramters which are somehow generated beforehand, but IDK
        //The first solution gives greater control with less ease of expansion, but imo easier to implement?

        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public int Cost { get; set; }
    }
}
