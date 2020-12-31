namespace StokOtomasyonu
{
    partial class graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graph));
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.byCategory = new System.Windows.Forms.Button();
            this.byProduct = new System.Windows.Forms.Button();
            this.sortButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sortButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.sortButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.sortButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.sortButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.sortButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sortButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(0, 113);
            this.chartControl.Name = "chartControl";
            this.chartControl.PaletteName = "Concourse";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.Size = new System.Drawing.Size(827, 524);
            this.chartControl.TabIndex = 1;
            // 
            // byCategory
            // 
            this.byCategory.BackColor = System.Drawing.Color.RoyalBlue;
            this.byCategory.FlatAppearance.BorderSize = 0;
            this.byCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byCategory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.byCategory.Location = new System.Drawing.Point(29, 31);
            this.byCategory.Name = "byCategory";
            this.byCategory.Size = new System.Drawing.Size(125, 50);
            this.byCategory.TabIndex = 2;
            this.byCategory.Text = "Sort by Category";
            this.byCategory.UseVisualStyleBackColor = false;
            this.byCategory.Click += new System.EventHandler(this.byCategory_Click);
            // 
            // byProduct
            // 
            this.byProduct.BackColor = System.Drawing.Color.RoyalBlue;
            this.byProduct.FlatAppearance.BorderSize = 0;
            this.byProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.byProduct.Location = new System.Drawing.Point(206, 31);
            this.byProduct.Name = "byProduct";
            this.byProduct.Size = new System.Drawing.Size(125, 50);
            this.byProduct.TabIndex = 3;
            this.byProduct.Text = "Sort by Product";
            this.byProduct.UseVisualStyleBackColor = false;
            this.byProduct.Click += new System.EventHandler(this.byProduct_Click);
            // 
            // sortButton2
            // 
            this.sortButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortButton2.Appearance.Options.UseFont = true;
            this.sortButton2.Appearance.Options.UseTextOptions = true;
            this.sortButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sortButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton2.BackgroundImage")));
            this.sortButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sortButton2.Location = new System.Drawing.Point(409, 59);
            this.sortButton2.Name = "sortButton2";
            this.sortButton2.Size = new System.Drawing.Size(55, 50);
            this.sortButton2.TabIndex = 13;
            this.sortButton2.Text = "Tools";
            this.sortButton2.Visible = false;
            this.sortButton2.Click += new System.EventHandler(this.sortButton2_Click);
            // 
            // sortButton6
            // 
            this.sortButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortButton6.Appearance.Options.UseFont = true;
            this.sortButton6.Appearance.Options.UseTextOptions = true;
            this.sortButton6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sortButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton6.BackgroundImage")));
            this.sortButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sortButton6.Location = new System.Drawing.Point(570, 59);
            this.sortButton6.Name = "sortButton6";
            this.sortButton6.Size = new System.Drawing.Size(55, 50);
            this.sortButton6.TabIndex = 12;
            this.sortButton6.Text = "Womens Wear";
            this.sortButton6.Visible = false;
            this.sortButton6.Click += new System.EventHandler(this.sortButton6_Click);
            // 
            // sortButton5
            // 
            this.sortButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortButton5.Appearance.Options.UseFont = true;
            this.sortButton5.Appearance.Options.UseTextOptions = true;
            this.sortButton5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sortButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton5.BackgroundImage")));
            this.sortButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sortButton5.Location = new System.Drawing.Point(570, 3);
            this.sortButton5.Name = "sortButton5";
            this.sortButton5.Size = new System.Drawing.Size(55, 50);
            this.sortButton5.TabIndex = 11;
            this.sortButton5.Text = "Mens Wear";
            this.sortButton5.Visible = false;
            this.sortButton5.Click += new System.EventHandler(this.sortButton5_Click);
            // 
            // sortButton4
            // 
            this.sortButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortButton4.Appearance.Options.UseFont = true;
            this.sortButton4.Appearance.Options.UseTextOptions = true;
            this.sortButton4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sortButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton4.BackgroundImage")));
            this.sortButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sortButton4.Location = new System.Drawing.Point(489, 59);
            this.sortButton4.Name = "sortButton4";
            this.sortButton4.Size = new System.Drawing.Size(55, 50);
            this.sortButton4.TabIndex = 10;
            this.sortButton4.Text = "Vegetables";
            this.sortButton4.Visible = false;
            this.sortButton4.Click += new System.EventHandler(this.sortButton4_Click);
            // 
            // sortButton7
            // 
            this.sortButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortButton7.Appearance.Options.UseFont = true;
            this.sortButton7.Appearance.Options.UseTextOptions = true;
            this.sortButton7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sortButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton7.BackgroundImage")));
            this.sortButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sortButton7.Location = new System.Drawing.Point(647, 31);
            this.sortButton7.Name = "sortButton7";
            this.sortButton7.Size = new System.Drawing.Size(55, 50);
            this.sortButton7.TabIndex = 9;
            this.sortButton7.Text = "Fruits";
            this.sortButton7.Visible = false;
            this.sortButton7.Click += new System.EventHandler(this.sortButton7_Click);
            // 
            // sortButton1
            // 
            this.sortButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortButton1.Appearance.Options.UseFont = true;
            this.sortButton1.Appearance.Options.UseTextOptions = true;
            this.sortButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sortButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton1.BackgroundImage")));
            this.sortButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sortButton1.Location = new System.Drawing.Point(409, 3);
            this.sortButton1.Name = "sortButton1";
            this.sortButton1.Size = new System.Drawing.Size(55, 50);
            this.sortButton1.TabIndex = 8;
            this.sortButton1.Text = "Drinks";
            this.sortButton1.Visible = false;
            this.sortButton1.Click += new System.EventHandler(this.sortButton1_Click);
            // 
            // sortButton3
            // 
            this.sortButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortButton3.Appearance.Options.UseFont = true;
            this.sortButton3.Appearance.Options.UseTextOptions = true;
            this.sortButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sortButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortButton3.BackgroundImage")));
            this.sortButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sortButton3.Location = new System.Drawing.Point(489, 3);
            this.sortButton3.Name = "sortButton3";
            this.sortButton3.Size = new System.Drawing.Size(55, 50);
            this.sortButton3.TabIndex = 7;
            this.sortButton3.Text = "Bread";
            this.sortButton3.Visible = false;
            this.sortButton3.Click += new System.EventHandler(this.sortButton3_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(781, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 35);
            this.exitButton.TabIndex = 14;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 638);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sortButton2);
            this.Controls.Add(this.sortButton6);
            this.Controls.Add(this.sortButton5);
            this.Controls.Add(this.sortButton4);
            this.Controls.Add(this.sortButton7);
            this.Controls.Add(this.sortButton1);
            this.Controls.Add(this.sortButton3);
            this.Controls.Add(this.byProduct);
            this.Controls.Add(this.byCategory);
            this.Controls.Add(this.chartControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl;
        private System.Windows.Forms.Button byCategory;
        private System.Windows.Forms.Button byProduct;
        private DevExpress.XtraEditors.SimpleButton sortButton2;
        private DevExpress.XtraEditors.SimpleButton sortButton6;
        private DevExpress.XtraEditors.SimpleButton sortButton5;
        private DevExpress.XtraEditors.SimpleButton sortButton4;
        private DevExpress.XtraEditors.SimpleButton sortButton7;
        private DevExpress.XtraEditors.SimpleButton sortButton1;
        private DevExpress.XtraEditors.SimpleButton sortButton3;
        private System.Windows.Forms.Button exitButton;
    }
}