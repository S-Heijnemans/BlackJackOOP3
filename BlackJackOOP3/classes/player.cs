using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOOP3.classes
{
    class Player
    {


        String Name;
        List<Hand> Hands;
        int Balance;
        int Chips;
        int StartChips;

        public void PlaceBet()
        {
            //the player places a bet to a hand
        }

        public void GetWinst()
        {
            // takes the StartChips and Chips and calculates how many chips you won/lost
        }

        public void GetChips()
        {
            //takes and shows the amount of chips the player has at the moment
        }
    }
}
