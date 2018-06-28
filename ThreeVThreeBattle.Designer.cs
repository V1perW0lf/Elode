namespace SHSU_ELO_Project
{
    partial class ThreeVThreeBattle
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
            this.backButton = new System.Windows.Forms.Button();
            this.team1Button = new System.Windows.Forms.Button();
            this.team2Button = new System.Windows.Forms.Button();
            this.whichTeamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 493);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 56);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // team1Button
            // 
            this.team1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Button.Location = new System.Drawing.Point(91, 202);
            this.team1Button.Name = "team1Button";
            this.team1Button.Size = new System.Drawing.Size(402, 86);
            this.team1Button.TabIndex = 8;
            this.team1Button.Text = "Team 1";
            this.team1Button.UseVisualStyleBackColor = true;
            this.team1Button.Click += new System.EventHandler(this.team1Button_Click);
            // 
            // team2Button
            // 
            this.team2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Button.Location = new System.Drawing.Point(91, 335);
            this.team2Button.Name = "team2Button";
            this.team2Button.Size = new System.Drawing.Size(402, 86);
            this.team2Button.TabIndex = 9;
            this.team2Button.Text = "Team 2";
            this.team2Button.UseVisualStyleBackColor = true;
            this.team2Button.Click += new System.EventHandler(this.team2Button_Click);
            // 
            // whichTeamLabel
            // 
            this.whichTeamLabel.AutoSize = true;
            this.whichTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whichTeamLabel.Location = new System.Drawing.Point(138, 101);
            this.whichTeamLabel.Name = "whichTeamLabel";
            this.whichTeamLabel.Size = new System.Drawing.Size(292, 39);
            this.whichTeamLabel.TabIndex = 10;
            this.whichTeamLabel.Text = "Which team won?";
            // 
            // ThreeVThreeBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.whichTeamLabel);
            this.Controls.Add(this.team2Button);
            this.Controls.Add(this.team1Button);
            this.Controls.Add(this.backButton);
            this.MaximizeBox = false;
            this.Name = "ThreeVThreeBattle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreeVThreeBattle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThreeVThreeBattle_FormClosed);
            this.Load += new System.EventHandler(this.ThreeVThreeBattle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button team1Button;
        private System.Windows.Forms.Button team2Button;
        private System.Windows.Forms.Label whichTeamLabel;
    }
}