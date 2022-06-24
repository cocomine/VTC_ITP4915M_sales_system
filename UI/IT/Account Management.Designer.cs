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
            resources.ApplyResources(this.dataGrid_staffList, "dataGrid_staffList");
            this.dataGrid_staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_staffList.Name = "dataGrid_staffList";
            this.dataGrid_staffList.ReadOnly = true;
            this.dataGrid_staffList.RowTemplate.Height = 24;
            this.dataGrid_staffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_staffList.ShowEditingIcon = false;
            this.dataGrid_staffList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGrid_staffList_DataError);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // bt_reset_pass
            // 
            resources.ApplyResources(this.bt_reset_pass, "bt_reset_pass");
            this.bt_reset_pass.Name = "bt_reset_pass";
            this.bt_reset_pass.UseVisualStyleBackColor = true;
            this.bt_reset_pass.Click += new System.EventHandler(this.bt_reset_pass_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cb_department
            // 
            resources.ApplyResources(this.cb_department, "cb_department");
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            resources.GetString("cb_department.Items"),
            resources.GetString("cb_department.Items1"),
            resources.GetString("cb_department.Items2"),
            resources.GetString("cb_department.Items3"),
            resources.GetString("cb_department.Items4"),
            resources.GetString("cb_department.Items5"),
            resources.GetString("cb_department.Items6"),
            resources.GetString("cb_department.Items7")});
            this.cb_department.Name = "cb_department";
            this.cb_department.SelectedIndexChanged += new System.EventHandler(this.tb_department_SelectedIndexChanged);
            // 
            // cb_is_manager
            // 
            resources.ApplyResources(this.cb_is_manager, "cb_is_manager");
            this.cb_is_manager.Name = "cb_is_manager";
            this.cb_is_manager.UseVisualStyleBackColor = true;
            // 
            // cb_enable
            // 
            resources.ApplyResources(this.cb_enable, "cb_enable");
            this.cb_enable.Name = "cb_enable";
            this.cb_enable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // bt_save
            // 
            resources.ApplyResources(this.bt_save, "bt_save");
            this.bt_save.Name = "bt_save";
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tb_id
            // 
            resources.ApplyResources(this.tb_id, "tb_id");
            this.tb_id.BackColor = System.Drawing.SystemColors.Info;
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tb_full_name
            // 
            resources.ApplyResources(this.tb_full_name, "tb_full_name");
            this.tb_full_name.Name = "tb_full_name";
            this.tb_full_name.TextChanged += new System.EventHandler(this.Change_back_normal);
            this.tb_full_name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            this.tb_full_name.Validated += new System.EventHandler(this.tb_Validated);
            // 
            // tb_username
            // 
            resources.ApplyResources(this.tb_username, "tb_username");
            this.tb_username.Name = "tb_username";
            this.tb_username.TextChanged += new System.EventHandler(this.Change_back_normal);
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            this.tb_username.Validated += new System.EventHandler(this.tb_Validated);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            resources.ApplyResources(this.bindingNavigator1, "bindingNavigator1");
            this.bindingNavigator1.MoveFirstItem = this.MoveFirst;
            this.bindingNavigator1.MoveLastItem = this.MoveLast;
            this.bindingNavigator1.MoveNextItem = this.MoveNext;
            this.bindingNavigator1.MovePreviousItem = this.MovePrevious;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
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
            resources.ApplyResources(this.MoveFirst, "MoveFirst");
            this.MoveFirst.Name = "MoveFirst";
            // 
            // MovePrevious
            // 
            this.MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.MovePrevious, "MovePrevious");
            this.MovePrevious.Name = "MovePrevious";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // MoveNext
            // 
            this.MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.MoveNext, "MoveNext");
            this.MoveNext.Name = "MoveNext";
            // 
            // MoveLast
            // 
            this.MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.MoveLast, "MoveLast");
            this.MoveLast.Name = "MoveLast";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // Create_account
            // 
            this.Create_account.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.Create_account, "Create_account");
            this.Create_account.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.Create_account.Name = "Create_account";
            this.Create_account.Click += new System.EventHandler(this.Create_account_Click);
            // 
            // bt_del_account
            // 
            this.bt_del_account.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bt_del_account, "bt_del_account");
            this.bt_del_account.Name = "bt_del_account";
            this.bt_del_account.Click += new System.EventHandler(this.bt_del_account_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // tb_serach
            // 
            resources.ApplyResources(this.tb_serach, "tb_serach");
            this.tb_serach.Name = "tb_serach";
            this.tb_serach.TextChanged += new System.EventHandler(this.Search_change);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // cb_filter_department
            // 
            this.cb_filter_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter_department.Items.AddRange(new object[] {
            resources.GetString("cb_filter_department.Items"),
            resources.GetString("cb_filter_department.Items1"),
            resources.GetString("cb_filter_department.Items2"),
            resources.GetString("cb_filter_department.Items3"),
            resources.GetString("cb_filter_department.Items4"),
            resources.GetString("cb_filter_department.Items5"),
            resources.GetString("cb_filter_department.Items6"),
            resources.GetString("cb_filter_department.Items7"),
            resources.GetString("cb_filter_department.Items8")});
            this.cb_filter_department.Name = "cb_filter_department";
            resources.ApplyResources(this.cb_filter_department, "cb_filter_department");
            this.cb_filter_department.SelectedIndexChanged += new System.EventHandler(this.Search_change);
            // 
            // cb_Filter_isManager
            // 
            this.cb_Filter_isManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter_isManager.Items.AddRange(new object[] {
            resources.GetString("cb_Filter_isManager.Items"),
            resources.GetString("cb_Filter_isManager.Items1"),
            resources.GetString("cb_Filter_isManager.Items2")});
            this.cb_Filter_isManager.Name = "cb_Filter_isManager";
            resources.ApplyResources(this.cb_Filter_isManager, "cb_Filter_isManager");
            this.cb_Filter_isManager.SelectedIndexChanged += new System.EventHandler(this.Search_change);
            // 
            // cb_Filter_Enable
            // 
            this.cb_Filter_Enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter_Enable.Items.AddRange(new object[] {
            resources.GetString("cb_Filter_Enable.Items"),
            resources.GetString("cb_Filter_Enable.Items1"),
            resources.GetString("cb_Filter_Enable.Items2")});
            this.cb_Filter_Enable.Name = "cb_Filter_Enable";
            resources.ApplyResources(this.cb_Filter_Enable, "cb_Filter_Enable");
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
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Account_Management
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGrid_staffList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Account_Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Account_Management_FormClosing);
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