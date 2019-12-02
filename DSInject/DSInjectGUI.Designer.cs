namespace DSInject
{
    partial class DSInjectGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSInjectGUI));
            this.buttonRom = new System.Windows.Forms.Button();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.labelRom = new System.Windows.Forms.Label();
            this.labeShortName = new System.Windows.Forms.Label();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxRom = new System.Windows.Forms.TextBox();
            this.buttonInject = new System.Windows.Forms.Button();
            this.groupBoxImages = new System.Windows.Forms.GroupBox();
            this.checkBoxUseIcon = new System.Windows.Forms.CheckBox();
            this.buttonTitleScreen = new System.Windows.Forms.Button();
            this.comboBoxReleased = new System.Windows.Forms.ComboBox();
            this.labelReleased = new System.Windows.Forms.Label();
            this.checkBoxShowName = new System.Windows.Forms.CheckBox();
            this.buttonBootDrc = new System.Windows.Forms.Button();
            this.pictureBoxBootDrc = new System.Windows.Forms.PictureBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonIcon = new System.Windows.Forms.Button();
            this.buttonBootTv = new System.Windows.Forms.Button();
            this.pictureBoxBootTv = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.buttonGameIconBGColor = new System.Windows.Forms.Button();
            this.labelGameIcon = new System.Windows.Forms.Label();
            this.panelGameIcon = new System.Windows.Forms.Panel();
            this.checkBoxPackUpResult = new System.Windows.Forms.CheckBox();
            this.labelTitleId = new System.Windows.Forms.Label();
            this.textBoxLNLine2 = new System.Windows.Forms.TextBox();
            this.textBoxLNLine1 = new System.Windows.Forms.TextBox();
            this.checkBoxLongName = new System.Windows.Forms.CheckBox();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.textBoxLayoutsDir = new System.Windows.Forms.TextBox();
            this.checkBoxLayouts = new System.Windows.Forms.CheckBox();
            this.buttonLayoutsDir = new System.Windows.Forms.Button();
            this.labelBy = new System.Windows.Forms.Label();
            this.labelBaseFrom = new System.Windows.Forms.Label();
            this.panelLoadedBase = new System.Windows.Forms.Panel();
            this.labelLoadedBase = new System.Windows.Forms.Label();
            this.panelValidKey = new System.Windows.Forms.Panel();
            this.checkBoxImagesDir = new System.Windows.Forms.CheckBox();
            this.buttonImagesDir = new System.Windows.Forms.Button();
            this.textBoxImagesDir = new System.Windows.Forms.TextBox();
            this.labelCommonKey = new System.Windows.Forms.Label();
            this.textBoxCommonKey = new System.Windows.Forms.TextBox();
            this.buttonBaseFrom = new System.Windows.Forms.Button();
            this.buttonRomDir = new System.Windows.Forms.Button();
            this.textBoxBaseFrom = new System.Windows.Forms.TextBox();
            this.textBoxRomDir = new System.Windows.Forms.TextBox();
            this.checkBoxAskBase = new System.Windows.Forms.CheckBox();
            this.checkBoxRomDir = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBootDrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBootTv)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRom
            // 
            this.buttonRom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRom.Location = new System.Drawing.Point(644, 4);
            this.buttonRom.Name = "buttonRom";
            this.buttonRom.Size = new System.Drawing.Size(24, 23);
            this.buttonRom.TabIndex = 0;
            this.buttonRom.Text = "...";
            this.buttonRom.UseVisualStyleBackColor = true;
            this.buttonRom.Click += new System.EventHandler(this.buttonRom_Click);
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShortName.Location = new System.Drawing.Point(81, 32);
            this.textBoxShortName.MaxLength = 256;
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(587, 20);
            this.textBoxShortName.TabIndex = 2;
            this.textBoxShortName.TextChanged += new System.EventHandler(this.textBoxShortName_TextChanged);
            // 
            // labelRom
            // 
            this.labelRom.AutoSize = true;
            this.labelRom.Location = new System.Drawing.Point(8, 9);
            this.labelRom.Name = "labelRom";
            this.labelRom.Size = new System.Drawing.Size(59, 13);
            this.labelRom.TabIndex = 4;
            this.labelRom.Text = "ROM path:";
            // 
            // labeShortName
            // 
            this.labeShortName.AutoSize = true;
            this.labeShortName.Location = new System.Drawing.Point(8, 35);
            this.labeShortName.Name = "labeShortName";
            this.labeShortName.Size = new System.Drawing.Size(64, 13);
            this.labeShortName.TabIndex = 6;
            this.labeShortName.Text = "Short name:";
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Location = new System.Drawing.Point(330, 156);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(74, 13);
            this.labelProductCode.TabIndex = 7;
            this.labelProductCode.Text = "Product code:";
            // 
            // textBoxRom
            // 
            this.textBoxRom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRom.Location = new System.Drawing.Point(81, 6);
            this.textBoxRom.Name = "textBoxRom";
            this.textBoxRom.Size = new System.Drawing.Size(557, 20);
            this.textBoxRom.TabIndex = 8;
            // 
            // buttonInject
            // 
            this.buttonInject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInject.Enabled = false;
            this.buttonInject.Location = new System.Drawing.Point(3, 480);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(570, 40);
            this.buttonInject.TabIndex = 10;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // groupBoxImages
            // 
            this.groupBoxImages.Controls.Add(this.checkBoxUseIcon);
            this.groupBoxImages.Controls.Add(this.buttonTitleScreen);
            this.groupBoxImages.Controls.Add(this.comboBoxReleased);
            this.groupBoxImages.Controls.Add(this.labelReleased);
            this.groupBoxImages.Controls.Add(this.checkBoxShowName);
            this.groupBoxImages.Controls.Add(this.buttonBootDrc);
            this.groupBoxImages.Controls.Add(this.pictureBoxBootDrc);
            this.groupBoxImages.Controls.Add(this.pictureBoxIcon);
            this.groupBoxImages.Controls.Add(this.buttonIcon);
            this.groupBoxImages.Controls.Add(this.buttonBootTv);
            this.groupBoxImages.Controls.Add(this.pictureBoxBootTv);
            this.groupBoxImages.Location = new System.Drawing.Point(8, 187);
            this.groupBoxImages.Name = "groupBoxImages";
            this.groupBoxImages.Size = new System.Drawing.Size(660, 288);
            this.groupBoxImages.TabIndex = 11;
            this.groupBoxImages.TabStop = false;
            this.groupBoxImages.Text = "Images";
            // 
            // checkBoxUseIcon
            // 
            this.checkBoxUseIcon.AutoSize = true;
            this.checkBoxUseIcon.Location = new System.Drawing.Point(251, 261);
            this.checkBoxUseIcon.Name = "checkBoxUseIcon";
            this.checkBoxUseIcon.Size = new System.Drawing.Size(68, 17);
            this.checkBoxUseIcon.TabIndex = 14;
            this.checkBoxUseIcon.Text = "Use icon";
            this.checkBoxUseIcon.UseVisualStyleBackColor = true;
            this.checkBoxUseIcon.CheckedChanged += new System.EventHandler(this.checkBoxUseIcon_CheckedChanged);
            // 
            // buttonTitleScreen
            // 
            this.buttonTitleScreen.Location = new System.Drawing.Point(327, 257);
            this.buttonTitleScreen.Name = "buttonTitleScreen";
            this.buttonTitleScreen.Size = new System.Drawing.Size(94, 23);
            this.buttonTitleScreen.TabIndex = 13;
            this.buttonTitleScreen.Text = "Title screen";
            this.buttonTitleScreen.UseVisualStyleBackColor = true;
            this.buttonTitleScreen.Click += new System.EventHandler(this.buttonTitleScreen_Click);
            // 
            // comboBoxReleased
            // 
            this.comboBoxReleased.FormattingEnabled = true;
            this.comboBoxReleased.Items.AddRange(new object[] {
            "None",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.comboBoxReleased.Location = new System.Drawing.Point(62, 259);
            this.comboBoxReleased.Name = "comboBoxReleased";
            this.comboBoxReleased.Size = new System.Drawing.Size(50, 21);
            this.comboBoxReleased.TabIndex = 11;
            this.comboBoxReleased.Text = "None";
            this.comboBoxReleased.SelectedIndexChanged += new System.EventHandler(this.comboBoxReleased_SelectedIndexChanged);
            // 
            // labelReleased
            // 
            this.labelReleased.AutoSize = true;
            this.labelReleased.Location = new System.Drawing.Point(6, 262);
            this.labelReleased.Name = "labelReleased";
            this.labelReleased.Size = new System.Drawing.Size(55, 13);
            this.labelReleased.TabIndex = 9;
            this.labelReleased.Text = "Released:";
            // 
            // checkBoxShowName
            // 
            this.checkBoxShowName.AutoSize = true;
            this.checkBoxShowName.Checked = true;
            this.checkBoxShowName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowName.Location = new System.Drawing.Point(131, 261);
            this.checkBoxShowName.Name = "checkBoxShowName";
            this.checkBoxShowName.Size = new System.Drawing.Size(82, 17);
            this.checkBoxShowName.TabIndex = 8;
            this.checkBoxShowName.Text = "Show name";
            this.checkBoxShowName.UseVisualStyleBackColor = true;
            this.checkBoxShowName.CheckedChanged += new System.EventHandler(this.checkBoxShowName_CheckedChanged);
            // 
            // buttonBootDrc
            // 
            this.buttonBootDrc.Location = new System.Drawing.Point(426, 198);
            this.buttonBootDrc.Name = "buttonBootDrc";
            this.buttonBootDrc.Size = new System.Drawing.Size(94, 38);
            this.buttonBootDrc.TabIndex = 7;
            this.buttonBootDrc.Text = "Boot Drc";
            this.buttonBootDrc.UseVisualStyleBackColor = true;
            this.buttonBootDrc.Click += new System.EventHandler(this.buttonBootDrc_Click);
            // 
            // pictureBoxBootDrc
            // 
            this.pictureBoxBootDrc.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxBootDrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBootDrc.Location = new System.Drawing.Point(426, 19);
            this.pictureBoxBootDrc.Name = "pictureBoxBootDrc";
            this.pictureBoxBootDrc.Size = new System.Drawing.Size(228, 128);
            this.pictureBoxBootDrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBootDrc.TabIndex = 6;
            this.pictureBoxBootDrc.TabStop = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxIcon.Location = new System.Drawing.Point(526, 153);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 5;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonIcon
            // 
            this.buttonIcon.Location = new System.Drawing.Point(426, 243);
            this.buttonIcon.Name = "buttonIcon";
            this.buttonIcon.Size = new System.Drawing.Size(94, 38);
            this.buttonIcon.TabIndex = 4;
            this.buttonIcon.Text = "Icon";
            this.buttonIcon.UseVisualStyleBackColor = true;
            this.buttonIcon.Click += new System.EventHandler(this.buttonIcon_Click);
            // 
            // buttonBootTv
            // 
            this.buttonBootTv.Location = new System.Drawing.Point(426, 153);
            this.buttonBootTv.Name = "buttonBootTv";
            this.buttonBootTv.Size = new System.Drawing.Size(94, 38);
            this.buttonBootTv.TabIndex = 3;
            this.buttonBootTv.Text = "Boot Tv";
            this.buttonBootTv.UseVisualStyleBackColor = true;
            this.buttonBootTv.Click += new System.EventHandler(this.buttonBootTv_Click);
            // 
            // pictureBoxBootTv
            // 
            this.pictureBoxBootTv.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxBootTv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBootTv.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxBootTv.Name = "pictureBoxBootTv";
            this.pictureBoxBootTv.Size = new System.Drawing.Size(414, 232);
            this.pictureBoxBootTv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBootTv.TabIndex = 2;
            this.pictureBoxBootTv.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageConfig);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(684, 549);
            this.tabControlMain.TabIndex = 12;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMain.Controls.Add(this.buttonGameIconBGColor);
            this.tabPageMain.Controls.Add(this.labelGameIcon);
            this.tabPageMain.Controls.Add(this.panelGameIcon);
            this.tabPageMain.Controls.Add(this.checkBoxPackUpResult);
            this.tabPageMain.Controls.Add(this.labelTitleId);
            this.tabPageMain.Controls.Add(this.textBoxLNLine2);
            this.tabPageMain.Controls.Add(this.textBoxLNLine1);
            this.tabPageMain.Controls.Add(this.checkBoxLongName);
            this.tabPageMain.Controls.Add(this.labelRom);
            this.tabPageMain.Controls.Add(this.groupBoxImages);
            this.tabPageMain.Controls.Add(this.buttonRom);
            this.tabPageMain.Controls.Add(this.buttonInject);
            this.tabPageMain.Controls.Add(this.textBoxShortName);
            this.tabPageMain.Controls.Add(this.textBoxRom);
            this.tabPageMain.Controls.Add(this.labelProductCode);
            this.tabPageMain.Controls.Add(this.labeShortName);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(676, 523);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            // 
            // buttonGameIconBGColor
            // 
            this.buttonGameIconBGColor.Location = new System.Drawing.Point(116, 151);
            this.buttonGameIconBGColor.Name = "buttonGameIconBGColor";
            this.buttonGameIconBGColor.Size = new System.Drawing.Size(75, 23);
            this.buttonGameIconBGColor.TabIndex = 19;
            this.buttonGameIconBGColor.Text = "Background";
            this.buttonGameIconBGColor.UseVisualStyleBackColor = true;
            this.buttonGameIconBGColor.Click += new System.EventHandler(this.buttonGameIconBGColor_Click);
            // 
            // labelGameIcon
            // 
            this.labelGameIcon.AutoSize = true;
            this.labelGameIcon.Location = new System.Drawing.Point(9, 156);
            this.labelGameIcon.Name = "labelGameIcon";
            this.labelGameIcon.Size = new System.Drawing.Size(61, 13);
            this.labelGameIcon.TabIndex = 18;
            this.labelGameIcon.Text = "Game icon:";
            // 
            // panelGameIcon
            // 
            this.panelGameIcon.BackColor = System.Drawing.Color.Black;
            this.panelGameIcon.Location = new System.Drawing.Point(77, 145);
            this.panelGameIcon.Name = "panelGameIcon";
            this.panelGameIcon.Size = new System.Drawing.Size(32, 32);
            this.panelGameIcon.TabIndex = 17;
            // 
            // checkBoxPackUpResult
            // 
            this.checkBoxPackUpResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPackUpResult.AutoSize = true;
            this.checkBoxPackUpResult.Location = new System.Drawing.Point(579, 493);
            this.checkBoxPackUpResult.Name = "checkBoxPackUpResult";
            this.checkBoxPackUpResult.Size = new System.Drawing.Size(94, 17);
            this.checkBoxPackUpResult.TabIndex = 16;
            this.checkBoxPackUpResult.Text = "Pack up result";
            this.checkBoxPackUpResult.UseVisualStyleBackColor = true;
            // 
            // labelTitleId
            // 
            this.labelTitleId.AutoSize = true;
            this.labelTitleId.Location = new System.Drawing.Point(500, 156);
            this.labelTitleId.Name = "labelTitleId";
            this.labelTitleId.Size = new System.Drawing.Size(44, 13);
            this.labelTitleId.TabIndex = 15;
            this.labelTitleId.Text = "Title ID:";
            // 
            // textBoxLNLine2
            // 
            this.textBoxLNLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLNLine2.Enabled = false;
            this.textBoxLNLine2.Location = new System.Drawing.Point(100, 84);
            this.textBoxLNLine2.MaxLength = 255;
            this.textBoxLNLine2.Name = "textBoxLNLine2";
            this.textBoxLNLine2.Size = new System.Drawing.Size(568, 20);
            this.textBoxLNLine2.TabIndex = 14;
            this.textBoxLNLine2.TextChanged += new System.EventHandler(this.textBoxLNLine2_TextChanged);
            // 
            // textBoxLNLine1
            // 
            this.textBoxLNLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLNLine1.Enabled = false;
            this.textBoxLNLine1.Location = new System.Drawing.Point(100, 58);
            this.textBoxLNLine1.MaxLength = 255;
            this.textBoxLNLine1.Name = "textBoxLNLine1";
            this.textBoxLNLine1.Size = new System.Drawing.Size(568, 20);
            this.textBoxLNLine1.TabIndex = 13;
            this.textBoxLNLine1.TextChanged += new System.EventHandler(this.textBoxLNLine1_TextChanged);
            // 
            // checkBoxLongName
            // 
            this.checkBoxLongName.AutoSize = true;
            this.checkBoxLongName.Location = new System.Drawing.Point(12, 66);
            this.checkBoxLongName.Name = "checkBoxLongName";
            this.checkBoxLongName.Size = new System.Drawing.Size(82, 17);
            this.checkBoxLongName.TabIndex = 12;
            this.checkBoxLongName.Text = "Long name:";
            this.checkBoxLongName.UseVisualStyleBackColor = true;
            this.checkBoxLongName.CheckedChanged += new System.EventHandler(this.checkBoxLongName_CheckedChanged);
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageConfig.Controls.Add(this.textBoxLayoutsDir);
            this.tabPageConfig.Controls.Add(this.checkBoxLayouts);
            this.tabPageConfig.Controls.Add(this.buttonLayoutsDir);
            this.tabPageConfig.Controls.Add(this.labelBy);
            this.tabPageConfig.Controls.Add(this.labelBaseFrom);
            this.tabPageConfig.Controls.Add(this.panelLoadedBase);
            this.tabPageConfig.Controls.Add(this.labelLoadedBase);
            this.tabPageConfig.Controls.Add(this.panelValidKey);
            this.tabPageConfig.Controls.Add(this.checkBoxImagesDir);
            this.tabPageConfig.Controls.Add(this.buttonImagesDir);
            this.tabPageConfig.Controls.Add(this.textBoxImagesDir);
            this.tabPageConfig.Controls.Add(this.labelCommonKey);
            this.tabPageConfig.Controls.Add(this.textBoxCommonKey);
            this.tabPageConfig.Controls.Add(this.buttonBaseFrom);
            this.tabPageConfig.Controls.Add(this.buttonRomDir);
            this.tabPageConfig.Controls.Add(this.textBoxBaseFrom);
            this.tabPageConfig.Controls.Add(this.textBoxRomDir);
            this.tabPageConfig.Controls.Add(this.checkBoxAskBase);
            this.tabPageConfig.Controls.Add(this.checkBoxRomDir);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(676, 523);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Config";
            // 
            // textBoxLayoutsDir
            // 
            this.textBoxLayoutsDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLayoutsDir.Location = new System.Drawing.Point(120, 58);
            this.textBoxLayoutsDir.Name = "textBoxLayoutsDir";
            this.textBoxLayoutsDir.Size = new System.Drawing.Size(518, 20);
            this.textBoxLayoutsDir.TabIndex = 21;
            this.textBoxLayoutsDir.Visible = false;
            // 
            // checkBoxLayouts
            // 
            this.checkBoxLayouts.AutoSize = true;
            this.checkBoxLayouts.Checked = true;
            this.checkBoxLayouts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLayouts.Location = new System.Drawing.Point(8, 60);
            this.checkBoxLayouts.Name = "checkBoxLayouts";
            this.checkBoxLayouts.Size = new System.Drawing.Size(109, 17);
            this.checkBoxLayouts.TabIndex = 20;
            this.checkBoxLayouts.Text = "Layouts directory:";
            this.checkBoxLayouts.UseVisualStyleBackColor = true;
            this.checkBoxLayouts.Visible = false;
            // 
            // buttonLayoutsDir
            // 
            this.buttonLayoutsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLayoutsDir.Location = new System.Drawing.Point(644, 56);
            this.buttonLayoutsDir.Name = "buttonLayoutsDir";
            this.buttonLayoutsDir.Size = new System.Drawing.Size(24, 23);
            this.buttonLayoutsDir.TabIndex = 19;
            this.buttonLayoutsDir.Text = "...";
            this.buttonLayoutsDir.UseVisualStyleBackColor = true;
            this.buttonLayoutsDir.Visible = false;
            // 
            // labelBy
            // 
            this.labelBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBy.AutoSize = true;
            this.labelBy.Location = new System.Drawing.Point(592, 482);
            this.labelBy.Name = "labelBy";
            this.labelBy.Size = new System.Drawing.Size(55, 13);
            this.labelBy.TabIndex = 18;
            this.labelBy.Text = "phacox.cll";
            // 
            // labelBaseFrom
            // 
            this.labelBaseFrom.AutoSize = true;
            this.labelBaseFrom.Location = new System.Drawing.Point(6, 165);
            this.labelBaseFrom.Name = "labelBaseFrom";
            this.labelBaseFrom.Size = new System.Drawing.Size(83, 13);
            this.labelBaseFrom.TabIndex = 17;
            this.labelBaseFrom.Text = "Load base from:";
            // 
            // panelLoadedBase
            // 
            this.panelLoadedBase.BackColor = System.Drawing.SystemColors.Control;
            this.panelLoadedBase.BackgroundImage = global::DSInject.Properties.Resources.x_mark_16;
            this.panelLoadedBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLoadedBase.Location = new System.Drawing.Point(6, 191);
            this.panelLoadedBase.Name = "panelLoadedBase";
            this.panelLoadedBase.Size = new System.Drawing.Size(20, 20);
            this.panelLoadedBase.TabIndex = 16;
            // 
            // labelLoadedBase
            // 
            this.labelLoadedBase.AutoSize = true;
            this.labelLoadedBase.Location = new System.Drawing.Point(32, 191);
            this.labelLoadedBase.Name = "labelLoadedBase";
            this.labelLoadedBase.Size = new System.Drawing.Size(34, 13);
            this.labelLoadedBase.TabIndex = 15;
            this.labelLoadedBase.Text = "Base:";
            // 
            // panelValidKey
            // 
            this.panelValidKey.BackColor = System.Drawing.SystemColors.Control;
            this.panelValidKey.BackgroundImage = global::DSInject.Properties.Resources.x_mark_16;
            this.panelValidKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelValidKey.Location = new System.Drawing.Point(342, 110);
            this.panelValidKey.Name = "panelValidKey";
            this.panelValidKey.Size = new System.Drawing.Size(20, 20);
            this.panelValidKey.TabIndex = 14;
            // 
            // checkBoxImagesDir
            // 
            this.checkBoxImagesDir.AutoSize = true;
            this.checkBoxImagesDir.Checked = true;
            this.checkBoxImagesDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImagesDir.Location = new System.Drawing.Point(8, 34);
            this.checkBoxImagesDir.Name = "checkBoxImagesDir";
            this.checkBoxImagesDir.Size = new System.Drawing.Size(106, 17);
            this.checkBoxImagesDir.TabIndex = 13;
            this.checkBoxImagesDir.Text = "Images directory:";
            this.checkBoxImagesDir.UseVisualStyleBackColor = true;
            // 
            // buttonImagesDir
            // 
            this.buttonImagesDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImagesDir.Location = new System.Drawing.Point(644, 30);
            this.buttonImagesDir.Name = "buttonImagesDir";
            this.buttonImagesDir.Size = new System.Drawing.Size(24, 23);
            this.buttonImagesDir.TabIndex = 12;
            this.buttonImagesDir.Text = "...";
            this.buttonImagesDir.UseVisualStyleBackColor = true;
            this.buttonImagesDir.Click += new System.EventHandler(this.buttonImagesDir_Click);
            // 
            // textBoxImagesDir
            // 
            this.textBoxImagesDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImagesDir.Location = new System.Drawing.Point(120, 32);
            this.textBoxImagesDir.Name = "textBoxImagesDir";
            this.textBoxImagesDir.Size = new System.Drawing.Size(518, 20);
            this.textBoxImagesDir.TabIndex = 11;
            // 
            // labelCommonKey
            // 
            this.labelCommonKey.AutoSize = true;
            this.labelCommonKey.Location = new System.Drawing.Point(6, 113);
            this.labelCommonKey.Name = "labelCommonKey";
            this.labelCommonKey.Size = new System.Drawing.Size(100, 13);
            this.labelCommonKey.TabIndex = 10;
            this.labelCommonKey.Text = "Wii U Common key:";
            // 
            // textBoxCommonKey
            // 
            this.textBoxCommonKey.Location = new System.Drawing.Point(120, 110);
            this.textBoxCommonKey.Name = "textBoxCommonKey";
            this.textBoxCommonKey.Size = new System.Drawing.Size(216, 20);
            this.textBoxCommonKey.TabIndex = 9;
            this.textBoxCommonKey.TextChanged += new System.EventHandler(this.textBoxCommonKey_TextChanged);
            // 
            // buttonBaseFrom
            // 
            this.buttonBaseFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBaseFrom.Location = new System.Drawing.Point(644, 160);
            this.buttonBaseFrom.Name = "buttonBaseFrom";
            this.buttonBaseFrom.Size = new System.Drawing.Size(24, 23);
            this.buttonBaseFrom.TabIndex = 8;
            this.buttonBaseFrom.Text = "...";
            this.buttonBaseFrom.UseVisualStyleBackColor = true;
            this.buttonBaseFrom.Click += new System.EventHandler(this.buttonBaseFrom_Click);
            // 
            // buttonRomDir
            // 
            this.buttonRomDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRomDir.Location = new System.Drawing.Point(644, 4);
            this.buttonRomDir.Name = "buttonRomDir";
            this.buttonRomDir.Size = new System.Drawing.Size(24, 23);
            this.buttonRomDir.TabIndex = 6;
            this.buttonRomDir.Text = "...";
            this.buttonRomDir.UseVisualStyleBackColor = true;
            this.buttonRomDir.Click += new System.EventHandler(this.buttonRomDir_Click);
            // 
            // textBoxBaseFrom
            // 
            this.textBoxBaseFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBaseFrom.Location = new System.Drawing.Point(120, 162);
            this.textBoxBaseFrom.Name = "textBoxBaseFrom";
            this.textBoxBaseFrom.Size = new System.Drawing.Size(518, 20);
            this.textBoxBaseFrom.TabIndex = 5;
            // 
            // textBoxRomDir
            // 
            this.textBoxRomDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRomDir.Location = new System.Drawing.Point(120, 6);
            this.textBoxRomDir.Name = "textBoxRomDir";
            this.textBoxRomDir.Size = new System.Drawing.Size(518, 20);
            this.textBoxRomDir.TabIndex = 3;
            // 
            // checkBoxAskBase
            // 
            this.checkBoxAskBase.AutoSize = true;
            this.checkBoxAskBase.Location = new System.Drawing.Point(8, 238);
            this.checkBoxAskBase.Name = "checkBoxAskBase";
            this.checkBoxAskBase.Size = new System.Drawing.Size(165, 17);
            this.checkBoxAskBase.TabIndex = 2;
            this.checkBoxAskBase.Text = "Ask for a base when injecting";
            this.checkBoxAskBase.UseVisualStyleBackColor = true;
            this.checkBoxAskBase.CheckedChanged += new System.EventHandler(this.checkBoxAskBase_CheckedChanged);
            // 
            // checkBoxRomDir
            // 
            this.checkBoxRomDir.AutoSize = true;
            this.checkBoxRomDir.Checked = true;
            this.checkBoxRomDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRomDir.Location = new System.Drawing.Point(8, 8);
            this.checkBoxRomDir.Name = "checkBoxRomDir";
            this.checkBoxRomDir.Size = new System.Drawing.Size(97, 17);
            this.checkBoxRomDir.TabIndex = 0;
            this.checkBoxRomDir.Text = "ROM directory:";
            this.checkBoxRomDir.UseVisualStyleBackColor = true;
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // DSInjectGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 549);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 588);
            this.Name = "DSInjectGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSInjectGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DSInjectGUI_FormClosing);
            this.groupBoxImages.ResumeLayout(false);
            this.groupBoxImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBootDrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBootTv)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRom;
        private System.Windows.Forms.TextBox textBoxShortName;
        private System.Windows.Forms.Label labelRom;
        private System.Windows.Forms.Label labeShortName;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxRom;
        private System.Windows.Forms.Button buttonInject;
        private System.Windows.Forms.GroupBox groupBoxImages;
        private System.Windows.Forms.Button buttonIcon;
        private System.Windows.Forms.Button buttonBootTv;
        private System.Windows.Forms.PictureBox pictureBoxBootTv;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.Label labelCommonKey;
        private System.Windows.Forms.TextBox textBoxCommonKey;
        private System.Windows.Forms.Button buttonBaseFrom;
        private System.Windows.Forms.Button buttonRomDir;
        private System.Windows.Forms.TextBox textBoxBaseFrom;
        private System.Windows.Forms.TextBox textBoxRomDir;
        private System.Windows.Forms.CheckBox checkBoxAskBase;
        private System.Windows.Forms.CheckBox checkBoxRomDir;
        private System.Windows.Forms.TextBox textBoxLNLine2;
        private System.Windows.Forms.TextBox textBoxLNLine1;
        private System.Windows.Forms.CheckBox checkBoxLongName;
        private System.Windows.Forms.Label labelTitleId;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBoxImagesDir;
        private System.Windows.Forms.Button buttonImagesDir;
        private System.Windows.Forms.TextBox textBoxImagesDir;
        private System.Windows.Forms.Panel panelValidKey;
        private System.Windows.Forms.Label labelLoadedBase;
        private System.Windows.Forms.Label labelBaseFrom;
        private System.Windows.Forms.Panel panelLoadedBase;
        private System.Windows.Forms.CheckBox checkBoxPackUpResult;
        private System.Windows.Forms.PictureBox pictureBoxBootDrc;
        private System.Windows.Forms.Button buttonBootDrc;
        private System.Windows.Forms.Label labelBy;
        private System.Windows.Forms.ComboBox comboBoxReleased;
        private System.Windows.Forms.Label labelReleased;
        private System.Windows.Forms.CheckBox checkBoxShowName;
        private System.Windows.Forms.Button buttonTitleScreen;
        private System.Windows.Forms.CheckBox checkBoxUseIcon;
        private System.Windows.Forms.Label labelGameIcon;
        private System.Windows.Forms.Panel panelGameIcon;
        private System.Windows.Forms.Button buttonGameIconBGColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox textBoxLayoutsDir;
        private System.Windows.Forms.CheckBox checkBoxLayouts;
        private System.Windows.Forms.Button buttonLayoutsDir;
    }
}