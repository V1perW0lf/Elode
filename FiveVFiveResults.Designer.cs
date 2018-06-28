namespace SHSU_ELO_Project
{
    partial class FiveVFiveResults
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
            this.t1ChangeLabel = new System.Windows.Forms.Label();
            this.t2ChangeLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1ChangeLabel
            // 
            this.t1ChangeLabel.AutoSize = true;
            this.t1ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1ChangeLabel.Location = new System.Drawing.Point(257, 154);
            this.t1ChangeLabel.Name = "t1ChangeLabel";
            this.t1ChangeLabel.Size = new System.Drawing.Size(86, 31);
            this.t1ChangeLabel.TabIndex = 0;
            this.t1ChangeLabel.Text = "label1";
            // 
            // t2ChangeLabel
            // 
            this.t2ChangeLabel.AutoSize = true;
            this.t2ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2ChangeLabel.Location = new System.Drawing.Point(257, 354);
            this.t2ChangeLabel.Name = "t2ChangeLabel";
            this.t2ChangeLabel.Size = new System.Drawing.Size(86, 31);
            this.t2ChangeLabel.TabIndex = 1;
            this.t2ChangeLabel.Text = "label2";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 493);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 56);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FiveVFiveResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.t2ChangeLabel);
            this.Controls.Add(this.t1ChangeLabel);
            this.MaximizeBox = false;
            this.Name = "FiveVFiveResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FiveVFiveResults";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FiveVFiveResults_FormClosed);
            this.Load += new System.EventHandler(this.FiveVFiveResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label t1ChangeLabel;
        private System.Windows.Forms.Label t2ChangeLabel;
        private System.Windows.Forms.Button backButton;
    }
}