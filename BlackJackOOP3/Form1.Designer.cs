﻿namespace BlackJackOOP3
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
            button1 = new Button();
            drawCardButton = new Button();
            drawnCard = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(421, 274);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
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
            drawnCard.Location = new Point(272, 152);
            drawnCard.Name = "drawnCard";
            drawnCard.Size = new Size(50, 20);
            drawnCard.TabIndex = 2;
            drawnCard.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(drawnCard);
            Controls.Add(drawCardButton);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button drawCardButton;
        private Label drawnCard;
    }
}
