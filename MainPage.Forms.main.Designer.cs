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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.prdValue = new System.Windows.Forms.TextBox();
            this.reduce = new System.Windows.Forms.Button();
            this.increase = new System.Windows.Forms.Button();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Button();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.hdrProduct = new System.Windows.Forms.Button();
            this.addCommon = new System.Windows.Forms.Button();
            this.addAdmin = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.delUser = new System.Windows.Forms.Button();
            this.newUser = new System.Windows.Forms.Button();
            this.hdrUserOp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlConfirmDelete = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDeleteStockroom = new System.Windows.Forms.ComboBox();
            this.btnDeleteStockroom = new System.Windows.Forms.Button();
            this.deleteStockroom = new System.Windows.Forms.Button();
            this.hdrStockroomOp = new System.Windows.Forms.Button();
            this.addStockroom = new System.Windows.Forms.Button();
            this.refreshStockroom = new System.Windows.Forms.Button();
            this.stockroomBtn4 = new System.Windows.Forms.Button();
            this.stockroomBtn3 = new System.Windows.Forms.Button();
            this.hdrStockroom = new System.Windows.Forms.Button();
            this.stockroomBtn1 = new System.Windows.Forms.Button();
            this.stockroomBtn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.graphButton1 = new System.Windows.Forms.Button();
            this.graphButton2 = new System.Windows.Forms.Button();
            this.graphButton3 = new System.Windows.Forms.Button();
            this.graphButton4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlConfirmDelete.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.refreshTable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCapacity);
            this.panel2.Controls.Add(this.prdValue);
            this.panel2.Controls.Add(this.reduce);
            this.panel2.Controls.Add(this.increase);
            this.panel2.Controls.Add(this.productTable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.addProduct);
            this.panel2.Controls.Add(this.categoryList);
            this.panel2.Controls.Add(this.category);
            this.panel2.Controls.Add(this.deleteProduct);
            this.panel2.Controls.Add(this.hdrProduct);
            this.panel2.Location = new System.Drawing.Point(1245, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1642, 663);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // refreshTable
            // 
            this.refreshTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshTable.BackgroundImage")));
            this.refreshTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshTable.FlatAppearance.BorderSize = 0;
            this.refreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshTable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshTable.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshTable.Location = new System.Drawing.Point(19, 322);
            this.refreshTable.Name = "refreshTable";
            this.refreshTable.Size = new System.Drawing.Size(25, 25);
            this.refreshTable.TabIndex = 24;
            this.refreshTable.UseVisualStyleBackColor = false;
            this.refreshTable.Visible = false;
            this.refreshTable.Click += new System.EventHandler(this.refreshTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(259, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Capacity:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCapacity.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapacity.Location = new System.Drawing.Point(363, 268);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(2, 27);
            this.lblCapacity.TabIndex = 22;
            // 
            // prdValue
            // 
            this.prdValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prdValue.Location = new System.Drawing.Point(19, 556);
            this.prdValue.Name = "prdValue";
            this.prdValue.Size = new System.Drawing.Size(140, 23);
            this.prdValue.TabIndex = 20;
            this.prdValue.Visible = false;
            this.prdValue.TextChanged += new System.EventHandler(this.prdValue_TextChanged);
            this.prdValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prdValue_KeyPress);
            // 
            // reduce
            // 
            this.reduce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.reduce.FlatAppearance.BorderSize = 0;
            this.reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduce.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reduce.ForeColor = System.Drawing.SystemColors.Control;
            this.reduce.Location = new System.Drawing.Point(290, 547);
            this.reduce.Name = "reduce";
            this.reduce.Size = new System.Drawing.Size(100, 40);
            this.reduce.TabIndex = 19;
            this.reduce.Text = "Reduce";
            this.reduce.UseVisualStyleBackColor = false;
            this.reduce.Visible = false;
            this.reduce.Click += new System.EventHandler(this.reduce_Click);
            // 
            // increase
            // 
            this.increase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.increase.FlatAppearance.BorderSize = 0;
            this.increase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.increase.ForeColor = System.Drawing.SystemColors.Control;
            this.increase.Location = new System.Drawing.Point(184, 547);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(100, 40);
            this.increase.TabIndex = 18;
            this.increase.Text = "Increase";
            this.increase.UseVisualStyleBackColor = false;
            this.increase.Visible = false;
            this.increase.Click += new System.EventHandler(this.increase_Click);
            // 
            // productTable
            // 
            this.productTable.AllowUserToAddRows = false;
            this.productTable.AllowUserToDeleteRows = false;
            this.productTable.AllowUserToResizeColumns = false;
            this.productTable.AllowUserToResizeRows = false;
            this.productTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productTable.Location = new System.Drawing.Point(19, 351);
            this.productTable.Name = "productTable";
            this.productTable.ReadOnly = true;
            this.productTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTable.Size = new System.Drawing.Size(371, 189);
            this.productTable.TabIndex = 17;
            this.productTable.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Category:";
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.addProduct.FlatAppearance.BorderSize = 0;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.addProduct.Location = new System.Drawing.Point(19, 187);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(225, 40);
            this.addProduct.TabIndex = 15;
            this.addProduct.Text = "Add New Product";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Visible = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // categoryList
            // 
            this.categoryList.DisplayMember = "as";
            this.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Items.AddRange(new object[] {
            "bread",
            "drinks",
            "fruits",
            "vegetables",
            "menswear",
            "womenswear",
            "tools"});
            this.categoryList.Location = new System.Drawing.Point(19, 127);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(200, 21);
            this.categoryList.TabIndex = 14;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.category.FlatAppearance.BorderSize = 0;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.category.ForeColor = System.Drawing.SystemColors.Control;
            this.category.Location = new System.Drawing.Point(264, 94);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(225, 40);
            this.category.TabIndex = 13;
            this.category.Text = "Product Category";
            this.category.UseVisualStyleBackColor = false;
            this.category.Click += new System.EventHandler(this.category_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.deleteProduct.FlatAppearance.BorderSize = 0;
            this.deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteProduct.Location = new System.Drawing.Point(19, 260);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(225, 40);
            this.deleteProduct.TabIndex = 12;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = false;
            this.deleteProduct.Visible = false;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // hdrProduct
            // 
            this.hdrProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.hdrProduct.FlatAppearance.BorderSize = 0;
            this.hdrProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdrProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hdrProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.hdrProduct.Location = new System.Drawing.Point(19, 11);
            this.hdrProduct.Name = "hdrProduct";
            this.hdrProduct.Size = new System.Drawing.Size(470, 60);
            this.hdrProduct.TabIndex = 11;
            this.hdrProduct.Text = "Product";
            this.hdrProduct.UseVisualStyleBackColor = false;
            // 
            // addCommon
            // 
            this.addCommon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.addCommon.FlatAppearance.BorderSize = 0;
            this.addCommon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCommon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addCommon.ForeColor = System.Drawing.SystemColors.Control;
            this.addCommon.Location = new System.Drawing.Point(140, 556);
            this.addCommon.Name = "addCommon";
            this.addCommon.Size = new System.Drawing.Size(100, 40);
            this.addCommon.TabIndex = 10;
            this.addCommon.Text = "Common";
            this.addCommon.UseVisualStyleBackColor = false;
            this.addCommon.Visible = false;
            this.addCommon.Click += new System.EventHandler(this.addCommon_Click);
            // 
            // addAdmin
            // 
            this.addAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.addAdmin.FlatAppearance.BorderSize = 0;
            this.addAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.addAdmin.Location = new System.Drawing.Point(15, 556);
            this.addAdmin.Name = "addAdmin";
            this.addAdmin.Size = new System.Drawing.Size(100, 40);
            this.addAdmin.TabIndex = 9;
            this.addAdmin.Text = "Admin";
            this.addAdmin.UseVisualStyleBackColor = false;
            this.addAdmin.Visible = false;
            this.addAdmin.Click += new System.EventHandler(this.addAdmin_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(15, 619);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(470, 40);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delUser
            // 
            this.delUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.delUser.FlatAppearance.BorderSize = 0;
            this.delUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delUser.ForeColor = System.Drawing.SystemColors.Control;
            this.delUser.Location = new System.Drawing.Point(260, 500);
            this.delUser.Name = "delUser";
            this.delUser.Size = new System.Drawing.Size(225, 40);
            this.delUser.TabIndex = 7;
            this.delUser.Text = "Delete User";
            this.delUser.UseVisualStyleBackColor = false;
            this.delUser.Click += new System.EventHandler(this.delUser_Click);
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.newUser.FlatAppearance.BorderSize = 0;
            this.newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUser.ForeColor = System.Drawing.SystemColors.Control;
            this.newUser.Location = new System.Drawing.Point(15, 498);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(225, 40);
            this.newUser.TabIndex = 6;
            this.newUser.Text = "New User";
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // hdrUserOp
            // 
            this.hdrUserOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.hdrUserOp.FlatAppearance.BorderSize = 0;
            this.hdrUserOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdrUserOp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hdrUserOp.ForeColor = System.Drawing.SystemColors.Control;
            this.hdrUserOp.Location = new System.Drawing.Point(15, 421);
            this.hdrUserOp.Name = "hdrUserOp";
            this.hdrUserOp.Size = new System.Drawing.Size(470, 60);
            this.hdrUserOp.TabIndex = 5;
            this.hdrUserOp.Text = "User Operations";
            this.hdrUserOp.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnlConfirmDelete);
            this.panel3.Controls.Add(this.deleteStockroom);
            this.panel3.Controls.Add(this.hdrUserOp);
            this.panel3.Controls.Add(this.hdrStockroomOp);
            this.panel3.Controls.Add(this.addCommon);
            this.panel3.Controls.Add(this.addStockroom);
            this.panel3.Controls.Add(this.newUser);
            this.panel3.Controls.Add(this.addAdmin);
            this.panel3.Controls.Add(this.delUser);
            this.panel3.Controls.Add(this.exit);
            this.panel3.Location = new System.Drawing.Point(723, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 663);
            this.panel3.TabIndex = 13;
            // 
            // pnlConfirmDelete
            // 
            this.pnlConfirmDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfirmDelete.Controls.Add(this.txtConfirm);
            this.pnlConfirmDelete.Controls.Add(this.label5);
            this.pnlConfirmDelete.Controls.Add(this.label4);
            this.pnlConfirmDelete.Controls.Add(this.label3);
            this.pnlConfirmDelete.Controls.Add(this.cmbDeleteStockroom);
            this.pnlConfirmDelete.Controls.Add(this.btnDeleteStockroom);
            this.pnlConfirmDelete.Location = new System.Drawing.Point(260, 138);
            this.pnlConfirmDelete.Name = "pnlConfirmDelete";
            this.pnlConfirmDelete.Size = new System.Drawing.Size(225, 277);
            this.pnlConfirmDelete.TabIndex = 25;
            this.pnlConfirmDelete.Visible = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConfirm.Location = new System.Drawing.Point(40, 183);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(145, 23);
            this.txtConfirm.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Please Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-4, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Are you sure you want to delete?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDeleteStockroom
            // 
            this.cmbDeleteStockroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteStockroom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDeleteStockroom.FormattingEnabled = true;
            this.cmbDeleteStockroom.Location = new System.Drawing.Point(3, 21);
            this.cmbDeleteStockroom.Name = "cmbDeleteStockroom";
            this.cmbDeleteStockroom.Size = new System.Drawing.Size(217, 24);
            this.cmbDeleteStockroom.TabIndex = 23;
            this.cmbDeleteStockroom.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteStockroom_SelectedIndexChanged);
            // 
            // btnDeleteStockroom
            // 
            this.btnDeleteStockroom.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStockroom.FlatAppearance.BorderSize = 0;
            this.btnDeleteStockroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStockroom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteStockroom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteStockroom.Location = new System.Drawing.Point(60, 223);
            this.btnDeleteStockroom.Name = "btnDeleteStockroom";
            this.btnDeleteStockroom.Size = new System.Drawing.Size(105, 25);
            this.btnDeleteStockroom.TabIndex = 24;
            this.btnDeleteStockroom.Text = "DELETE";
            this.btnDeleteStockroom.UseVisualStyleBackColor = false;
            this.btnDeleteStockroom.Click += new System.EventHandler(this.btnDeleteStockroom_Click);
            // 
            // deleteStockroom
            // 
            this.deleteStockroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.deleteStockroom.FlatAppearance.BorderSize = 0;
            this.deleteStockroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStockroom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteStockroom.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteStockroom.Location = new System.Drawing.Point(260, 92);
            this.deleteStockroom.Name = "deleteStockroom";
            this.deleteStockroom.Size = new System.Drawing.Size(225, 40);
            this.deleteStockroom.TabIndex = 22;
            this.deleteStockroom.Text = "Delete";
            this.deleteStockroom.UseVisualStyleBackColor = false;
            this.deleteStockroom.Visible = false;
            this.deleteStockroom.Click += new System.EventHandler(this.deleteStockroom_Click);
            // 
            // hdrStockroomOp
            // 
            this.hdrStockroomOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.hdrStockroomOp.FlatAppearance.BorderSize = 0;
            this.hdrStockroomOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdrStockroomOp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hdrStockroomOp.ForeColor = System.Drawing.SystemColors.Control;
            this.hdrStockroomOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hdrStockroomOp.Location = new System.Drawing.Point(15, 11);
            this.hdrStockroomOp.Name = "hdrStockroomOp";
            this.hdrStockroomOp.Size = new System.Drawing.Size(470, 60);
            this.hdrStockroomOp.TabIndex = 15;
            this.hdrStockroomOp.Text = "Stockroom Operations";
            this.hdrStockroomOp.UseVisualStyleBackColor = false;
            // 
            // addStockroom
            // 
            this.addStockroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.addStockroom.FlatAppearance.BorderSize = 0;
            this.addStockroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStockroom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addStockroom.ForeColor = System.Drawing.SystemColors.Control;
            this.addStockroom.Location = new System.Drawing.Point(15, 92);
            this.addStockroom.Name = "addStockroom";
            this.addStockroom.Size = new System.Drawing.Size(225, 40);
            this.addStockroom.TabIndex = 21;
            this.addStockroom.Text = "Add New";
            this.addStockroom.UseVisualStyleBackColor = false;
            this.addStockroom.Click += new System.EventHandler(this.addStockroom_Click);
            // 
            // refreshStockroom
            // 
            this.refreshStockroom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshStockroom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshStockroom.BackgroundImage")));
            this.refreshStockroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshStockroom.FlatAppearance.BorderSize = 0;
            this.refreshStockroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshStockroom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshStockroom.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshStockroom.Location = new System.Drawing.Point(585, 46);
            this.refreshStockroom.Name = "refreshStockroom";
            this.refreshStockroom.Size = new System.Drawing.Size(25, 25);
            this.refreshStockroom.TabIndex = 13;
            this.refreshStockroom.UseVisualStyleBackColor = false;
            this.refreshStockroom.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // stockroomBtn4
            // 
            this.stockroomBtn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.stockroomBtn4.FlatAppearance.BorderSize = 0;
            this.stockroomBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockroomBtn4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockroomBtn4.ForeColor = System.Drawing.SystemColors.Control;
            this.stockroomBtn4.Location = new System.Drawing.Point(354, 187);
            this.stockroomBtn4.Name = "stockroomBtn4";
            this.stockroomBtn4.Size = new System.Drawing.Size(225, 40);
            this.stockroomBtn4.TabIndex = 12;
            this.stockroomBtn4.Text = "4";
            this.stockroomBtn4.UseVisualStyleBackColor = false;
            this.stockroomBtn4.Visible = false;
            this.stockroomBtn4.Click += new System.EventHandler(this.stockroomBtn4_Click);
            // 
            // stockroomBtn3
            // 
            this.stockroomBtn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.stockroomBtn3.FlatAppearance.BorderSize = 0;
            this.stockroomBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockroomBtn3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockroomBtn3.ForeColor = System.Drawing.SystemColors.Control;
            this.stockroomBtn3.Location = new System.Drawing.Point(109, 187);
            this.stockroomBtn3.Name = "stockroomBtn3";
            this.stockroomBtn3.Size = new System.Drawing.Size(225, 40);
            this.stockroomBtn3.TabIndex = 11;
            this.stockroomBtn3.Text = "3";
            this.stockroomBtn3.UseVisualStyleBackColor = false;
            this.stockroomBtn3.Visible = false;
            this.stockroomBtn3.Click += new System.EventHandler(this.stockroomBtn3_Click);
            // 
            // hdrStockroom
            // 
            this.hdrStockroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.hdrStockroom.FlatAppearance.BorderSize = 0;
            this.hdrStockroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hdrStockroom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hdrStockroom.ForeColor = System.Drawing.SystemColors.Control;
            this.hdrStockroom.Location = new System.Drawing.Point(109, 11);
            this.hdrStockroom.Name = "hdrStockroom";
            this.hdrStockroom.Size = new System.Drawing.Size(470, 60);
            this.hdrStockroom.TabIndex = 0;
            this.hdrStockroom.Text = "Stockroom";
            this.hdrStockroom.UseVisualStyleBackColor = false;
            // 
            // stockroomBtn1
            // 
            this.stockroomBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.stockroomBtn1.FlatAppearance.BorderSize = 0;
            this.stockroomBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockroomBtn1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockroomBtn1.ForeColor = System.Drawing.SystemColors.Control;
            this.stockroomBtn1.Location = new System.Drawing.Point(109, 94);
            this.stockroomBtn1.Name = "stockroomBtn1";
            this.stockroomBtn1.Size = new System.Drawing.Size(225, 40);
            this.stockroomBtn1.TabIndex = 3;
            this.stockroomBtn1.Text = "1";
            this.stockroomBtn1.UseVisualStyleBackColor = false;
            this.stockroomBtn1.Visible = false;
            this.stockroomBtn1.Click += new System.EventHandler(this.stockroomBtn1_Click);
            // 
            // stockroomBtn2
            // 
            this.stockroomBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(188)))), ((int)(((byte)(125)))));
            this.stockroomBtn2.FlatAppearance.BorderSize = 0;
            this.stockroomBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockroomBtn2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stockroomBtn2.ForeColor = System.Drawing.SystemColors.Control;
            this.stockroomBtn2.Location = new System.Drawing.Point(354, 94);
            this.stockroomBtn2.Name = "stockroomBtn2";
            this.stockroomBtn2.Size = new System.Drawing.Size(225, 40);
            this.stockroomBtn2.TabIndex = 4;
            this.stockroomBtn2.Text = "2";
            this.stockroomBtn2.UseVisualStyleBackColor = false;
            this.stockroomBtn2.Visible = false;
            this.stockroomBtn2.Click += new System.EventHandler(this.stockroomBtn2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.graphButton4);
            this.panel1.Controls.Add(this.graphButton3);
            this.panel1.Controls.Add(this.graphButton2);
            this.panel1.Controls.Add(this.graphButton1);
            this.panel1.Controls.Add(this.refreshStockroom);
            this.panel1.Controls.Add(this.stockroomBtn4);
            this.panel1.Controls.Add(this.stockroomBtn3);
            this.panel1.Controls.Add(this.hdrStockroom);
            this.panel1.Controls.Add(this.stockroomBtn2);
            this.panel1.Controls.Add(this.stockroomBtn1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 663);
            this.panel1.TabIndex = 14;
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // graphButton1
            // 
            this.graphButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.graphButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphButton1.Location = new System.Drawing.Point(18, 290);
            this.graphButton1.Name = "graphButton1";
            this.graphButton1.Size = new System.Drawing.Size(220, 60);
            this.graphButton1.TabIndex = 18;
            this.graphButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphButton1.UseVisualStyleBackColor = false;
            this.graphButton1.Visible = false;
            // 
            // graphButton2
            // 
            this.graphButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.graphButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphButton2.Location = new System.Drawing.Point(18, 390);
            this.graphButton2.Name = "graphButton2";
            this.graphButton2.Size = new System.Drawing.Size(220, 60);
            this.graphButton2.TabIndex = 19;
            this.graphButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphButton2.UseVisualStyleBackColor = false;
            this.graphButton2.Visible = false;
            // 
            // graphButton3
            // 
            this.graphButton3.BackColor = System.Drawing.Color.DarkKhaki;
            this.graphButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphButton3.Location = new System.Drawing.Point(18, 490);
            this.graphButton3.Name = "graphButton3";
            this.graphButton3.Size = new System.Drawing.Size(220, 60);
            this.graphButton3.TabIndex = 20;
            this.graphButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphButton3.UseVisualStyleBackColor = false;
            this.graphButton3.Visible = false;
            // 
            // graphButton4
            // 
            this.graphButton4.BackColor = System.Drawing.Color.DarkSalmon;
            this.graphButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphButton4.Location = new System.Drawing.Point(18, 590);
            this.graphButton4.Name = "graphButton4";
            this.graphButton4.Size = new System.Drawing.Size(220, 60);
            this.graphButton4.TabIndex = 21;
            this.graphButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphButton4.UseVisualStyleBackColor = false;
            this.graphButton4.Visible = false;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1234, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing_1);
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlConfirmDelete.ResumeLayout(false);
            this.pnlConfirmDelete.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hdrUserOp;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delUser;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button addCommon;
        private System.Windows.Forms.Button addAdmin;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button hdrProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button hdrStockroom;
        private System.Windows.Forms.Button stockroomBtn1;
        private System.Windows.Forms.Button stockroomBtn2;
        private System.Windows.Forms.Button category;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productTable;
        private System.Windows.Forms.Button reduce;
        private System.Windows.Forms.Button increase;
        private System.Windows.Forms.TextBox prdValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button hdrStockroomOp;
        private System.Windows.Forms.Button addStockroom;
        private System.Windows.Forms.Button stockroomBtn4;
        private System.Windows.Forms.Button stockroomBtn3;
        private System.Windows.Forms.Button refreshStockroom;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteStockroom;
        private System.Windows.Forms.Button btnDeleteStockroom;
        private System.Windows.Forms.ComboBox cmbDeleteStockroom;
        private System.Windows.Forms.Panel pnlConfirmDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button refreshTable;
        private System.Windows.Forms.Button graphButton4;
        private System.Windows.Forms.Button graphButton3;
        private System.Windows.Forms.Button graphButton2;
        private System.Windows.Forms.Button graphButton1;
    }
}