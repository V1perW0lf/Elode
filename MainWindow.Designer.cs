namespace SHSU_ELO_Project
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this._1v1Button = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this._5v5Button = new System.Windows.Forms.Button();
            this._3v3Button = new System.Windows.Forms.Button();
            this.mainText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _1v1Button
            // 
            this._1v1Button.Location = new System.Drawing.Point(12, 12);
            this._1v1Button.Name = "_1v1Button";
            this._1v1Button.Size = new System.Drawing.Size(143, 56);
            this._1v1Button.TabIndex = 0;
            this._1v1Button.Text = "1v1 Battle and\r\nAdd Players\r\n";
            this._1v1Button.UseVisualStyleBackColor = true;
            this._1v1Button.Click += new System.EventHandler(this._1v1Button_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.Location = new System.Drawing.Point(12, 493);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(143, 56);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // _5v5Button
            // 
            this._5v5Button.Location = new System.Drawing.Point(429, 12);
            this._5v5Button.Name = "_5v5Button";
            this._5v5Button.Size = new System.Drawing.Size(143, 56);
            this._5v5Button.TabIndex = 3;
            this._5v5Button.Text = "5v5 Battle";
            this._5v5Button.UseVisualStyleBackColor = true;
            this._5v5Button.Click += new System.EventHandler(this._5v5Button_Click);
            // 
            // _3v3Button
            // 
            this._3v3Button.Location = new System.Drawing.Point(221, 12);
            this._3v3Button.Name = "_3v3Button";
            this._3v3Button.Size = new System.Drawing.Size(143, 56);
            this._3v3Button.TabIndex = 1;
            this._3v3Button.Text = "3v3 Battle";
            this._3v3Button.UseVisualStyleBackColor = true;
            this._3v3Button.Click += new System.EventHandler(this._3v3Button_Click);
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.Location = new System.Drawing.Point(12, 168);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(551, 248);
            this.mainText.TabIndex = 11;
            this.mainText.Text = resources.GetString("mainText.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this._3v3Button);
            this.Controls.Add(this._5v5Button);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this._1v1Button);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _1v1Button;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button _5v5Button;
        private System.Windows.Forms.Button _3v3Button;
        private System.Windows.Forms.Label mainText;
    }
}