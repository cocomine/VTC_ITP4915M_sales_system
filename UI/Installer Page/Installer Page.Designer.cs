namespace UI.Installer_Page
{
    partial class Installer_Page
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
            this.lb_order = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_installation_item = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_customer_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_customer_address = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_customer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_order
            // 
            this.lb_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_order.FormattingEnabled = true;
            this.lb_order.ItemHeight = 15;
            this.lb_order.Location = new System.Drawing.Point(16, 64);
            this.lb_order.Margin = new System.Windows.Forms.Padding(4);
            this.lb_order.Name = "lb_order";
            this.lb_order.Size = new System.Drawing.Size(425, 484);
            this.lb_order.TabIndex = 0;
            this.lb_order.SelectedIndexChanged += new System.EventHandler(this.lb_order_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.myProfiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // myProfiToolStripMenuItem
            // 
            this.myProfiToolStripMenuItem.Name = "myProfiToolStripMenuItem";
            this.myProfiToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.myProfiToolStripMenuItem.Text = "My Profile";
            this.myProfiToolStripMenuItem.Click += new System.EventHandler(this.myProfiToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(463, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(571, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lb_installation_item);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_customer_phone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_customer_address);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_customer_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 378);
            this.panel1.TabIndex = 0;
            // 
            // lb_installation_item
            // 
            this.lb_installation_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_installation_item.FormattingEnabled = true;
            this.lb_installation_item.ItemHeight = 15;
            this.lb_installation_item.Location = new System.Drawing.Point(161, 248);
            this.lb_installation_item.Margin = new System.Windows.Forms.Padding(4);
            this.lb_installation_item.Name = "lb_installation_item";
            this.lb_installation_item.Size = new System.Drawing.Size(372, 109);
            this.lb_installation_item.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Installation Item";
            // 
            // tb_customer_phone
            // 
            this.tb_customer_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_customer_phone.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_phone.Location = new System.Drawing.Point(161, 186);
            this.tb_customer_phone.Margin = new System.Windows.Forms.Padding(4);
            this.tb_customer_phone.Name = "tb_customer_phone";
            this.tb_customer_phone.ReadOnly = true;
            this.tb_customer_phone.Size = new System.Drawing.Size(160, 25);
            this.tb_customer_phone.TabIndex = 5;
            this.tb_customer_phone.TextChanged += new System.EventHandler(this.tb_customer_phone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Phone";
            // 
            // tb_customer_address
            // 
            this.tb_customer_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_customer_address.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_address.Location = new System.Drawing.Point(161, 79);
            this.tb_customer_address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_customer_address.Name = "tb_customer_address";
            this.tb_customer_address.ReadOnly = true;
            this.tb_customer_address.Size = new System.Drawing.Size(372, 85);
            this.tb_customer_address.TabIndex = 3;
            this.tb_customer_address.Text = "";
            this.tb_customer_address.TextChanged += new System.EventHandler(this.tb_customer_address_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Address";
            // 
            // tb_customer_name
            // 
            this.tb_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_customer_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_name.Location = new System.Drawing.Point(161, 24);
            this.tb_customer_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_customer_name.Name = "tb_customer_name";
            this.tb_customer_name.ReadOnly = true;
            this.tb_customer_name.Size = new System.Drawing.Size(372, 25);
            this.tb_customer_name.TabIndex = 1;
            this.tb_customer_name.TextChanged += new System.EventHandler(this.tb_customer_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(856, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Order Complete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Schedule your order";
            // 
            // Installer_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_order);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1082, 599);
            this.Name = "Installer_Page";
            this.Text = "Installer Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Installer_Page_FormClosed);
            this.Load += new System.EventHandler(this.Installer_Page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_order;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lb_installation_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_customer_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tb_customer_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_customer_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem myProfiToolStripMenuItem;
    }
}