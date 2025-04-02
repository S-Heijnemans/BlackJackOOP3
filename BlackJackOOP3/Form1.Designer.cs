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
            SuspendLayout();
            // 
            // drawCardButton
            // 
            drawCardButton.Location = new Point(493, 130);
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
            drawnCard.Location = new Point(357, 147);
            drawnCard.Name = "drawnCard";
            drawnCard.Size = new Size(50, 20);
            drawnCard.TabIndex = 2;
            drawnCard.Text = "label1";
            drawnCard.Click += drawnCard_Click;
            // 
            // button1
            // 
            button1.Location = new Point(493, 202);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 3;
            button1.Text = "shuffle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
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
    }
}
