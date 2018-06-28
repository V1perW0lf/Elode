namespace SHSU_ELO_Project
{
    partial class ViewPlayer
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
            this.playerUsernameLabel = new System.Windows.Forms.Label();
            this.eloLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerUsernameLabel
            // 
            this.playerUsernameLabel.AutoSize = true;
            this.playerUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerUsernameLabel.Location = new System.Drawing.Point(246, 217);
            this.playerUsernameLabel.Name = "playerUsernameLabel";
            this.playerUsernameLabel.Size = new System.Drawing.Size(0, 33);
            this.playerUsernameLabel.TabIndex = 0;
            // 
            // eloLabel
            // 
            this.eloLabel.AutoSize = true;
            this.eloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eloLabel.Location = new System.Drawing.Point(256, 262);
            this.eloLabel.Name = "eloLabel";
            this.eloLabel.Size = new System.Drawing.Size(0, 33);
            this.eloLabel.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 493);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 56);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ViewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.eloLabel);
            this.Controls.Add(this.playerUsernameLabel);
            this.MaximizeBox = false;
            this.Name = "ViewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewPlayer_FormClosed);
            this.Load += new System.EventHandler(this.viewPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerUsernameLabel;
        private System.Windows.Forms.Label eloLabel;
        private System.Windows.Forms.Button backButton;
    }
}