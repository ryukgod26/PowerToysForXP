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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.homeSPanel = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sidebar.Controls.Add(this.homebtn);
            this.sidebar.Controls.Add(this.homeSPanel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 450);
            this.sidebar.TabIndex = 0;
            // 
            // homeSPanel
            // 
            this.homeSPanel.Location = new System.Drawing.Point(3, 45);
            this.homeSPanel.Name = "homeSPanel";
            this.homeSPanel.Size = new System.Drawing.Size(150, 43);
            this.homeSPanel.TabIndex = 1;
            this.homeSPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homeSPanel_Paint);
            // 
            // homebtn
            // 
            this.homebtn.Location = new System.Drawing.Point(3, 3);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(150, 36);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Power Toys For XP";
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel homeSPanel;
        private System.Windows.Forms.Button homebtn;
    }
}