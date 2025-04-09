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
            playerEenDealUp = new Button();
            playerTweeDealUp = new Button();
            playerDrieDealUp = new Button();
            playerVierDealUp = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // drawCardButton
            // 
            drawCardButton.Location = new Point(285, 346);
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
            drawnCard.Location = new Point(356, 310);
            drawnCard.Name = "drawnCard";
            drawnCard.Size = new Size(50, 20);
            drawnCard.TabIndex = 2;
            drawnCard.Text = "label1";
            drawnCard.Click += drawnCard_Click;
            // 
            // button1
            // 
            button1.Location = new Point(385, 346);
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
            label1.Location = new Point(66, 102);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 4;
            label1.Text = "speler 1";
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
            label2.Location = new Point(253, 102);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 10;
            label2.Text = "speler 2";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 102);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 11;
            label3.Text = "speler 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 102);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "speler 4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(playerVierDealUp);
            Controls.Add(playerDrieDealUp);
            Controls.Add(playerTweeDealUp);
            Controls.Add(playerEenDealUp);
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
        private Button playerEenDealUp;
        private Button playerTweeDealUp;
        private Button playerDrieDealUp;
        private Button playerVierDealUp;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
