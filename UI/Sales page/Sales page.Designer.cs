namespace UI.Sales_page
{
    partial class Sales_Page
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_item_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_add_name = new System.Windows.Forms.TextBox();
            this.tb_reshow_order = new System.Windows.Forms.TextBox();
            this.bt_reshow_order = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.bt_add_name = new System.Windows.Forms.Button();
            this.bt_add_id = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_add_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_item_description = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_item_price = new System.Windows.Forms.TextBox();
            this.chb_item_large = new System.Windows.Forms.CheckBox();
            this.tb_item_name = new System.Windows.Forms.TextBox();
            this.chb_item_install = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_save = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_reveived = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_paid = new System.Windows.Forms.Label();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_deposit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_change = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_epay = new System.Windows.Forms.Button();
            this.bt_cash = new System.Windows.Forms.Button();
            this.tb_charge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bt_remove_item = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.myProfileToolStripMenuItem,
            this.salesManagementToolStripMenuItem,
            this.returnOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // salesManagementToolStripMenuItem
            // 
            this.salesManagementToolStripMenuItem.Name = "salesManagementToolStripMenuItem";
            this.salesManagementToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.salesManagementToolStripMenuItem.Text = "Sales Management";
            // 
            // returnOrderToolStripMenuItem
            // 
            this.returnOrderToolStripMenuItem.Name = "returnOrderToolStripMenuItem";
            this.returnOrderToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.returnOrderToolStripMenuItem.Text = "Return Order";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_remove_item);
            this.panel1.Controls.Add(this.lv_item_list);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 426);
            this.panel1.TabIndex = 1;
            // 
            // lv_item_list
            // 
            this.lv_item_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lv_item_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.lv_item_list.FullRowSelect = true;
            this.lv_item_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_item_list.HideSelection = false;
            this.lv_item_list.Location = new System.Drawing.Point(3, 22);
            this.lv_item_list.Name = "lv_item_list";
            this.lv_item_list.ShowGroups = false;
            this.lv_item_list.Size = new System.Drawing.Size(261, 372);
            this.lv_item_list.TabIndex = 1;
            this.lv_item_list.UseCompatibleStateImageBehavior = false;
            this.lv_item_list.View = System.Windows.Forms.View.Details;
            this.lv_item_list.SelectedIndexChanged += new System.EventHandler(this.lv_item_list_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.08511F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.91489F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 234);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_add_name);
            this.groupBox3.Controls.Add(this.tb_reshow_order);
            this.groupBox3.Controls.Add(this.bt_reshow_order);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.bt_add_name);
            this.groupBox3.Controls.Add(this.bt_add_id);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_add_id);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 228);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual entry";
            // 
            // tb_add_name
            // 
            this.tb_add_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_add_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_add_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_add_name.Location = new System.Drawing.Point(9, 107);
            this.tb_add_name.Name = "tb_add_name";
            this.tb_add_name.Size = new System.Drawing.Size(207, 22);
            this.tb_add_name.TabIndex = 10;
            this.tb_add_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_add_name_KeyUp);
            // 
            // tb_reshow_order
            // 
            this.tb_reshow_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_reshow_order.Location = new System.Drawing.Point(9, 173);
            this.tb_reshow_order.Name = "tb_reshow_order";
            this.tb_reshow_order.Size = new System.Drawing.Size(207, 22);
            this.tb_reshow_order.TabIndex = 9;
            this.tb_reshow_order.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_reshow_order_KeyUp);
            // 
            // bt_reshow_order
            // 
            this.bt_reshow_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reshow_order.Location = new System.Drawing.Point(124, 200);
            this.bt_reshow_order.Name = "bt_reshow_order";
            this.bt_reshow_order.Size = new System.Drawing.Size(92, 23);
            this.bt_reshow_order.TabIndex = 8;
            this.bt_reshow_order.Text = "Re-show order";
            this.bt_reshow_order.UseVisualStyleBackColor = true;
            this.bt_reshow_order.Click += new System.EventHandler(this.bt_reshow_order_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 7;
            this.label15.Text = "Order ID";
            // 
            // bt_add_name
            // 
            this.bt_add_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add_name.Location = new System.Drawing.Point(124, 133);
            this.bt_add_name.Name = "bt_add_name";
            this.bt_add_name.Size = new System.Drawing.Size(92, 23);
            this.bt_add_name.TabIndex = 5;
            this.bt_add_name.Text = "Add by Name";
            this.bt_add_name.UseVisualStyleBackColor = true;
            this.bt_add_name.Click += new System.EventHandler(this.bt_add_name_Click);
            // 
            // bt_add_id
            // 
            this.bt_add_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add_id.Location = new System.Drawing.Point(124, 66);
            this.bt_add_id.Name = "bt_add_id";
            this.bt_add_id.Size = new System.Drawing.Size(92, 23);
            this.bt_add_id.TabIndex = 4;
            this.bt_add_id.Text = "Add by Code";
            this.bt_add_id.UseVisualStyleBackColor = true;
            this.bt_add_id.Click += new System.EventHandler(this.bt_add_id_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Name";
            // 
            // tb_add_id
            // 
            this.tb_add_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_add_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_add_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_add_id.Location = new System.Drawing.Point(9, 38);
            this.tb_add_id.Name = "tb_add_id";
            this.tb_add_id.Size = new System.Drawing.Size(207, 22);
            this.tb_add_id.TabIndex = 2;
            this.tb_add_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_add_id_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Code";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_item_description);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tb_item_price);
            this.groupBox4.Controls.Add(this.chb_item_large);
            this.groupBox4.Controls.Add(this.tb_item_name);
            this.groupBox4.Controls.Add(this.chb_item_install);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(231, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 228);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item Info";
            // 
            // tb_item_description
            // 
            this.tb_item_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_item_description.BackColor = System.Drawing.SystemColors.Info;
            this.tb_item_description.Location = new System.Drawing.Point(12, 114);
            this.tb_item_description.Name = "tb_item_description";
            this.tb_item_description.ReadOnly = true;
            this.tb_item_description.Size = new System.Drawing.Size(278, 103);
            this.tb_item_description.TabIndex = 8;
            this.tb_item_description.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Item Name";
            // 
            // tb_item_price
            // 
            this.tb_item_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_item_price.BackColor = System.Drawing.SystemColors.Info;
            this.tb_item_price.Location = new System.Drawing.Point(76, 44);
            this.tb_item_price.Name = "tb_item_price";
            this.tb_item_price.ReadOnly = true;
            this.tb_item_price.Size = new System.Drawing.Size(214, 22);
            this.tb_item_price.TabIndex = 4;
            // 
            // chb_item_large
            // 
            this.chb_item_large.AutoCheck = false;
            this.chb_item_large.AutoSize = true;
            this.chb_item_large.Location = new System.Drawing.Point(76, 77);
            this.chb_item_large.Name = "chb_item_large";
            this.chb_item_large.Size = new System.Drawing.Size(74, 16);
            this.chb_item_large.TabIndex = 5;
            this.chb_item_large.Text = "Large item";
            this.chb_item_large.UseVisualStyleBackColor = true;
            // 
            // tb_item_name
            // 
            this.tb_item_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_item_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_item_name.Location = new System.Drawing.Point(76, 16);
            this.tb_item_name.Name = "tb_item_name";
            this.tb_item_name.ReadOnly = true;
            this.tb_item_name.Size = new System.Drawing.Size(214, 22);
            this.tb_item_name.TabIndex = 1;
            // 
            // chb_item_install
            // 
            this.chb_item_install.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_item_install.AutoCheck = false;
            this.chb_item_install.AutoSize = true;
            this.chb_item_install.Location = new System.Drawing.Point(189, 77);
            this.chb_item_install.Name = "chb_item_install";
            this.chb_item_install.Size = new System.Drawing.Size(101, 16);
            this.chb_item_install.TabIndex = 6;
            this.chb_item_install.Text = "Need install item";
            this.chb_item_install.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Item Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lb_save);
            this.groupBox2.Controls.Add(this.tb_total);
            this.groupBox2.Controls.Add(this.tb_reveived);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lb_paid);
            this.groupBox2.Controls.Add(this.tb_subtotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_discount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total";
            // 
            // lb_save
            // 
            this.lb_save.AutoSize = true;
            this.lb_save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_save.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_save.Location = new System.Drawing.Point(64, 143);
            this.lb_save.Name = "lb_save";
            this.lb_save.Size = new System.Drawing.Size(94, 21);
            this.lb_save.TabIndex = 9;
            this.lb_save.Text = "Order Save";
            this.lb_save.Visible = false;
            // 
            // tb_total
            // 
            this.tb_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_total.BackColor = System.Drawing.SystemColors.Info;
            this.tb_total.Location = new System.Drawing.Point(61, 112);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(97, 22);
            this.tb_total.TabIndex = 9;
            // 
            // tb_reveived
            // 
            this.tb_reveived.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_reveived.BackColor = System.Drawing.SystemColors.Info;
            this.tb_reveived.Location = new System.Drawing.Point(61, 81);
            this.tb_reveived.Name = "tb_reveived";
            this.tb_reveived.ReadOnly = true;
            this.tb_reveived.Size = new System.Drawing.Size(97, 22);
            this.tb_reveived.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "Received";
            // 
            // lb_paid
            // 
            this.lb_paid.AutoSize = true;
            this.lb_paid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_paid.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_paid.Location = new System.Drawing.Point(10, 144);
            this.lb_paid.Name = "lb_paid";
            this.lb_paid.Size = new System.Drawing.Size(43, 21);
            this.lb_paid.TabIndex = 6;
            this.lb_paid.Text = "Paid";
            this.lb_paid.Visible = false;
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_subtotal.BackColor = System.Drawing.SystemColors.Info;
            this.tb_subtotal.Location = new System.Drawing.Point(61, 19);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.ReadOnly = true;
            this.tb_subtotal.Size = new System.Drawing.Size(97, 22);
            this.tb_subtotal.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "Subtotal";
            // 
            // tb_discount
            // 
            this.tb_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_discount.BackColor = System.Drawing.SystemColors.Info;
            this.tb_discount.Location = new System.Drawing.Point(61, 50);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.ReadOnly = true;
            this.tb_discount.Size = new System.Drawing.Size(97, 22);
            this.tb_discount.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Discount";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(264, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(536, 426);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.26415F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.73585F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(530, 180);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.tb_deposit);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tb_change);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.bt_epay);
            this.groupBox1.Controls.Add(this.bt_cash);
            this.groupBox1.Controls.Add(this.tb_charge);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(173, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Collection";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 144);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(91, 23);
            this.bt_save.TabIndex = 10;
            this.bt_save.Text = "Save Order";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_deposit
            // 
            this.tb_deposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_deposit.BackColor = System.Drawing.SystemColors.Info;
            this.tb_deposit.Location = new System.Drawing.Point(150, 51);
            this.tb_deposit.Name = "tb_deposit";
            this.tb_deposit.ReadOnly = true;
            this.tb_deposit.Size = new System.Drawing.Size(174, 22);
            this.tb_deposit.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "If only  pay deposit amount";
            // 
            // tb_change
            // 
            this.tb_change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_change.BackColor = System.Drawing.SystemColors.Info;
            this.tb_change.Location = new System.Drawing.Point(150, 81);
            this.tb_change.Name = "tb_change";
            this.tb_change.ReadOnly = true;
            this.tb_change.Size = new System.Drawing.Size(174, 22);
            this.tb_change.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Change amount";
            // 
            // bt_epay
            // 
            this.bt_epay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_epay.Location = new System.Drawing.Point(255, 144);
            this.bt_epay.Name = "bt_epay";
            this.bt_epay.Size = new System.Drawing.Size(93, 23);
            this.bt_epay.TabIndex = 3;
            this.bt_epay.Text = "Use e-payment";
            this.bt_epay.UseVisualStyleBackColor = true;
            this.bt_epay.Click += new System.EventHandler(this.bt_epay_Click);
            // 
            // bt_cash
            // 
            this.bt_cash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cash.Location = new System.Drawing.Point(158, 144);
            this.bt_cash.Name = "bt_cash";
            this.bt_cash.Size = new System.Drawing.Size(91, 23);
            this.bt_cash.TabIndex = 2;
            this.bt_cash.Text = "Use Cash";
            this.bt_cash.UseVisualStyleBackColor = true;
            this.bt_cash.Click += new System.EventHandler(this.bt_cash_Click);
            // 
            // tb_charge
            // 
            this.tb_charge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_charge.Location = new System.Drawing.Point(150, 19);
            this.tb_charge.Name = "tb_charge";
            this.tb_charge.Size = new System.Drawing.Size(174, 22);
            this.tb_charge.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Charge amount";
            // 
            // bt_remove_item
            // 
            this.bt_remove_item.Location = new System.Drawing.Point(3, 400);
            this.bt_remove_item.Name = "bt_remove_item";
            this.bt_remove_item.Size = new System.Drawing.Size(261, 23);
            this.bt_remove_item.TabIndex = 2;
            this.bt_remove_item.Text = "Remove select item";
            this.bt_remove_item.UseVisualStyleBackColor = true;
            // 
            // Sales_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Sales_Page";
            this.Text = "Sales Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sales_Page_FormClosed);
            this.Load += new System.EventHandler(this.Sales_Page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesManagementToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox tb_item_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_item_name;
        private System.Windows.Forms.CheckBox chb_item_install;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chb_item_large;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_item_price;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_add_name;
        private System.Windows.Forms.Button bt_add_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_add_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_epay;
        private System.Windows.Forms.Button bt_cash;
        private System.Windows.Forms.TextBox tb_charge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_reveived;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label lb_save;
        private System.Windows.Forms.TextBox tb_deposit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_paid;
        private System.Windows.Forms.TextBox tb_change;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem returnOrderToolStripMenuItem;
        private System.Windows.Forms.ListView lv_item_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tb_reshow_order;
        private System.Windows.Forms.Button bt_reshow_order;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tb_add_name;
        private System.Windows.Forms.Button bt_remove_item;
    }
}