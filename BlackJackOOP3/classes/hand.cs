using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOOP3.classes
{
    class Hand
    {
        List<Card> cards;
        Bet bet;

        public void Hit()
        {
            //the hand will get one more card added to the cards 
        }

        public void Stand()
        {
            //the hand will not recive a card and will end its turn
        }

        public void Split(Bet splitBet)
        {
            //the hand will only be able to perform this action if it has 2 cards of the same rang
            //it will then check if the player had enough chips to place the same bet for the second hand
            //if these are true the hand will be split into 2 nieuws hands
        }

        public void DoubleDown(Bet DoubleDownBet)
        {
            //the hand will only be able to perform this action if the player has enough chips to double the Bet
            //if the player has enough chips the Bet will be doubled and 1 more card will be given this will end the turn 
        }
    }

}
