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

            //for (int currentIndex = 0; currentIndex < deck.Cards.Count; currentIndex++)
            //{
            //    int swapIndex = currentIndex + rng.Next(deck.Cards.Count - currentIndex);
            //    (deck.Cards[swapIndex], deck.Cards[currentIndex]) = (deck.Cards[currentIndex], deck.Cards[swapIndex]);
            //}

        }
    }
}
