using BlackJackOOP3.classes;

namespace BlackJackOOP3
{
    public partial class Form1 : Form
    {

        Deck deck = new Deck();
        public Form1()
        {
            InitializeComponent();
        }

        private void drawCardButton_Click(object sender, EventArgs e)
        {
            Card card = deck.Drawcard();
            drawnCard.Text = card.ToString();
        }

        private void drawnCard_Click(object sender, EventArgs e)
        {

        }
    }
}
