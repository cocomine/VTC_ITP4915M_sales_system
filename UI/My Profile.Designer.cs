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
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tb_Password
            // 
            resources.ApplyResources(this.tb_Password, "tb_Password");
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.tb_Password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Password_Validating);
            // 
            // tb_Username
            // 
            resources.ApplyResources(this.tb_Username, "tb_Username");
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.tb_Username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Username_Validating);
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
            // tb_FullName
            // 
            this.tb_FullName.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.tb_FullName, "tb_FullName");
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tb_Department
            // 
            this.tb_Department.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.tb_Department, "tb_Department");
            this.tb_Department.Name = "tb_Department";
            this.tb_Department.ReadOnly = true;
            // 
            // btn_Save
            // 
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_DepartmentHead
            // 
            this.cb_DepartmentHead.AutoCheck = false;
            resources.ApplyResources(this.cb_DepartmentHead, "cb_DepartmentHead");
            this.cb_DepartmentHead.BackColor = System.Drawing.SystemColors.Control;
            this.cb_DepartmentHead.Name = "cb_DepartmentHead";
            this.cb_DepartmentHead.TabStop = false;
            this.cb_DepartmentHead.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // My_Profile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "My_Profile";
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