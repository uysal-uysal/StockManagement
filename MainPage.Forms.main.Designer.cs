namespace StokOtomasyonu
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.commonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fruitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vegetablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menswearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.womenswearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStrip,
            this.productToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStrip
            // 
            this.registerToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegistrationToolStripMenuItem,
            this.productRegistrationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.registerToolStrip.Name = "registerToolStrip";
            this.registerToolStrip.Size = new System.Drawing.Size(42, 20);
            this.registerToolStrip.Text = "User";
            // 
            // userRegistrationToolStripMenuItem
            // 
            this.userRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripAdmin,
            this.commonToolStripMenuItem});
            this.userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            this.userRegistrationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userRegistrationToolStripMenuItem.Text = "User Registration";
            // 
            // ToolStripAdmin
            // 
            this.ToolStripAdmin.Name = "ToolStripAdmin";
            this.ToolStripAdmin.Size = new System.Drawing.Size(125, 22);
            this.ToolStripAdmin.Text = "Admin";
            this.ToolStripAdmin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // commonToolStripMenuItem
            // 
            this.commonToolStripMenuItem.Name = "commonToolStripMenuItem";
            this.commonToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.commonToolStripMenuItem.Text = "Common";
            this.commonToolStripMenuItem.Click += new System.EventHandler(this.commonToolStripMenuItem_Click);
            // 
            // productRegistrationToolStripMenuItem
            // 
            this.productRegistrationToolStripMenuItem.Name = "productRegistrationToolStripMenuItem";
            this.productRegistrationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.productRegistrationToolStripMenuItem.Text = "Delete User";
            this.productRegistrationToolStripMenuItem.Click += new System.EventHandler(this.productRegistrationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Category";
            this.addNewCategoryToolStripMenuItem.Click += new System.EventHandler(this.addNewCategoryToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breadToolStripMenuItem,
            this.drinksToolStripMenuItem,
            this.fruitsToolStripMenuItem,
            this.vegetablesToolStripMenuItem,
            this.menswearToolStripMenuItem,
            this.womenswearToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // breadToolStripMenuItem
            // 
            this.breadToolStripMenuItem.Name = "breadToolStripMenuItem";
            this.breadToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.breadToolStripMenuItem.Text = "bread";
            this.breadToolStripMenuItem.Click += new System.EventHandler(this.breadToolStripMenuItem_Click);
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.drinksToolStripMenuItem.Text = "drinks";
            this.drinksToolStripMenuItem.Click += new System.EventHandler(this.drinksToolStripMenuItem_Click);
            // 
            // fruitsToolStripMenuItem
            // 
            this.fruitsToolStripMenuItem.Name = "fruitsToolStripMenuItem";
            this.fruitsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fruitsToolStripMenuItem.Text = "fruits";
            this.fruitsToolStripMenuItem.Click += new System.EventHandler(this.fruitsToolStripMenuItem_Click);
            // 
            // vegetablesToolStripMenuItem
            // 
            this.vegetablesToolStripMenuItem.Name = "vegetablesToolStripMenuItem";
            this.vegetablesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.vegetablesToolStripMenuItem.Text = "vegetables";
            this.vegetablesToolStripMenuItem.Click += new System.EventHandler(this.vegetablesToolStripMenuItem_Click);
            // 
            // menswearToolStripMenuItem
            // 
            this.menswearToolStripMenuItem.Name = "menswearToolStripMenuItem";
            this.menswearToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.menswearToolStripMenuItem.Text = "menswear";
            this.menswearToolStripMenuItem.Click += new System.EventHandler(this.menswearToolStripMenuItem_Click);
            // 
            // womenswearToolStripMenuItem
            // 
            this.womenswearToolStripMenuItem.Name = "womenswearToolStripMenuItem";
            this.womenswearToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.womenswearToolStripMenuItem.Text = "womenswear";
            this.womenswearToolStripMenuItem.Click += new System.EventHandler(this.womenswearToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.toolsToolStripMenuItem.Text = "tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoScroll = true;
            this.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomPanel.Controls.Add(this.simpleButton7);
            this.bottomPanel.Controls.Add(this.simpleButton6);
            this.bottomPanel.Controls.Add(this.simpleButton5);
            this.bottomPanel.Controls.Add(this.simpleButton4);
            this.bottomPanel.Controls.Add(this.simpleButton3);
            this.bottomPanel.Controls.Add(this.simpleButton2);
            this.bottomPanel.Controls.Add(this.simpleButton1);
            this.bottomPanel.Location = new System.Drawing.Point(0, 328);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(754, 402);
            this.bottomPanel.TabIndex = 0;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Appearance.Options.UseTextOptions = true;
            this.simpleButton7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleButton7.BackgroundImage")));
            this.simpleButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton7.Location = new System.Drawing.Point(15, 511);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(205, 200);
            this.simpleButton7.TabIndex = 6;
            this.simpleButton7.Text = "Tools";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Appearance.Options.UseTextOptions = true;
            this.simpleButton6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleButton6.BackgroundImage")));
            this.simpleButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton6.Location = new System.Drawing.Point(515, 260);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(205, 200);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Women\'s Clothing";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseTextOptions = true;
            this.simpleButton5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleButton5.BackgroundImage")));
            this.simpleButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton5.Location = new System.Drawing.Point(265, 260);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(205, 200);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Men\'s Wear";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseTextOptions = true;
            this.simpleButton4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleButton4.BackgroundImage")));
            this.simpleButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton4.Location = new System.Drawing.Point(15, 260);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(205, 200);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Vegetables";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleButton3.BackgroundImage")));
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton3.Location = new System.Drawing.Point(515, 15);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(205, 200);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Fruits";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleButton2.BackgroundImage")));
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.Location = new System.Drawing.Point(265, 15);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(205, 200);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Drinks";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.simpleButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleButton1.BackgroundImage")));
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.Location = new System.Drawing.Point(15, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(205, 200);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Bread";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(754, 731);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bottomPanel);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing_1);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStrip;
        private System.Windows.Forms.ToolStripMenuItem userRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem commonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fruitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vegetablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menswearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem womenswearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.Panel bottomPanel;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}