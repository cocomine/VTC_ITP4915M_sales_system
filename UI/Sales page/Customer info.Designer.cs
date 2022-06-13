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
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer Phone";
            // 
            // tb_address
            // 
            this.tb_address.BackColor = System.Drawing.SystemColors.Window;
            this.tb_address.Location = new System.Drawing.Point(116, 68);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(265, 69);
            this.tb_address.TabIndex = 9;
            this.tb_address.Text = "";
            this.tb_address.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_address.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer Address";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Name.Location = new System.Drawing.Point(116, 34);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(265, 22);
            this.tb_Name.TabIndex = 7;
            this.tb_Name.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Name.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Please enter customer information to arrange delivery or installation";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(321, 182);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(116, 149);
            this.tb_Phone.Mask = "0000-0000";
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(100, 22);
            this.tb_Phone.TabIndex = 10;
            this.tb_Phone.TextChanged += new System.EventHandler(this.Change_back_color);
            this.tb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Customer_info
            // 
            this.AcceptButton = this.bt_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 217);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(421, 256);
            this.MinimumSize = new System.Drawing.Size(421, 256);
            this.Name = "Customer_info";
            this.Text = "Customer info";
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