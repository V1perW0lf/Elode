namespace SHSU_ELO_Project
{
    partial class OneVOne
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
            this.playerListBox = new System.Windows.Forms.CheckedListBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.battleButton = new System.Windows.Forms.Button();
            this.viewPlayerButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerListBox
            // 
            this.playerListBox.CheckOnClick = true;
            this.playerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(117, 106);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerListBox.Size = new System.Drawing.Size(350, 342);
            this.playerListBox.TabIndex = 0;
            this.playerListBox.TabStop = false;
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.playerListBox__SelectedIndexChanged);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(429, 12);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(143, 56);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
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
            // battleButton
            // 
            this.battleButton.Location = new System.Drawing.Point(429, 493);
            this.battleButton.Name = "battleButton";
            this.battleButton.Size = new System.Drawing.Size(143, 56);
            this.battleButton.TabIndex = 3;
            this.battleButton.Text = "Battle!";
            this.battleButton.UseVisualStyleBackColor = true;
            this.battleButton.Click += new System.EventHandler(this.battleButton_Click);
            // 
            // viewPlayerButton
            // 
            this.viewPlayerButton.Enabled = false;
            this.viewPlayerButton.Location = new System.Drawing.Point(12, 12);
            this.viewPlayerButton.Name = "viewPlayerButton";
            this.viewPlayerButton.Size = new System.Drawing.Size(143, 56);
            this.viewPlayerButton.TabIndex = 0;
            this.viewPlayerButton.Text = "View Player Elo";
            this.viewPlayerButton.UseVisualStyleBackColor = true;
            this.viewPlayerButton.Click += new System.EventHandler(this.viewPlayerButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(292, 34);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 5;
            // 
            // OneVOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.viewPlayerButton);
            this.Controls.Add(this.battleButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addPlayerButton);
            this.Controls.Add(this.playerListBox);
            this.MaximizeBox = false;
            this.Name = "OneVOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneVOne";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OneVOne_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox playerListBox;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button battleButton;
        private System.Windows.Forms.Button viewPlayerButton;
        private System.Windows.Forms.Label errorLabel;
    }
}