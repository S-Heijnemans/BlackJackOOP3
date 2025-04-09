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
       public List<Card> Cards = new List<Card>();

        /**
         * this generates a deck using the suit and facevalue of Card 
         * to go true all of the options and generates all unique 52 cards needed in a deck
         */
        public Deck()
        {
            ResetDeck();
        }

        public void ResetDeck()
        {
            int index = 1;

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Facevalue facevalue in Enum.GetValues(typeof(Facevalue)))
                {
                    Cards.Add(new Card(suit, facevalue));
                }
            }
        }

        /**
         * this deals or takes the top card of the deck and also removes this card from the list of cards in the deck
         * if the deck has no cards left it will return null and not give a card
         */
        public Card? Drawcard()
        {
            if(Cards.Count <= 0)
            {
                return null;
            }
            Card drawnCard = Cards[0];
            Cards.RemoveAt(0);
            return drawnCard;
        }
    }


}
