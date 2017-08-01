namespace deckofcards
{
    public class Card
    {
        public string strVal;
        public string suit;
        public int val;

        public Card(string name, string suitType, int value)
        {
            strVal = name;
            suit = suitType;
            val = value;
        }
    }
}