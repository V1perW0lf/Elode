﻿namespace SHSU_ELO_Project
{
    partial class Add5v5Team
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
            this.coachNameBox = new System.Windows.Forms.TextBox();
            this.coachNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameBox = new System.Windows.Forms.TextBox();
            this.addingLabel = new System.Windows.Forms.Label();
            this.playerListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // coachNameBox
            // 
            this.coachNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachNameBox.Location = new System.Drawing.Point(245, 98);
            this.coachNameBox.Name = "coachNameBox";
            this.coachNameBox.Size = new System.Drawing.Size(275, 38);
            this.coachNameBox.TabIndex = 1;
            this.coachNameBox.Tag = "";
            // 
            // coachNameLabel
            // 
            this.coachNameLabel.AutoSize = true;
            this.coachNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachNameLabel.Location = new System.Drawing.Point(65, 98);
            this.coachNameLabel.Name = "coachNameLabel";
            this.coachNameLabel.Size = new System.Drawing.Size(133, 25);
            this.coachNameLabel.TabIndex = 11;
            this.coachNameLabel.Text = "Coach Name:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(429, 493);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 56);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(12, 493);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 56);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(286, 465);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 19;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(65, 38);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(126, 25);
            this.teamNameLabel.TabIndex = 20;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // teamNameBox
            // 
            this.teamNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameBox.Location = new System.Drawing.Point(245, 38);
            this.teamNameBox.Name = "teamNameBox";
            this.teamNameBox.Size = new System.Drawing.Size(275, 38);
            this.teamNameBox.TabIndex = 0;
            this.teamNameBox.Tag = "";
            // 
            // addingLabel
            // 
            this.addingLabel.AutoSize = true;
            this.addingLabel.Location = new System.Drawing.Point(268, 433);
            this.addingLabel.Name = "addingLabel";
            this.addingLabel.Size = new System.Drawing.Size(0, 13);
            this.addingLabel.TabIndex = 21;
            // 
            // playerListBox
            // 
            this.playerListBox.CheckOnClick = true;
            this.playerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(116, 104);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerListBox.Size = new System.Drawing.Size(350, 342);
            this.playerListBox.TabIndex = 22;
            this.playerListBox.TabStop = false;
            // 
            // Add5v5Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.addingLabel);
            this.Controls.Add(this.teamNameBox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.coachNameLabel);
            this.Controls.Add(this.coachNameBox);
            this.MaximizeBox = false;
            this.Name = "Add5v5Team";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTeam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add5V5Team_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox coachNameBox;
        private System.Windows.Forms.Label coachNameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameBox;
        private System.Windows.Forms.Label addingLabel;
        private System.Windows.Forms.CheckedListBox playerListBox;
    }
}