namespace SHSU_ELO_Project
{
    partial class OneVOneResults
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
            this.okButton = new System.Windows.Forms.Button();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.p1OldElo = new System.Windows.Forms.Label();
            this.p1NewElo = new System.Windows.Forms.Label();
            this.p2OldElo = new System.Windows.Forms.Label();
            this.p2NewElo = new System.Windows.Forms.Label();
            this.p1OldLabel = new System.Windows.Forms.Label();
            this.p1NewLabel = new System.Windows.Forms.Label();
            this.p2OldLabel = new System.Windows.Forms.Label();
            this.p2NewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(242, 474);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 75);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(66, 118);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(77, 24);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Player 1";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(66, 304);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(77, 24);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "Player 2";
            // 
            // p1OldElo
            // 
            this.p1OldElo.AutoSize = true;
            this.p1OldElo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1OldElo.Location = new System.Drawing.Point(373, 73);
            this.p1OldElo.Name = "p1OldElo";
            this.p1OldElo.Size = new System.Drawing.Size(60, 24);
            this.p1OldElo.TabIndex = 4;
            this.p1OldElo.Text = "label3";
            // 
            // p1NewElo
            // 
            this.p1NewElo.AutoSize = true;
            this.p1NewElo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1NewElo.Location = new System.Drawing.Point(373, 162);
            this.p1NewElo.Name = "p1NewElo";
            this.p1NewElo.Size = new System.Drawing.Size(60, 24);
            this.p1NewElo.TabIndex = 5;
            this.p1NewElo.Text = "label4";
            // 
            // p2OldElo
            // 
            this.p2OldElo.AutoSize = true;
            this.p2OldElo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2OldElo.Location = new System.Drawing.Point(373, 271);
            this.p2OldElo.Name = "p2OldElo";
            this.p2OldElo.Size = new System.Drawing.Size(60, 24);
            this.p2OldElo.TabIndex = 6;
            this.p2OldElo.Text = "label5";
            // 
            // p2NewElo
            // 
            this.p2NewElo.AutoSize = true;
            this.p2NewElo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2NewElo.Location = new System.Drawing.Point(373, 360);
            this.p2NewElo.Name = "p2NewElo";
            this.p2NewElo.Size = new System.Drawing.Size(60, 24);
            this.p2NewElo.TabIndex = 7;
            this.p2NewElo.Text = "label6";
            // 
            // p1OldLabel
            // 
            this.p1OldLabel.AutoSize = true;
            this.p1OldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1OldLabel.Location = new System.Drawing.Point(278, 73);
            this.p1OldLabel.Name = "p1OldLabel";
            this.p1OldLabel.Size = new System.Drawing.Size(64, 20);
            this.p1OldLabel.TabIndex = 8;
            this.p1OldLabel.Text = "Old Elo:";
            // 
            // p1NewLabel
            // 
            this.p1NewLabel.AutoSize = true;
            this.p1NewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1NewLabel.Location = new System.Drawing.Point(278, 162);
            this.p1NewLabel.Name = "p1NewLabel";
            this.p1NewLabel.Size = new System.Drawing.Size(71, 20);
            this.p1NewLabel.TabIndex = 9;
            this.p1NewLabel.Text = "New Elo:";
            // 
            // p2OldLabel
            // 
            this.p2OldLabel.AutoSize = true;
            this.p2OldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2OldLabel.Location = new System.Drawing.Point(278, 271);
            this.p2OldLabel.Name = "p2OldLabel";
            this.p2OldLabel.Size = new System.Drawing.Size(64, 20);
            this.p2OldLabel.TabIndex = 10;
            this.p2OldLabel.Text = "Old Elo:";
            // 
            // p2NewLabel
            // 
            this.p2NewLabel.AutoSize = true;
            this.p2NewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2NewLabel.Location = new System.Drawing.Point(278, 360);
            this.p2NewLabel.Name = "p2NewLabel";
            this.p2NewLabel.Size = new System.Drawing.Size(71, 20);
            this.p2NewLabel.TabIndex = 11;
            this.p2NewLabel.Text = "New Elo:";
            // 
            // OneVOneResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.p2NewLabel);
            this.Controls.Add(this.p2OldLabel);
            this.Controls.Add(this.p1NewLabel);
            this.Controls.Add(this.p1OldLabel);
            this.Controls.Add(this.p2NewElo);
            this.Controls.Add(this.p2OldElo);
            this.Controls.Add(this.p1NewElo);
            this.Controls.Add(this.p1OldElo);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.Name = "OneVOneResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneVOneResults";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OneVOneResults_FormClosed);
            this.Load += new System.EventHandler(this.OneVOneResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label p1OldElo;
        private System.Windows.Forms.Label p1NewElo;
        private System.Windows.Forms.Label p2OldElo;
        private System.Windows.Forms.Label p2NewElo;
        private System.Windows.Forms.Label p1OldLabel;
        private System.Windows.Forms.Label p1NewLabel;
        private System.Windows.Forms.Label p2OldLabel;
        private System.Windows.Forms.Label p2NewLabel;
    }
}