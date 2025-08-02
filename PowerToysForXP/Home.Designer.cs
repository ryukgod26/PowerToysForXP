namespace PowerToysForXP
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.advPastelbl = new System.Windows.Forms.Label();
            this.advPaste = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(779, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 450);
            this.vScrollBar1.TabIndex = 2;
            // 
            // advPastelbl
            // 
            this.advPastelbl.AccessibleName = "Advance Paste";
            this.advPastelbl.AutoSize = true;
            this.advPastelbl.Location = new System.Drawing.Point(187, 103);
            this.advPastelbl.Name = "advPastelbl";
            this.advPastelbl.Size = new System.Drawing.Size(99, 16);
            this.advPastelbl.TabIndex = 5;
            this.advPastelbl.Text = "Advance Paste";
            // 
            // advPaste
            // 
            this.advPaste.AccessibleName = "Advance Paste";
            this.advPaste.AutoSize = true;
            this.advPaste.Location = new System.Drawing.Point(395, 98);
            this.advPaste.Name = "advPaste";
            this.advPaste.Size = new System.Drawing.Size(45, 20);
            this.advPaste.TabIndex = 1;
            this.advPaste.Text = "Off";
            this.advPaste.UseVisualStyleBackColor = false;
            this.advPaste.UseWaitCursor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(779, 450);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.advPaste);
            this.Controls.Add(this.advPastelbl);
            this.Controls.Add(this.vScrollBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Power Toys For XP";
            this.Load += new System.EventHandler(this.Home_Load);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label advPastelbl;
        private System.Windows.Forms.CheckBox advPaste;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}