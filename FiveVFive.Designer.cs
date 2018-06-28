namespace SHSU_ELO_Project
{
    partial class FiveVFive
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
            this.teamListBox = new System.Windows.Forms.CheckedListBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.battleTeamButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.viewTeamButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamListBox
            // 
            this.teamListBox.CheckOnClick = true;
            this.teamListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(117, 109);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(350, 342);
            this.teamListBox.TabIndex = 1;
            this.teamListBox.TabStop = false;
            this.teamListBox.SelectedIndexChanged += new System.EventHandler(this.teamListBox__SelectedIndexChanged);
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(429, 12);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(143, 56);
            this.addTeamButton.TabIndex = 1;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // battleTeamButton
            // 
            this.battleTeamButton.Location = new System.Drawing.Point(429, 493);
            this.battleTeamButton.Name = "battleTeamButton";
            this.battleTeamButton.Size = new System.Drawing.Size(143, 56);
            this.battleTeamButton.TabIndex = 2;
            this.battleTeamButton.Text = "Battle!";
            this.battleTeamButton.UseVisualStyleBackColor = true;
            this.battleTeamButton.Click += new System.EventHandler(this.battleTeamButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 493);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 56);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // viewTeamButton
            // 
            this.viewTeamButton.Location = new System.Drawing.Point(12, 12);
            this.viewTeamButton.Name = "viewTeamButton";
            this.viewTeamButton.Size = new System.Drawing.Size(143, 56);
            this.viewTeamButton.TabIndex = 0;
            this.viewTeamButton.Text = "View Team Elo";
            this.viewTeamButton.UseVisualStyleBackColor = true;
            this.viewTeamButton.Click += new System.EventHandler(this.viewTeamButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(218, 31);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 5;
            // 
            // FiveVFive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.viewTeamButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.battleTeamButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.teamListBox);
            this.MaximizeBox = false;
            this.Name = "FiveVFive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveVFive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FiveVFive_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox teamListBox;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button battleTeamButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button viewTeamButton;
        private System.Windows.Forms.Label errorLabel;
    }
}