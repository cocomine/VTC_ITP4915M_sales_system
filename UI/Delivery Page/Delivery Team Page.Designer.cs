namespace UI.Delivery_Page {
    partial class Delivery_Team_Page {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery_Team_Page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_order = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_delivery_date = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_session = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_customer_address = new System.Windows.Forms.RichTextBox();
            this.lb_delivery_item = new System.Windows.Forms.ListBox();
            this.tb_customer_phone = new System.Windows.Forms.TextBox();
            this.tb_customer_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_complete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            resources.ApplyResources(this.loginToolStripMenuItem, "loginToolStripMenuItem");
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lb_order
            // 
            resources.ApplyResources(this.lb_order, "lb_order");
            this.lb_order.FormattingEnabled = true;
            this.lb_order.Name = "lb_order";
            this.lb_order.SelectedIndexChanged += new System.EventHandler(this.lb_order_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.tb_delivery_date);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_session);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_customer_address);
            this.panel1.Controls.Add(this.lb_delivery_item);
            this.panel1.Controls.Add(this.tb_customer_phone);
            this.panel1.Controls.Add(this.tb_customer_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // tb_delivery_date
            // 
            resources.ApplyResources(this.tb_delivery_date, "tb_delivery_date");
            this.tb_delivery_date.BackColor = System.Drawing.SystemColors.Info;
            this.tb_delivery_date.Name = "tb_delivery_date";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tb_session
            // 
            resources.ApplyResources(this.tb_session, "tb_session");
            this.tb_session.BackColor = System.Drawing.SystemColors.Info;
            this.tb_session.Name = "tb_session";
            this.tb_session.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tb_customer_address
            // 
            resources.ApplyResources(this.tb_customer_address, "tb_customer_address");
            this.tb_customer_address.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_address.Name = "tb_customer_address";
            this.tb_customer_address.ReadOnly = true;
            // 
            // lb_delivery_item
            // 
            resources.ApplyResources(this.lb_delivery_item, "lb_delivery_item");
            this.lb_delivery_item.FormattingEnabled = true;
            this.lb_delivery_item.Name = "lb_delivery_item";
            // 
            // tb_customer_phone
            // 
            resources.ApplyResources(this.tb_customer_phone, "tb_customer_phone");
            this.tb_customer_phone.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_phone.Name = "tb_customer_phone";
            this.tb_customer_phone.ReadOnly = true;
            // 
            // tb_customer_name
            // 
            resources.ApplyResources(this.tb_customer_name, "tb_customer_name");
            this.tb_customer_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_name.Name = "tb_customer_name";
            this.tb_customer_name.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_complete
            // 
            resources.ApplyResources(this.btn_complete, "btn_complete");
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // Delivery_Team_Page
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_order);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Delivery_Team_Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delivery_Page_FormClosed);
            this.Load += new System.EventHandler(this.Delivery_Page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_order;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_customer_phone;
        private System.Windows.Forms.TextBox tb_customer_name;
        private System.Windows.Forms.ListBox lb_delivery_item;
        private System.Windows.Forms.RichTextBox tb_customer_address;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.TextBox tb_customer_session;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_delivery_date;
        private System.Windows.Forms.TextBox tb_session;
        private System.Windows.Forms.Label label7;
    }
}