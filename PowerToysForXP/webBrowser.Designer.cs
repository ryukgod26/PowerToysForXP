namespace PowerToysForXP
{
    partial class webBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.navigatebtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 394);
            this.webBrowser1.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(0, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(145, 38);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // navigatebtn
            // 
            this.navigatebtn.Location = new System.Drawing.Point(167, 12);
            this.navigatebtn.Name = "navigatebtn";
            this.navigatebtn.Size = new System.Drawing.Size(145, 38);
            this.navigatebtn.TabIndex = 2;
            this.navigatebtn.Text = "Navigate";
            this.navigatebtn.UseVisualStyleBackColor = true;
            this.navigatebtn.Click += new System.EventHandler(this.navigatebtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(368, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(145, 38);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(570, 12);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(145, 38);
            this.forwardBtn.TabIndex = 4;
            this.forwardBtn.Text = "Forward";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(284, 56);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(100, 22);
            this.url.TabIndex = 5;
            // 
            // webBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.url);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.navigatebtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.webBrowser1);
            this.Name = "webBrowser";
            this.Text = "webBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button navigatebtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.TextBox url;
    }
}