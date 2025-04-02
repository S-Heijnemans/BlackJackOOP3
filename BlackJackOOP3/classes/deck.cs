using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOOP3.classes
{
    class Deck
    {
       public List<Card> Cards = new List<Card>();

        public Deck()
        {
            int index = 1;

            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach(Facevalue facevalue in Enum.GetValues(typeof(Facevalue)))
                {
                    Cards.Add(new Card(suit, facevalue));
                }
            }
        }

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
