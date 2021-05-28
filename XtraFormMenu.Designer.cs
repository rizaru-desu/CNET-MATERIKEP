namespace APPS
{
    partial class XtraFormMenu
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::APPS.SplashScreen), false, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripUpdate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTim = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTips = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOffi = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHelp = new System.Windows.Forms.ToolStripLabel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimaze = new System.Windows.Forms.Button();
            this.radContextOfficial = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuWeb1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuIG2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuYT3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radContextTrick = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuTips1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuTips2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuTips3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuTips4 = new Telerik.WinControls.UI.RadMenuItem();
            this.automaticUpdater1 = new wyDay.Controls.AutomaticUpdater();
            this.userMenu = new APPS.UserMenu();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUpdate,
            this.toolStripSeparator1,
            this.toolStripTim,
            this.toolStripSeparator2,
            this.toolStripTips,
            this.toolStripSeparator3,
            this.toolStripOffi,
            this.toolStripSeparator4,
            this.toolStripHelp});
            this.toolStrip.Location = new System.Drawing.Point(197, 512);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(524, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripUpdate
            // 
            this.toolStripUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.toolStripUpdate.Image = global::APPS.Properties.Resources.Check_;
            this.toolStripUpdate.Name = "toolStripUpdate";
            this.toolStripUpdate.Size = new System.Drawing.Size(139, 22);
            this.toolStripUpdate.Text = "Check for Update";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTim
            // 
            this.toolStripTim.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.toolStripTim.Image = global::APPS.Properties.Resources.Tim_;
            this.toolStripTim.Name = "toolStripTim";
            this.toolStripTim.Size = new System.Drawing.Size(113, 22);
            this.toolStripTim.Text = "Tim Penyusun";
            this.toolStripTim.Click += new System.EventHandler(this.ToolStripTim_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTips
            // 
            this.toolStripTips.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.toolStripTips.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTips.Image")));
            this.toolStripTips.Name = "toolStripTips";
            this.toolStripTips.Size = new System.Drawing.Size(99, 22);
            this.toolStripTips.Text = "Tips && Trick";
            this.toolStripTips.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripTips_MouseDown);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripOffi
            // 
            this.toolStripOffi.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.toolStripOffi.Image = global::APPS.Properties.Resources.Office_;
            this.toolStripOffi.Name = "toolStripOffi";
            this.toolStripOffi.Size = new System.Drawing.Size(68, 22);
            this.toolStripOffi.Text = "Official";
            this.toolStripOffi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStripOffi_MouseDown);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.toolStripHelp.Image = global::APPS.Properties.Resources.Help_;
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(78, 22);
            this.toolStripHelp.Text = "Bantuan";
            this.toolStripHelp.Click += new System.EventHandler(this.ToolStripHelp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.BackgroundImage = global::APPS.Properties.Resources.close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(918, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonMinimaze
            // 
            this.buttonMinimaze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMinimaze.BackgroundImage = global::APPS.Properties.Resources.minimaze;
            this.buttonMinimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimaze.FlatAppearance.BorderSize = 0;
            this.buttonMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimaze.Location = new System.Drawing.Point(2, 3);
            this.buttonMinimaze.Name = "buttonMinimaze";
            this.buttonMinimaze.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimaze.TabIndex = 4;
            this.buttonMinimaze.UseVisualStyleBackColor = true;
            this.buttonMinimaze.Click += new System.EventHandler(this.ButtonMinimaze_Click);
            // 
            // radContextOfficial
            // 
            this.radContextOfficial.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuWeb1,
            this.radMenuIG2,
            this.radMenuYT3});
            // 
            // radMenuWeb1
            // 
            this.radMenuWeb1.Image = global::APPS.Properties.Resources.Office_small;
            this.radMenuWeb1.Name = "radMenuWeb1";
            this.radMenuWeb1.Text = "Website";
            // 
            // radMenuIG2
            // 
            this.radMenuIG2.Image = global::APPS.Properties.Resources.instagram;
            this.radMenuIG2.Name = "radMenuIG2";
            this.radMenuIG2.Text = "Instagram";
            // 
            // radMenuYT3
            // 
            this.radMenuYT3.Image = global::APPS.Properties.Resources.youtube;
            this.radMenuYT3.Name = "radMenuYT3";
            this.radMenuYT3.Text = "Youtube";
            // 
            // radContextTrick
            // 
            this.radContextTrick.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuTips1,
            this.radMenuTips2,
            this.radMenuTips3,
            this.radMenuTips4});
            // 
            // radMenuTips1
            // 
            this.radMenuTips1.Name = "radMenuTips1";
            this.radMenuTips1.Text = "Menurut Akbar Asfar, S.Kep., NS., M.Kes";
            // 
            // radMenuTips2
            // 
            this.radMenuTips2.Name = "radMenuTips2";
            this.radMenuTips2.Text = "Menurut Brajakson Siokal, S.Kep., NS., M.Kep";
            // 
            // radMenuTips3
            // 
            this.radMenuTips3.Name = "radMenuTips3";
            this.radMenuTips3.Text = "Menurut Sudarman, S.Kep., NS., M.Kes";
            // 
            // radMenuTips4
            // 
            this.radMenuTips4.Name = "radMenuTips4";
            this.radMenuTips4.Text = "Menurut Ns. Ambo Anto, S.Kep., M.MKep";
            // 
            // automaticUpdater1
            // 
            this.automaticUpdater1.ContainerForm = this;
            this.automaticUpdater1.GUID = "d3c356ae-d93e-491a-b133-7f08865fc6e6";
            this.automaticUpdater1.Location = new System.Drawing.Point(6, 512);
            this.automaticUpdater1.Name = "automaticUpdater1";
            this.automaticUpdater1.Size = new System.Drawing.Size(16, 16);
            this.automaticUpdater1.TabIndex = 5;
            this.automaticUpdater1.ToolStripItem = this.toolStripUpdate;
            this.automaticUpdater1.UpdateType = wyDay.Controls.UpdateType.OnlyCheck;
            this.automaticUpdater1.wyUpdateCommandline = null;
            this.automaticUpdater1.wyUpdateLocation = "AUMKEP.exe";
            this.automaticUpdater1.ClosingAborted += new System.EventHandler(this.AutomaticUpdater1_ClosingAborted);
            // 
            // userMenu
            // 
            this.userMenu.BackColor = System.Drawing.Color.Transparent;
            this.userMenu.Location = new System.Drawing.Point(57, 11);
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(835, 450);
            this.userMenu.TabIndex = 2;
            // 
            // XtraFormMenu
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::APPS.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(941, 537);
            this.Controls.Add(this.automaticUpdater1);
            this.Controls.Add(this.buttonMinimaze);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraFormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - ALTER";
            this.Load += new System.EventHandler(this.XtraFormMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XtraFormMenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.automaticUpdater1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripUpdate;
        private UserMenu userMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimaze;
        private Telerik.WinControls.UI.RadContextMenu radContextOfficial;
        private Telerik.WinControls.UI.RadMenuItem radMenuWeb1;
        private Telerik.WinControls.UI.RadMenuItem radMenuIG2;
        private Telerik.WinControls.UI.RadMenuItem radMenuYT3;
        private Telerik.WinControls.UI.RadContextMenu radContextTrick;
        private Telerik.WinControls.UI.RadMenuItem radMenuTips1;
        private Telerik.WinControls.UI.RadMenuItem radMenuTips2;
        private Telerik.WinControls.UI.RadMenuItem radMenuTips3;
        private Telerik.WinControls.UI.RadMenuItem radMenuTips4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripTim;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripTips;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripOffi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripHelp;
        private wyDay.Controls.AutomaticUpdater automaticUpdater1;
    }
}