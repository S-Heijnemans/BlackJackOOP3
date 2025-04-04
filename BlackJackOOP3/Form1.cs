using BlackJackOOP3.classes;

namespace BlackJackOOP3
{
    public partial class Form1 : Form
    {

        Deck deck;
        Dealer dealer;
        Player playerEen;
        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            dealer = new Dealer();
        }

        private void drawCardButton_Click(object sender, EventArgs e)
        {
            Card card = deck.Drawcard();
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
            this.dealer.DealCardFaceUp(this.deck, this.playerEen.Hands[0]);
        }
    }
}
