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
            PlayerEenCard = new Label();
            playerEenDealUp = new Button();
            playerTweeDealUp = new Button();
            playerDrieDealUp = new Button();
            playerVierDealUp = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            playerTweeCard = new Label();
            playerDrieCard = new Label();
            playerVierCard = new Label();
            SuspendLayout();
            // 
            // drawCardButton
            // 
            drawCardButton.Location = new Point(273, 238);
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
            drawnCard.Location = new Point(345, 215);
            drawnCard.Name = "drawnCard";
            drawnCard.Size = new Size(50, 20);
            drawnCard.TabIndex = 2;
            drawnCard.Text = "label1";
            drawnCard.Click += drawnCard_Click;
            // 
            // button1
            // 
            button1.Location = new Point(373, 238);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
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
            // PlayerEenCard
            // 
            PlayerEenCard.AutoSize = true;
            PlayerEenCard.Location = new Point(51, 82);
            PlayerEenCard.Name = "PlayerEenCard";
            PlayerEenCard.Size = new Size(96, 20);
            PlayerEenCard.TabIndex = 5;
            PlayerEenCard.Text = "Card speler 1";
            PlayerEenCard.Click += label2_Click;
            // 
            // playerEenDealUp
            // 
            playerEenDealUp.Location = new Point(41, 125);
            playerEenDealUp.Name = "playerEenDealUp";
            playerEenDealUp.Size = new Size(119, 29);
            playerEenDealUp.TabIndex = 6;
            playerEenDealUp.Text = "deal card up";
            playerEenDealUp.UseVisualStyleBackColor = true;
            playerEenDealUp.Click += button2_Click;
            // 
            // playerTweeDealUp
            // 
            playerTweeDealUp.Location = new Point(228, 125);
            playerTweeDealUp.Name = "playerTweeDealUp";
            playerTweeDealUp.Size = new Size(119, 29);
            playerTweeDealUp.TabIndex = 7;
            playerTweeDealUp.Text = "deal card up";
            playerTweeDealUp.UseVisualStyleBackColor = true;
            playerTweeDealUp.Click += playerTweeDealUp_Click;
            // 
            // playerDrieDealUp
            // 
            playerDrieDealUp.Location = new Point(427, 125);
            playerDrieDealUp.Name = "playerDrieDealUp";
            playerDrieDealUp.Size = new Size(119, 29);
            playerDrieDealUp.TabIndex = 8;
            playerDrieDealUp.Text = "deal card up";
            playerDrieDealUp.UseVisualStyleBackColor = true;
            playerDrieDealUp.Click += playerDrieDealUp_Click;
            // 
            // playerVierDealUp
            // 
            playerVierDealUp.Location = new Point(612, 125);
            playerVierDealUp.Name = "playerVierDealUp";
            playerVierDealUp.Size = new Size(119, 29);
            playerVierDealUp.TabIndex = 9;
            playerVierDealUp.Text = "deal card up";
            playerVierDealUp.UseVisualStyleBackColor = true;
            playerVierDealUp.Click += playerVierDealUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 52);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 10;
            label2.Text = "speler 2";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 52);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 11;
            label3.Text = "speler 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 52);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "speler 4";
            // 
            // playerTweeCard
            // 
            playerTweeCard.AutoSize = true;
            playerTweeCard.Location = new Point(238, 82);
            playerTweeCard.Name = "playerTweeCard";
            playerTweeCard.Size = new Size(94, 20);
            playerTweeCard.TabIndex = 13;
            playerTweeCard.Text = "card speler 2";
            playerTweeCard.Click += playerTweeCard_Click;
            // 
            // playerDrieCard
            // 
            playerDrieCard.AutoSize = true;
            playerDrieCard.Location = new Point(442, 82);
            playerDrieCard.Name = "playerDrieCard";
            playerDrieCard.Size = new Size(94, 20);
            playerDrieCard.TabIndex = 14;
            playerDrieCard.Text = "card speler 3";
            playerDrieCard.Click += playerDrieCard_Click;
            // 
            // playerVierCard
            // 
            playerVierCard.AutoSize = true;
            playerVierCard.Location = new Point(623, 82);
            playerVierCard.Name = "playerVierCard";
            playerVierCard.Size = new Size(94, 20);
            playerVierCard.TabIndex = 15;
            playerVierCard.Text = "card speler 4";
            playerVierCard.Click += PlayerVierCard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(playerVierCard);
            Controls.Add(playerDrieCard);
            Controls.Add(playerTweeCard);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(playerVierDealUp);
            Controls.Add(playerDrieDealUp);
            Controls.Add(playerTweeDealUp);
            Controls.Add(playerEenDealUp);
            Controls.Add(PlayerEenCard);
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
        private Label PlayerEenCard;
        private Button playerEenDealUp;
        private Button playerTweeDealUp;
        private Button playerDrieDealUp;
        private Button playerVierDealUp;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label playerTweeCard;
        private Label playerDrieCard;
        private Label playerVierCard;
    }
}
