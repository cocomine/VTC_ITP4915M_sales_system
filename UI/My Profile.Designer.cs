namespace UI
{
    partial class My_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_Profile));
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Department = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_DepartmentHead = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(92, 137);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '⚫';
            this.tb_Password.Size = new System.Drawing.Size(253, 22);
            this.tb_Password.TabIndex = 13;
            this.tb_Password.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.tb_Password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Password_Validating);
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(92, 104);
            this.tb_Username.MaxLength = 10;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(253, 22);
            this.tb_Username.TabIndex = 12;
            this.tb_Username.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.tb_Username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Username_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Department";
            // 
            // tb_FullName
            // 
            this.tb_FullName.BackColor = System.Drawing.SystemColors.Info;
            this.tb_FullName.Location = new System.Drawing.Point(92, 9);
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.ReadOnly = true;
            this.tb_FullName.Size = new System.Drawing.Size(253, 22);
            this.tb_FullName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Full Real Name";
            // 
            // tb_Department
            // 
            this.tb_Department.BackColor = System.Drawing.SystemColors.Info;
            this.tb_Department.Location = new System.Drawing.Point(92, 41);
            this.tb_Department.Name = "tb_Department";
            this.tb_Department.ReadOnly = true;
            this.tb_Department.Size = new System.Drawing.Size(253, 22);
            this.tb_Department.TabIndex = 11;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(261, 176);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(96, 23);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save change";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_DepartmentHead
            // 
            this.cb_DepartmentHead.AutoCheck = false;
            this.cb_DepartmentHead.AutoSize = true;
            this.cb_DepartmentHead.BackColor = System.Drawing.SystemColors.Control;
            this.cb_DepartmentHead.Location = new System.Drawing.Point(93, 69);
            this.cb_DepartmentHead.Name = "cb_DepartmentHead";
            this.cb_DepartmentHead.Size = new System.Drawing.Size(138, 16);
            this.cb_DepartmentHead.TabIndex = 20;
            this.cb_DepartmentHead.TabStop = false;
            this.cb_DepartmentHead.Text = "Belong department head";
            this.cb_DepartmentHead.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "(If not change, please leave blank)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // My_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 211);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_DepartmentHead);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_FullName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(385, 250);
            this.MinimumSize = new System.Drawing.Size(385, 250);
            this.Name = "My_Profile";
            this.Text = "My Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.My_Profile_Closing);
            this.Load += new System.EventHandler(this.My_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Department;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.CheckBox cb_DepartmentHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}