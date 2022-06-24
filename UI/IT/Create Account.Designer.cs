namespace ITP4915M.IT {
    partial class Create_Account {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Account));
            this.bt_create = new System.Windows.Forms.Button();
            this.cb_enable = new System.Windows.Forms.CheckBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FullRealName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_isManager = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_create
            // 
            resources.ApplyResources(this.bt_create, "bt_create");
            this.bt_create.Name = "bt_create";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // cb_enable
            // 
            resources.ApplyResources(this.cb_enable, "cb_enable");
            this.cb_enable.Name = "cb_enable";
            this.cb_enable.UseVisualStyleBackColor = true;
            // 
            // cb_department
            // 
            this.cb_department.BackColor = System.Drawing.SystemColors.Window;
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.ForeColor = System.Drawing.SystemColors.MenuText;
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
            resources.ApplyResources(this.cb_department, "cb_department");
            this.cb_department.Name = "cb_department";
            // 
            // tb_username
            // 
            resources.ApplyResources(this.tb_username, "tb_username");
            this.tb_username.Name = "tb_username";
            this.tb_username.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tb_FullRealName
            // 
            this.tb_FullRealName.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tb_FullRealName, "tb_FullRealName");
            this.tb_FullRealName.Name = "tb_FullRealName";
            this.tb_FullRealName.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_FullRealName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cb_isManager
            // 
            resources.ApplyResources(this.cb_isManager, "cb_isManager");
            this.cb_isManager.Name = "cb_isManager";
            this.cb_isManager.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Create_Account
            // 
            this.AcceptButton = this.bt_create;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_isManager);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.cb_enable);
            this.Controls.Add(this.tb_FullRealName);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create_Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Create_Account_FormClosed);
            this.Load += new System.EventHandler(this.Create_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.CheckBox cb_enable;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FullRealName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_isManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}