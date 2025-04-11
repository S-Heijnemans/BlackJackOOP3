using System.Security.Cryptography.X509Certificates;
using BlackJackOOP3.classes;

namespace BlackJackOOP3
{
    public partial class Form1 : Form
    {

        Deck deck;
        Dealer dealer;
        Hand handP1;
        Hand handP2;
        Hand handP3;
        Hand handP4;
        Player playerEen = new Player();
        Player playerTwee = new Player();
        Player playerDrie = new Player();
        Player playerVier = new Player();

        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            dealer = new Dealer();
        }

        private void drawCardButton_Click(object sender, EventArgs e)
        {
            Card card = deck.Drawcard();
            if ( card == null)
            {
                deck.ResetDeck();
                card = deck.Drawcard();
            }
            drawnCard.Text = card.ToString();
        }

        private void drawnCard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dealer.Shuffle(deck);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Card DealCard = dealer.DealCardFaceUp(deck, handP1);

            //this goes to the player and gives the card value "DealCard" and the location of this button "((Button)sneder).Location"
            this.Controls.Add(playerEen.CreateCardLabel(DealCard, ((Button)sender).Location));

            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void playerTweeDealUp_Click(object sender, EventArgs e)
        {
            Card DealCard = dealer.DealCardFaceUp(deck, handP2);

            //this goes to the player and gives the card value "DealCard" and the location of this button "((Button)sneder).Location"
            this.Controls.Add(playerTwee.CreateCardLabel(DealCard, ((Button)sender).Location));
        }

        private void playerTweeCard_Click(object sender, EventArgs e)
        {

        }

        private void playerDrieCard_Click(object sender, EventArgs e)
        {

        }

        private void playerDrieDealUp_Click(object sender, EventArgs e)
        {
            Card DealCard = dealer.DealCardFaceUp(deck, handP3);

            //this goes to the player and gives the card value "DealCard" and the location of this button "((Button)sneder).Location"
            this.Controls.Add(playerDrie.CreateCardLabel(DealCard, ((Button)sender).Location));
        }

        private void PlayerVierCard_Click(object sender, EventArgs e)
        {

        }

        private void playerVierDealUp_Click(object sender, EventArgs e)
        {
            Card DealCard = dealer.DealCardFaceUp(deck, handP4);

            //this goes to the player and gives the card value "DealCard" and the location of this button "((Button)sneder).Location"
            this.Controls.Add(playerVier.CreateCardLabel(DealCard, ((Button)sender).Location));
        }
    }
}
