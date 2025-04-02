using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOOP3.classes
{
    class Deck
    {
        List<Card> cards = new List<Card>();

        Card[] GameCards = new Card[52];

        public Deck()
        {
            int index = 1;

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach(Facevalue facevalue in Enum.GetValues(typeof(Facevalue)))
                {
                    cards.Add(new Card(suit, facevalue));
                }
            }
        }

        public Card Drawcard()
        {
            if(cards.Count <= 0)
            {
                return null;
            }
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public void Shuffle()
        {
            
        }
    }


}
