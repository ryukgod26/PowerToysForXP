namespace PowerToysForXP
{
    partial class ColorInfo
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
            this.colorWatchPanel = new System.Windows.Forms.Panel();
            this.colorHexCode = new System.Windows.Forms.TextBox();
            this.colorName = new System.Windows.Forms.TextBox();
            this.colorRgbCode = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorWatchPanel
            // 
            this.colorWatchPanel.Location = new System.Drawing.Point(3, 56);
            this.colorWatchPanel.Name = "colorWatchPanel";
            this.colorWatchPanel.Size = new System.Drawing.Size(413, 100);
            this.colorWatchPanel.TabIndex = 0;
            // 
            // colorHexCode
            // 
            this.colorHexCode.Enabled = false;
            this.colorHexCode.Location = new System.Drawing.Point(191, 274);
            this.colorHexCode.Name = "colorHexCode";
            this.colorHexCode.Size = new System.Drawing.Size(159, 22);
            this.colorHexCode.TabIndex = 1;
            this.colorHexCode.Click += new System.EventHandler(this.colorHexCode_Click);
            // 
            // colorName
            // 
            this.colorName.Location = new System.Drawing.Point(191, 218);
            this.colorName.Name = "colorName";
            this.colorName.Size = new System.Drawing.Size(159, 22);
            this.colorName.TabIndex = 2;
            this.colorName.Click += new System.EventHandler(this.colorName_Click);
            this.colorName.TextChanged += new System.EventHandler(this.colorName_TextChanged);
            // 
            // colorRgbCode
            // 
            this.colorRgbCode.Enabled = false;
            this.colorRgbCode.Location = new System.Drawing.Point(191, 246);
            this.colorRgbCode.Name = "colorRgbCode";
            this.colorRgbCode.Size = new System.Drawing.Size(159, 22);
            this.colorRgbCode.TabIndex = 3;
            this.colorRgbCode.Click += new System.EventHandler(this.colorRgbCode_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(307, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(109, 38);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "click on the textbox to copy the value";
            // 
            // ColorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.colorRgbCode);
            this.Controls.Add(this.colorName);
            this.Controls.Add(this.colorHexCode);
            this.Controls.Add(this.colorWatchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorInfo";
            this.Text = "ColorInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorWatchPanel;
        private System.Windows.Forms.TextBox colorHexCode;
        private System.Windows.Forms.TextBox colorName;
        private System.Windows.Forms.TextBox colorRgbCode;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
    }
}