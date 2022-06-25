namespace UI.Sales_page
{
    partial class Customer_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_info));
            this.label3 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tb_address, "tb_address");
            this.tb_address.Name = "tb_address";
            this.tb_address.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_address.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tb_Name, "tb_Name");
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // bt_save
            // 
            resources.ApplyResources(this.bt_save, "bt_save");
            this.bt_save.Name = "bt_save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_Phone
            // 
            resources.ApplyResources(this.tb_Phone, "tb_Phone");
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Customer_info
            // 
            this.AcceptButton = this.bt_save;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer_info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_info_FormClosed);
            this.Load += new System.EventHandler(this.Customer_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tb_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.MaskedTextBox tb_Phone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}