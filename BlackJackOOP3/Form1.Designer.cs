namespace BlackJackOOP3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            drawCardButton = new Button();
            drawnCard = new Label();
            button1 = new Button();
            label1 = new Label();
            PlayerCard = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // drawCardButton
            // 
            drawCardButton.Location = new Point(625, 226);
            drawCardButton.Name = "drawCardButton";
            drawCardButton.Size = new Size(94, 55);
            drawCardButton.TabIndex = 1;
            drawCardButton.Text = "card Deck";
            drawCardButton.UseVisualStyleBackColor = true;
            drawCardButton.Click += drawCardButton_Click;
            // 
            // drawnCard
            // 
            drawnCard.AutoSize = true;
            drawnCard.Location = new Point(483, 243);
            drawnCard.Name = "drawnCard";
            drawnCard.Size = new Size(50, 20);
            drawnCard.TabIndex = 2;
            drawnCard.Text = "label1";
            drawnCard.Click += drawnCard_Click;
            // 
            // button1
            // 
            button1.Location = new Point(625, 287);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 3;
            button1.Text = "shuffle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 52);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 4;
            label1.Text = "speler 1";
            // 
            // PlayerCard
            // 
            PlayerCard.AutoSize = true;
            PlayerCard.Location = new Point(51, 82);
            PlayerCard.Name = "PlayerCard";
            PlayerCard.Size = new Size(96, 20);
            PlayerCard.TabIndex = 5;
            PlayerCard.Text = "Card speler 1";
            PlayerCard.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(355, 347);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 6;
            button2.Text = "deal card up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(button2);
            Controls.Add(PlayerCard);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(drawnCard);
            Controls.Add(drawCardButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button drawCardButton;
        private Label drawnCard;
        private Button button1;
        private Label label1;
        private Label PlayerCard;
        private Button button2;
    }
}
