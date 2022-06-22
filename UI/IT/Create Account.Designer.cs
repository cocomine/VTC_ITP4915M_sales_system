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
            this.bt_create.Location = new System.Drawing.Point(296, 142);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(75, 23);
            this.bt_create.TabIndex = 6;
            this.bt_create.Text = "Create";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // cb_enable
            // 
            this.cb_enable.AutoSize = true;
            this.cb_enable.Location = new System.Drawing.Point(94, 142);
            this.cb_enable.Name = "cb_enable";
            this.cb_enable.Size = new System.Drawing.Size(56, 16);
            this.cb_enable.TabIndex = 5;
            this.cb_enable.Text = "Enable";
            this.cb_enable.UseVisualStyleBackColor = true;
            // 
            // cb_department
            // 
            this.cb_department.BackColor = System.Drawing.SystemColors.Window;
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.ForeColor = System.Drawing.SystemColors.MenuText;
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
            this.cb_department.Location = new System.Drawing.Point(94, 47);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(268, 20);
            this.cb_department.TabIndex = 2;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(94, 114);
            this.tb_username.MaxLength = 10;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(268, 22);
            this.tb_username.TabIndex = 4;
            this.tb_username.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // tb_FullRealName
            // 
            this.tb_FullRealName.BackColor = System.Drawing.SystemColors.Window;
            this.tb_FullRealName.Location = new System.Drawing.Point(94, 14);
            this.tb_FullRealName.MaxLength = 20;
            this.tb_FullRealName.Name = "tb_FullRealName";
            this.tb_FullRealName.Size = new System.Drawing.Size(268, 22);
            this.tb_FullRealName.TabIndex = 1;
            this.tb_FullRealName.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_FullRealName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Real Name";
            // 
            // cb_isManager
            // 
            this.cb_isManager.AutoSize = true;
            this.cb_isManager.Location = new System.Drawing.Point(94, 74);
            this.cb_isManager.Name = "cb_isManager";
            this.cb_isManager.Size = new System.Drawing.Size(130, 16);
            this.cb_isManager.TabIndex = 3;
            this.cb_isManager.Text = "Is department manager";
            this.cb_isManager.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Create_Account
            // 
            this.AcceptButton = this.bt_create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 172);
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
            this.MaximumSize = new System.Drawing.Size(400, 211);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 211);
            this.Name = "Create_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
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