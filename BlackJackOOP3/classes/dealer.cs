using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOOP3.classes
{
    class Dealer
    {
        string name;
        Hand hand;
        int points;

        /**
         * this randomizes the deck of cards 
         * it takes the total count of cards works from back to front en changes the value of the
         * cards to a other position in the deck
         */
        public void Shuffle(Deck deck)
        {
            Random rng = new Random();
            int n = deck.Cards.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var temp = deck.Cards[k];
                deck.Cards[k] = deck.Cards[n];
                deck.Cards[n] = temp;
            }
        }

        public Card TakeCard(Deck deck)
        {
            var TakenCard = deck.Drawcard();
            return TakenCard;
        }

        public Card DealCardFaceUp(Deck deck, Hand hand)
        {
            Card DealCard = TakeCard(deck);
            //if (DealCard != null)
            //{
            //    hand?.cards.Add(DealCard);
            //    return DealCard;
            //}
            hand?.cards.Add(DealCard);
            return DealCard;


        }

        /**
         * this removes a point from the dealers game points
         */
        public void RemovePoint()
        {
            points--;
        }

        /**
         * this adds a point to the dealers game points
         */
        public void AddPoint()
        {
            points++;
        }
    }
}
