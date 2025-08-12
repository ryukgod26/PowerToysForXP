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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menulbl = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.settingbtn = new System.Windows.Forms.Button();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.browserbtn = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.browserPanelView = new System.Windows.Forms.Panel();
            this.url = new System.Windows.Forms.TextBox();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.navigatebtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.browserWindow = new System.Windows.Forms.WebBrowser();
            this.homePanelView = new System.Windows.Forms.Panel();
            this.tolbl = new System.Windows.Forms.Label();
            this.fromlbl = new System.Windows.Forms.Label();
            this.toKey = new System.Windows.Forms.ComboBox();
            this.fromKey = new System.Windows.Forms.ComboBox();
            this.keyboardKeyMapper = new System.Windows.Forms.CheckBox();
            this.colorpickerCheckBox = new System.Windows.Forms.CheckBox();
            this.homelbl = new System.Windows.Forms.Label();
            this.settingsPanelView = new System.Windows.Forms.Panel();
            this.settingslbl = new System.Windows.Forms.Label();
            this.darkModeCheckbox = new System.Windows.Forms.CheckBox();
            this.aboutPanelView = new System.Windows.Forms.Panel();
            this.aboutlbl = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarContainer.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.homePanel.SuspendLayout();
            this.aboutPanel.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.browserPanel.SuspendLayout();
            this.browserPanelView.SuspendLayout();
            this.homePanelView.SuspendLayout();
            this.settingsPanelView.SuspendLayout();
            this.aboutPanelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.DarkGray;
            this.sidebarContainer.Controls.Add(this.menuPanel);
            this.sidebarContainer.Controls.Add(this.homePanel);
            this.sidebarContainer.Controls.Add(this.aboutPanel);
            this.sidebarContainer.Controls.Add(this.settingPanel);
            this.sidebarContainer.Controls.Add(this.browserPanel);
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(170, 450);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(66, 450);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(170, 450);
            this.sidebarContainer.TabIndex = 1;
            this.sidebarContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarContainer_Paint);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.menulbl);
            this.menuPanel.Controls.Add(this.menuButton);
            this.menuPanel.Location = new System.Drawing.Point(3, 3);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(167, 100);
            this.menuPanel.TabIndex = 0;
            // 
            // menulbl
            // 
            this.menulbl.AutoSize = true;
            this.menulbl.Location = new System.Drawing.Point(86, 34);
            this.menulbl.Name = "menulbl";
            this.menulbl.Size = new System.Drawing.Size(40, 16);
            this.menulbl.TabIndex = 1;
            this.menulbl.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(9, 9);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(53, 50);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.homebtn);
            this.homePanel.Location = new System.Drawing.Point(3, 109);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(167, 46);
            this.homePanel.TabIndex = 1;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Image = global::PowerToysForXP.Properties.Resources.home;
            this.homebtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.homebtn.Location = new System.Drawing.Point(3, 12);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(164, 31);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click_1);
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.aboutbtn);
            this.aboutPanel.Location = new System.Drawing.Point(3, 161);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(167, 46);
            this.aboutPanel.TabIndex = 2;
            // 
            // aboutbtn
            // 
            this.aboutbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.Image = global::PowerToysForXP.Properties.Resources.about1;
            this.aboutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutbtn.Location = new System.Drawing.Point(3, 12);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(164, 31);
            this.aboutbtn.TabIndex = 2;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = false;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // settingPanel
            // 
            this.settingPanel.Controls.Add(this.settingbtn);
            this.settingPanel.Location = new System.Drawing.Point(3, 213);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(167, 46);
            this.settingPanel.TabIndex = 4;
            this.settingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.settingPanel_Paint);
            // 
            // settingbtn
            // 
            this.settingbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingbtn.Image = global::PowerToysForXP.Properties.Resources.settings;
            this.settingbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingbtn.Location = new System.Drawing.Point(3, 12);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(164, 31);
            this.settingbtn.TabIndex = 2;
            this.settingbtn.Text = "Setting";
            this.settingbtn.UseVisualStyleBackColor = false;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click);
            // 
            // browserPanel
            // 
            this.browserPanel.Controls.Add(this.browserbtn);
            this.browserPanel.Location = new System.Drawing.Point(3, 265);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(167, 46);
            this.browserPanel.TabIndex = 5;
            // 
            // browserbtn
            // 
            this.browserbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.browserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browserbtn.Image = global::PowerToysForXP.Properties.Resources.settings;
            this.browserbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browserbtn.Location = new System.Drawing.Point(3, 12);
            this.browserbtn.Name = "browserbtn";
            this.browserbtn.Size = new System.Drawing.Size(164, 31);
            this.browserbtn.TabIndex = 2;
            this.browserbtn.Text = "Browser";
            this.browserbtn.UseVisualStyleBackColor = false;
            this.browserbtn.Click += new System.EventHandler(this.browserbtn_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // browserPanelView
            // 
            this.browserPanelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserPanelView.Controls.Add(this.url);
            this.browserPanelView.Controls.Add(this.forwardBtn);
            this.browserPanelView.Controls.Add(this.backBtn);
            this.browserPanelView.Controls.Add(this.navigatebtn);
            this.browserPanelView.Controls.Add(this.refreshBtn);
            this.browserPanelView.Controls.Add(this.browserWindow);
            this.browserPanelView.Location = new System.Drawing.Point(176, 0);
            this.browserPanelView.Name = "browserPanelView";
            this.browserPanelView.Size = new System.Drawing.Size(624, 450);
            this.browserPanelView.TabIndex = 2;
            this.browserPanelView.Paint += new System.Windows.Forms.PaintEventHandler(this.browserPanelView_Paint);
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url.Location = new System.Drawing.Point(418, 18);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(194, 22);
            this.url.TabIndex = 6;
            this.url.Enter += new System.EventHandler(this.url_Enter);
            this.url.Leave += new System.EventHandler(this.navigatebtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(212, 10);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(97, 38);
            this.forwardBtn.TabIndex = 5;
            this.forwardBtn.Text = "Forward";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(315, 10);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(97, 38);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // navigatebtn
            // 
            this.navigatebtn.Location = new System.Drawing.Point(109, 10);
            this.navigatebtn.Name = "navigatebtn";
            this.navigatebtn.Size = new System.Drawing.Size(97, 38);
            this.navigatebtn.TabIndex = 3;
            this.navigatebtn.Text = "Navigate";
            this.navigatebtn.UseVisualStyleBackColor = true;
            this.navigatebtn.Click += new System.EventHandler(this.navigatebtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(6, 10);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(97, 38);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // browserWindow
            // 
            this.browserWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browserWindow.Location = new System.Drawing.Point(0, 54);
            this.browserWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserWindow.Name = "browserWindow";
            this.browserWindow.Size = new System.Drawing.Size(624, 393);
            this.browserWindow.TabIndex = 0;
            // 
            // homePanelView
            // 
            this.homePanelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homePanelView.Controls.Add(this.label1);
            this.homePanelView.Controls.Add(this.tolbl);
            this.homePanelView.Controls.Add(this.fromlbl);
            this.homePanelView.Controls.Add(this.toKey);
            this.homePanelView.Controls.Add(this.fromKey);
            this.homePanelView.Controls.Add(this.keyboardKeyMapper);
            this.homePanelView.Controls.Add(this.colorpickerCheckBox);
            this.homePanelView.Controls.Add(this.homelbl);
            this.homePanelView.Location = new System.Drawing.Point(176, 0);
            this.homePanelView.Name = "homePanelView";
            this.homePanelView.Size = new System.Drawing.Size(624, 450);
            this.homePanelView.TabIndex = 7;
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolbl.Location = new System.Drawing.Point(496, 155);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(36, 25);
            this.tolbl.TabIndex = 6;
            this.tolbl.Text = "To";
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(364, 155);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(57, 25);
            this.fromlbl.TabIndex = 5;
            this.fromlbl.Text = "From";
            // 
            // toKey
            // 
            this.toKey.FormattingEnabled = true;
            this.toKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "W",
            "X",
            "Y",
            "Z"});
            this.toKey.Location = new System.Drawing.Point(465, 183);
            this.toKey.Name = "toKey";
            this.toKey.Size = new System.Drawing.Size(121, 24);
            this.toKey.TabIndex = 4;
            // 
            // fromKey
            // 
            this.fromKey.FormattingEnabled = true;
            this.fromKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "W",
            "X",
            "Y",
            "Z"});
            this.fromKey.Location = new System.Drawing.Point(338, 183);
            this.fromKey.Name = "fromKey";
            this.fromKey.Size = new System.Drawing.Size(121, 24);
            this.fromKey.TabIndex = 3;
            // 
            // keyboardKeyMapper
            // 
            this.keyboardKeyMapper.AutoSize = true;
            this.keyboardKeyMapper.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.keyboardKeyMapper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keyboardKeyMapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardKeyMapper.Location = new System.Drawing.Point(353, 109);
            this.keyboardKeyMapper.Name = "keyboardKeyMapper";
            this.keyboardKeyMapper.Size = new System.Drawing.Size(233, 26);
            this.keyboardKeyMapper.TabIndex = 2;
            this.keyboardKeyMapper.Text = "Key Board Key Mapper";
            this.keyboardKeyMapper.UseVisualStyleBackColor = true;
            this.keyboardKeyMapper.CheckedChanged += new System.EventHandler(this.keyboardKeyMapper_CheckedChanged);
            // 
            // colorpickerCheckBox
            // 
            this.colorpickerCheckBox.AutoSize = true;
            this.colorpickerCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.colorpickerCheckBox.Checked = true;
            this.colorpickerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorpickerCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorpickerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorpickerCheckBox.Location = new System.Drawing.Point(91, 109);
            this.colorpickerCheckBox.Name = "colorpickerCheckBox";
            this.colorpickerCheckBox.Size = new System.Drawing.Size(138, 26);
            this.colorpickerCheckBox.TabIndex = 1;
            this.colorpickerCheckBox.Text = "Color Picker";
            this.colorpickerCheckBox.UseVisualStyleBackColor = true;
            this.colorpickerCheckBox.CheckedChanged += new System.EventHandler(this.colorpickerCheckBox_CheckedChanged);
            // 
            // homelbl
            // 
            this.homelbl.AutoSize = true;
            this.homelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homelbl.Location = new System.Drawing.Point(251, 3);
            this.homelbl.Name = "homelbl";
            this.homelbl.Size = new System.Drawing.Size(93, 32);
            this.homelbl.TabIndex = 0;
            this.homelbl.Text = "Home";
            // 
            // settingsPanelView
            // 
            this.settingsPanelView.Controls.Add(this.darkModeCheckbox);
            this.settingsPanelView.Controls.Add(this.settingslbl);
            this.settingsPanelView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.settingsPanelView.Location = new System.Drawing.Point(176, 0);
            this.settingsPanelView.Name = "settingsPanelView";
            this.settingsPanelView.Size = new System.Drawing.Size(624, 450);
            this.settingsPanelView.TabIndex = 7;
            // 
            // settingslbl
            // 
            this.settingslbl.AutoSize = true;
            this.settingslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingslbl.Location = new System.Drawing.Point(248, 24);
            this.settingslbl.Name = "settingslbl";
            this.settingslbl.Size = new System.Drawing.Size(126, 32);
            this.settingslbl.TabIndex = 0;
            this.settingslbl.Text = "Settings";
            // 
            // darkModeCheckbox
            // 
            this.darkModeCheckbox.AutoSize = true;
            this.darkModeCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.darkModeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkModeCheckbox.Location = new System.Drawing.Point(96, 141);
            this.darkModeCheckbox.Name = "darkModeCheckbox";
            this.darkModeCheckbox.Size = new System.Drawing.Size(130, 29);
            this.darkModeCheckbox.TabIndex = 1;
            this.darkModeCheckbox.Text = "Dark Mode";
            this.darkModeCheckbox.UseVisualStyleBackColor = true;
            this.darkModeCheckbox.CheckedChanged += new System.EventHandler(this.darkModeCheckbox_CheckedChanged);
            // 
            // aboutPanelView
            // 
            this.aboutPanelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutPanelView.Controls.Add(this.linkLabel1);
            this.aboutPanelView.Controls.Add(this.message);
            this.aboutPanelView.Controls.Add(this.aboutlbl);
            this.aboutPanelView.Location = new System.Drawing.Point(176, 0);
            this.aboutPanelView.Name = "aboutPanelView";
            this.aboutPanelView.Size = new System.Drawing.Size(624, 450);
            this.aboutPanelView.TabIndex = 2;
            // 
            // aboutlbl
            // 
            this.aboutlbl.AutoSize = true;
            this.aboutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutlbl.Location = new System.Drawing.Point(251, 30);
            this.aboutlbl.Name = "aboutlbl";
            this.aboutlbl.Size = new System.Drawing.Size(94, 32);
            this.aboutlbl.TabIndex = 0;
            this.aboutlbl.Text = "About";
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Font = new System.Drawing.Font("Arial Black", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Black;
            this.message.Location = new System.Drawing.Point(24, 75);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(573, 165);
            this.message.TabIndex = 1;
            this.message.Text = resources.GetString("message.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(237, 225);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github Link";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Shortcut Key Ctrl+Shift+C";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homePanelView);
            this.Controls.Add(this.aboutPanelView);
            this.Controls.Add(this.settingsPanelView);
            this.Controls.Add(this.browserPanelView);
            this.Controls.Add(this.sidebarContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Power Toys For XP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.sidebarContainer.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.aboutPanel.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.browserPanel.ResumeLayout(false);
            this.browserPanelView.ResumeLayout(false);
            this.browserPanelView.PerformLayout();
            this.homePanelView.ResumeLayout(false);
            this.homePanelView.PerformLayout();
            this.settingsPanelView.ResumeLayout(false);
            this.settingsPanelView.PerformLayout();
            this.aboutPanelView.ResumeLayout(false);
            this.aboutPanelView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label menulbl;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.Button settingbtn;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel browserPanel;
        private System.Windows.Forms.Button browserbtn;
        private System.Windows.Forms.Panel browserPanelView;
        private System.Windows.Forms.WebBrowser browserWindow;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button navigatebtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Panel homePanelView;
        private System.Windows.Forms.Label homelbl;
        private System.Windows.Forms.CheckBox colorpickerCheckBox;
        private System.Windows.Forms.CheckBox keyboardKeyMapper;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.ComboBox toKey;
        private System.Windows.Forms.ComboBox fromKey;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.Panel settingsPanelView;
        private System.Windows.Forms.Label settingslbl;
        private System.Windows.Forms.CheckBox darkModeCheckbox;
        private System.Windows.Forms.Panel aboutPanelView;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label aboutlbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}