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
        public List<Hand> Hands;
        int Balance;
        int Chips;
        int StartChips;


        int LastYvalue = 25;

        /**
         * this is where it creates a label with the text from the drawn card
         * it asks for a card to add the card
         * and it asks for Point location to be able to obtain the X and Y value to set the location
         */
        public Label CreateCardLabel(Card card, Point location)
        {
            Label PlayerCardLabel = new Label();
            PlayerCardLabel.Text = card.ToString();

            //hardcode the Width and Height of the size of the lable  
            PlayerCardLabel.Width = 160;
            PlayerCardLabel.Height = 22;

            PlayerCardLabel.Location = new Point(location.X, location.Y + LastYvalue);

            LastYvalue += 25;

            return PlayerCardLabel;
            //PlayerCardLabel.Location(location1, location2);

        }
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
