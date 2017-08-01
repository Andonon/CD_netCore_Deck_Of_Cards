using System.Collections.Generic;

namespace deckofcards
{
    public class Player
    {
        string name;
        public List<Card> hand;

        public Player(string person)
        {
            name = person;
            hand = new List<Card>();
        }

        public Card draw(Deck decky)
        {
            Card noob = decky.deal();
            hand.Add(noob);
            return noob;
        }

        //Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
        public Card discard(int idx)
        {
            if(idx < 0 || idx > hand.Count){
                System.Console.WriteLine("yo learn to count!");
                return null;
            } else {
                //remove
                Card res = hand[idx];
                hand.RemoveAt(idx);
                return res;
            }
        }
    }
}