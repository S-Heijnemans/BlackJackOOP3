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

        public void DealCardDown()
        {
            // the dealer should be able to give a card to a hand and remove that card from the deck
        }

        public void Payout()
        {
            // lets the dealer give the players the money they earned if they won
        }

        public int WinPoint()
        {
            // the dealer earns a point for performing the correct move
            return points +1;
        }

        public int LosePoint()
        {
            // the dealer loses a point for performing the wrong move
            return points -1;
        }

        public void CheckBlackjack()
        {
            // the dealer checks if there is a blackjack and performs the corresponding action
        }

        public void ShuffleDeck()
        {
            // shuffles the deck of cards without douplecating those cards
        }
    }
}
