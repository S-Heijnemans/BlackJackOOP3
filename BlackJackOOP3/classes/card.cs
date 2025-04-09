using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackOOP3.classes
{
    public enum Suits{
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES
    }

    public enum Facevalue { 
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }

    class Card {
        Suits suit;
        Facevalue facevalue;
        int value;
        Image img;
        
        public Suits Suit { 
            get { 
                return suit; 
            }
            set {
                suit = value;
            }
        }

        public Card(Suits suit, Facevalue facevalue) {
            this.suit = suit;
            this.facevalue = facevalue;
            switch (facevalue) {
                case Facevalue.ACE:
                    this.value = 11;
                    break;
                case Facevalue.TEN:
                case Facevalue.JACK:
                case Facevalue.QUEEN:
                case Facevalue.KING:
                    this.value = 10;
                    break;
                default:
                    this.value = (int)facevalue;
                    break;
            }
        }
       

    }
}
