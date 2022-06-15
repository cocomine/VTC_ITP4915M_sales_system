namespace UI.Delivery_Page {
    partial class Arrange_Delivery_Page {
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
            this.lb_order = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_unscheduled_worker = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_unschedule = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_scheduled_features = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_customer_address = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_customer_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_installation_item = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_customer_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_session = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_order
            // 
            this.lb_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_order.FormattingEnabled = true;
            this.lb_order.ItemHeight = 12;
            this.lb_order.Location = new System.Drawing.Point(5, 24);
            this.lb_order.Name = "lb_order";
            this.lb_order.Size = new System.Drawing.Size(254, 376);
            this.lb_order.TabIndex = 0;
            this.lb_order.SelectedIndexChanged += new System.EventHandler(this.lb_order_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders that need to be scheduled for delivery team";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(560, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 424);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lb_unscheduled_worker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 186);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unscheduled delivery team";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_unscheduled_worker
            // 
            this.lb_unscheduled_worker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_unscheduled_worker.FormattingEnabled = true;
            this.lb_unscheduled_worker.ItemHeight = 12;
            this.lb_unscheduled_worker.Location = new System.Drawing.Point(5, 21);
            this.lb_unscheduled_worker.Name = "lb_unscheduled_worker";
            this.lb_unscheduled_worker.Size = new System.Drawing.Size(226, 160);
            this.lb_unscheduled_worker.TabIndex = 6;
            this.lb_unscheduled_worker.SelectedIndexChanged += new System.EventHandler(this.lb_unscheduled_worker_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_schedule);
            this.panel4.Controls.Add(this.btn_unschedule);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 34);
            this.panel4.TabIndex = 1;
            // 
            // btn_schedule
            // 
            this.btn_schedule.Location = new System.Drawing.Point(121, 6);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(104, 23);
            this.btn_schedule.TabIndex = 1;
            this.btn_schedule.Text = "Schedule";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // btn_unschedule
            // 
            this.btn_unschedule.Location = new System.Drawing.Point(5, 6);
            this.btn_unschedule.Name = "btn_unschedule";
            this.btn_unschedule.Size = new System.Drawing.Size(110, 23);
            this.btn_unschedule.TabIndex = 0;
            this.btn_unschedule.Text = "Unschedule";
            this.btn_unschedule.UseVisualStyleBackColor = true;
            this.btn_unschedule.Click += new System.EventHandler(this.btn_unschedule_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_scheduled_features);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 186);
            this.panel5.TabIndex = 2;
            // 
            // lb_scheduled_features
            // 
            this.lb_scheduled_features.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_scheduled_features.FormattingEnabled = true;
            this.lb_scheduled_features.ItemHeight = 12;
            this.lb_scheduled_features.Location = new System.Drawing.Point(5, 15);
            this.lb_scheduled_features.Name = "lb_scheduled_features";
            this.lb_scheduled_features.Size = new System.Drawing.Size(226, 148);
            this.lb_scheduled_features.TabIndex = 1;
            this.lb_scheduled_features.SelectedIndexChanged += new System.EventHandler(this.lb_scheduled_features_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Scheduled order";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_order);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 424);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(272, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 424);
            this.panel6.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_session);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_customer_address);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_customer_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_installation_item);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_customer_phone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detail";
            // 
            // tb_customer_address
            // 
            this.tb_customer_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_customer_address.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_address.Location = new System.Drawing.Point(9, 133);
            this.tb_customer_address.Name = "tb_customer_address";
            this.tb_customer_address.ReadOnly = true;
            this.tb_customer_address.Size = new System.Drawing.Size(269, 69);
            this.tb_customer_address.TabIndex = 15;
            this.tb_customer_address.Text = "";
            this.tb_customer_address.TextChanged += new System.EventHandler(this.tb_customer_address_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Customer Address";
            // 
            // tb_customer_name
            // 
            this.tb_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_customer_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_name.Location = new System.Drawing.Point(9, 36);
            this.tb_customer_name.Name = "tb_customer_name";
            this.tb_customer_name.ReadOnly = true;
            this.tb_customer_name.Size = new System.Drawing.Size(269, 22);
            this.tb_customer_name.TabIndex = 13;
            this.tb_customer_name.TextChanged += new System.EventHandler(this.tb_customer_name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Customer Name";
            // 
            // lb_installation_item
            // 
            this.lb_installation_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_installation_item.FormattingEnabled = true;
            this.lb_installation_item.ItemHeight = 12;
            this.lb_installation_item.Location = new System.Drawing.Point(9, 278);
            this.lb_installation_item.Name = "lb_installation_item";
            this.lb_installation_item.Size = new System.Drawing.Size(269, 124);
            this.lb_installation_item.TabIndex = 11;
            this.lb_installation_item.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Installation Item";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_customer_phone
            // 
            this.tb_customer_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_customer_phone.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_phone.Location = new System.Drawing.Point(9, 81);
            this.tb_customer_phone.Name = "tb_customer_phone";
            this.tb_customer_phone.ReadOnly = true;
            this.tb_customer_phone.Size = new System.Drawing.Size(154, 22);
            this.tb_customer_phone.TabIndex = 9;
            this.tb_customer_phone.TextChanged += new System.EventHandler(this.tb_customer_phone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Phone";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.myProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Delivery Session";
            // 
            // cb_session
            // 
            this.cb_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_session.FormattingEnabled = true;
            this.cb_session.Items.AddRange(new object[] {
            "9:00 - 12:00",
            "13:00 - 17:00",
            "18:00 - 22:00"});
            this.cb_session.Location = new System.Drawing.Point(10, 229);
            this.cb_session.Name = "cb_session";
            this.cb_session.Size = new System.Drawing.Size(153, 20);
            this.cb_session.TabIndex = 18;
            // 
            // Arrange_Delivery_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(816, 487);
            this.Name = "Arrange_Delivery_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Arrange installation workers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Arrange_installation_FormClosed);
            this.Load += new System.EventHandler(this.Arrange_installation_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_unscheduled_worker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button btn_unschedule;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lb_scheduled_features;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_installation_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_customer_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_customer_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tb_customer_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_session;
    }
}