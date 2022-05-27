namespace UI.IT
{
    partial class Account_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Management));
            this.dataGrid_staffList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_reset_pass = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.cb_is_manager = new System.Windows.Forms.CheckBox();
            this.cb_enable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_full_name = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_staff = new System.Data.DataSet();
            this.MoveFirst = new System.Windows.Forms.ToolStripButton();
            this.MovePrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNext = new System.Windows.Forms.ToolStripButton();
            this.MoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Create_account = new System.Windows.Forms.ToolStripButton();
            this.bt_del_account = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_serach = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cb_filter_department = new System.Windows.Forms.ToolStripComboBox();
            this.cb_Filter_isManager = new System.Windows.Forms.ToolStripComboBox();
            this.cb_Filter_Enable = new System.Windows.Forms.ToolStripComboBox();
            this.adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_staffList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_staffList
            // 
            this.dataGrid_staffList.AllowUserToAddRows = false;
            this.dataGrid_staffList.AllowUserToDeleteRows = false;
            this.dataGrid_staffList.AllowUserToOrderColumns = true;
            this.dataGrid_staffList.AllowUserToResizeColumns = false;
            this.dataGrid_staffList.AllowUserToResizeRows = false;
            this.dataGrid_staffList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_staffList.Location = new System.Drawing.Point(12, 56);
            this.dataGrid_staffList.Name = "dataGrid_staffList";
            this.dataGrid_staffList.ReadOnly = true;
            this.dataGrid_staffList.RowTemplate.Height = 24;
            this.dataGrid_staffList.Size = new System.Drawing.Size(776, 262);
            this.dataGrid_staffList.TabIndex = 0;
            this.dataGrid_staffList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGrid_staffList_DataError);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account detail";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 93);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_reset_pass);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cb_department);
            this.panel2.Controls.Add(this.cb_is_manager);
            this.panel2.Controls.Add(this.cb_enable);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bt_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(388, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 87);
            this.panel2.TabIndex = 23;
            // 
            // bt_reset_pass
            // 
            this.bt_reset_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reset_pass.Location = new System.Drawing.Point(77, 31);
            this.bt_reset_pass.Name = "bt_reset_pass";
            this.bt_reset_pass.Size = new System.Drawing.Size(227, 23);
            this.bt_reset_pass.TabIndex = 18;
            this.bt_reset_pass.Text = "Reset password";
            this.bt_reset_pass.UseVisualStyleBackColor = true;
            this.bt_reset_pass.Click += new System.EventHandler(this.bt_reset_pass_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Department";
            // 
            // cb_department
            // 
            this.cb_department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "Sales",
            "Inventory",
            "Accounting",
            "Technical Support",
            "IT",
            "CEO",
            "Delivery Team",
            "Installer"});
            this.cb_department.Location = new System.Drawing.Point(78, 5);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(298, 20);
            this.cb_department.TabIndex = 13;
            this.cb_department.SelectedIndexChanged += new System.EventHandler(this.tb_department_SelectedIndexChanged);
            // 
            // cb_is_manager
            // 
            this.cb_is_manager.AutoSize = true;
            this.cb_is_manager.Location = new System.Drawing.Point(78, 63);
            this.cb_is_manager.Name = "cb_is_manager";
            this.cb_is_manager.Size = new System.Drawing.Size(130, 16);
            this.cb_is_manager.TabIndex = 15;
            this.cb_is_manager.Text = "Is department manager";
            this.cb_is_manager.UseVisualStyleBackColor = true;
            // 
            // cb_enable
            // 
            this.cb_enable.AutoSize = true;
            this.cb_enable.Location = new System.Drawing.Point(214, 65);
            this.cb_enable.Name = "cb_enable";
            this.cb_enable.Size = new System.Drawing.Size(56, 16);
            this.cb_enable.TabIndex = 12;
            this.cb_enable.Text = "Enable";
            this.cb_enable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.Location = new System.Drawing.Point(301, 63);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 16;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_full_name);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 87);
            this.panel1.TabIndex = 22;
            // 
            // tb_id
            // 
            this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_id.BackColor = System.Drawing.SystemColors.Info;
            this.tb_id.Location = new System.Drawing.Point(86, 61);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(274, 22);
            this.tb_id.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Full Real Name";
            // 
            // tb_full_name
            // 
            this.tb_full_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_full_name.Location = new System.Drawing.Point(86, 3);
            this.tb_full_name.MaxLength = 20;
            this.tb_full_name.Name = "tb_full_name";
            this.tb_full_name.Size = new System.Drawing.Size(274, 22);
            this.tb_full_name.TabIndex = 10;
            this.tb_full_name.TextChanged += new System.EventHandler(this.Change_back_normal);
            this.tb_full_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            this.tb_full_name.Validated += new System.EventHandler(this.tb_Validated);
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.Location = new System.Drawing.Point(86, 33);
            this.tb_username.MaxLength = 10;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(274, 22);
            this.tb_username.TabIndex = 11;
            this.tb_username.TextChanged += new System.EventHandler(this.Change_back_normal);
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            this.tb_username.Validated += new System.EventHandler(this.tb_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.myProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirst,
            this.MovePrevious,
            this.bindingNavigatorSeparator,
            this.MoveNext,
            this.MoveLast,
            this.bindingNavigatorSeparator2,
            this.Create_account,
            this.bt_del_account,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tb_serach,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.cb_filter_department,
            this.cb_Filter_isManager,
            this.cb_Filter_Enable});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.MoveFirst;
            this.bindingNavigator1.MoveLastItem = this.MoveLast;
            this.bindingNavigator1.MoveNextItem = this.MoveNext;
            this.bindingNavigator1.MovePreviousItem = this.MovePrevious;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.ds_staff;
            this.bindingSource1.Position = 0;
            // 
            // ds_staff
            // 
            this.ds_staff.DataSetName = "NewDataSet";
            // 
            // MoveFirst
            // 
            this.MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("MoveFirst.Image")));
            this.MoveFirst.Name = "MoveFirst";
            this.MoveFirst.RightToLeftAutoMirrorImage = true;
            this.MoveFirst.Size = new System.Drawing.Size(23, 22);
            this.MoveFirst.Text = "移到最前面";
            // 
            // MovePrevious
            // 
            this.MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("MovePrevious.Image")));
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.RightToLeftAutoMirrorImage = true;
            this.MovePrevious.Size = new System.Drawing.Size(23, 22);
            this.MovePrevious.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // MoveNext
            // 
            this.MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveNext.Image = ((System.Drawing.Image)(resources.GetObject("MoveNext.Image")));
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.RightToLeftAutoMirrorImage = true;
            this.MoveNext.Size = new System.Drawing.Size(23, 22);
            this.MoveNext.Text = "移到下一個";
            // 
            // MoveLast
            // 
            this.MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLast.Image = ((System.Drawing.Image)(resources.GetObject("MoveLast.Image")));
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.RightToLeftAutoMirrorImage = true;
            this.MoveLast.Size = new System.Drawing.Size(23, 22);
            this.MoveLast.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Create_account
            // 
            this.Create_account.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Create_account.Image = ((System.Drawing.Image)(resources.GetObject("Create_account.Image")));
            this.Create_account.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.Create_account.Name = "Create_account";
            this.Create_account.RightToLeftAutoMirrorImage = true;
            this.Create_account.Size = new System.Drawing.Size(23, 22);
            this.Create_account.Text = "加入新的";
            this.Create_account.Click += new System.EventHandler(this.Create_account_Click);
            // 
            // bt_del_account
            // 
            this.bt_del_account.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_del_account.Image = ((System.Drawing.Image)(resources.GetObject("bt_del_account.Image")));
            this.bt_del_account.Name = "bt_del_account";
            this.bt_del_account.RightToLeftAutoMirrorImage = true;
            this.bt_del_account.Size = new System.Drawing.Size(23, 22);
            this.bt_del_account.Text = "刪除";
            this.bt_del_account.Click += new System.EventHandler(this.bt_del_account_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // tb_serach
            // 
            this.tb_serach.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.tb_serach.Name = "tb_serach";
            this.tb_serach.Size = new System.Drawing.Size(100, 25);
            this.tb_serach.TextChanged += new System.EventHandler(this.Search_change);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "Filter:";
            // 
            // cb_filter_department
            // 
            this.cb_filter_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter_department.Items.AddRange(new object[] {
            "(All  department)",
            "Sales",
            "Inventory",
            "Accounting",
            "Technical Support",
            "IT",
            "CEO",
            "Delivery Team",
            "Installer"});
            this.cb_filter_department.Name = "cb_filter_department";
            this.cb_filter_department.Size = new System.Drawing.Size(121, 25);
            this.cb_filter_department.SelectedIndexChanged += new System.EventHandler(this.Search_change);
            // 
            // cb_Filter_isManager
            // 
            this.cb_Filter_isManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter_isManager.Items.AddRange(new object[] {
            "(All staff)",
            "Is manager",
            "Is not manager"});
            this.cb_Filter_isManager.Name = "cb_Filter_isManager";
            this.cb_Filter_isManager.Size = new System.Drawing.Size(121, 25);
            this.cb_Filter_isManager.SelectedIndexChanged += new System.EventHandler(this.Search_change);
            // 
            // cb_Filter_Enable
            // 
            this.cb_Filter_Enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter_Enable.Items.AddRange(new object[] {
            "(All account)",
            "Is enable account",
            "Is not enable account"});
            this.cb_Filter_Enable.Name = "cb_Filter_Enable";
            this.cb_Filter_Enable.Size = new System.Drawing.Size(121, 25);
            this.cb_Filter_Enable.SelectedIndexChanged += new System.EventHandler(this.Search_change);
            // 
            // adapter
            // 
            this.adapter.DeleteCommand = null;
            this.adapter.InsertCommand = null;
            this.adapter.SelectCommand = null;
            this.adapter.UpdateCommand = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Account_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGrid_staffList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Account_Management";
            this.Text = "Account Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Account_Management_FormClosed);
            this.Load += new System.EventHandler(this.Account_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_staffList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_staffList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.CheckBox cb_enable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_full_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_is_manager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bt_del_account;
        private System.Windows.Forms.ToolStripButton MoveFirst;
        private System.Windows.Forms.ToolStripButton MovePrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton MoveNext;
        private System.Windows.Forms.ToolStripButton MoveLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_serach;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton Create_account;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlDataAdapter adapter;
        private System.Data.DataSet ds_staff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cb_Filter_isManager;
        private System.Windows.Forms.ToolStripComboBox cb_Filter_Enable;
        private System.Windows.Forms.ToolStripComboBox cb_filter_department;
        private System.Windows.Forms.Button bt_reset_pass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}