namespace SHSU_ELO_Project
{
    partial class OneVOneBattle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.whichPlayerLabel = new System.Windows.Forms.Label();
            this.player1Button = new System.Windows.Forms.Button();
            this.player2Button = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // whichPlayerLabel
            // 
            this.whichPlayerLabel.AutoSize = true;
            this.whichPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichPlayerLabel.Location = new System.Drawing.Point(138, 101);
            this.whichPlayerLabel.Name = "whichPlayerLabel";
            this.whichPlayerLabel.Size = new System.Drawing.Size(309, 39);
            this.whichPlayerLabel.TabIndex = 0;
            this.whichPlayerLabel.Text = "Which player won?";
            // 
            // player1Button
            // 
            this.player1Button.Location = new System.Drawing.Point(91, 202);
            this.player1Button.Name = "player1Button";
            this.player1Button.Size = new System.Drawing.Size(402, 86);
            this.player1Button.TabIndex = 1;
            this.player1Button.Text = "Player1";
            this.player1Button.UseVisualStyleBackColor = true;
            this.player1Button.Click += new System.EventHandler(this.player1Button_Click);
            // 
            // player2Button
            // 
            this.player2Button.Location = new System.Drawing.Point(91, 335);
            this.player2Button.Name = "player2Button";
            this.player2Button.Size = new System.Drawing.Size(402, 86);
            this.player2Button.TabIndex = 2;
            this.player2Button.Text = "Player2";
            this.player2Button.UseVisualStyleBackColor = true;
            this.player2Button.Click += new System.EventHandler(this.player2Button_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 493);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 56);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OneVOneBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.player2Button);
            this.Controls.Add(this.player1Button);
            this.Controls.Add(this.whichPlayerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "OneVOneBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneVOneBattle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OneVOneBattle_FormClosed);
            this.Load += new System.EventHandler(this.OneVOneBattle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whichPlayerLabel;
        private System.Windows.Forms.Button player1Button;
        private System.Windows.Forms.Button player2Button;
        private System.Windows.Forms.Button backButton;
    }
}