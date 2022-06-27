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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrange_Delivery_Page));
            this.lb_order = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_unscheduled_team = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_unschedule = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_scheduled_features = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_session = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_customer_address = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_customer_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_delivery_item = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_customer_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.lb_order, "lb_order");
            this.lb_order.FormattingEnabled = true;
            this.lb_order.Name = "lb_order";
            this.lb_order.SelectedIndexChanged += new System.EventHandler(this.lb_order_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lb_unscheduled_team);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lb_unscheduled_team
            // 
            resources.ApplyResources(this.lb_unscheduled_team, "lb_unscheduled_team");
            this.lb_unscheduled_team.FormattingEnabled = true;
            this.lb_unscheduled_team.Name = "lb_unscheduled_team";
            this.lb_unscheduled_team.SelectedIndexChanged += new System.EventHandler(this.lb_unscheduled_team_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_schedule);
            this.panel4.Controls.Add(this.btn_unschedule);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btn_schedule
            // 
            resources.ApplyResources(this.btn_schedule, "btn_schedule");
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // btn_unschedule
            // 
            resources.ApplyResources(this.btn_unschedule, "btn_unschedule");
            this.btn_unschedule.Name = "btn_unschedule";
            this.btn_unschedule.UseVisualStyleBackColor = true;
            this.btn_unschedule.Click += new System.EventHandler(this.btn_unschedule_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_scheduled_features);
            this.panel5.Controls.Add(this.label3);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // lb_scheduled_features
            // 
            resources.ApplyResources(this.lb_scheduled_features, "lb_scheduled_features");
            this.lb_scheduled_features.FormattingEnabled = true;
            this.lb_scheduled_features.Name = "lb_scheduled_features";
            this.lb_scheduled_features.SelectedIndexChanged += new System.EventHandler(this.lb_scheduled_features_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_order);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_session);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_customer_address);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_customer_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_delivery_item);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_customer_phone);
            this.groupBox1.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tb_session
            // 
            this.tb_session.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.tb_session, "tb_session");
            this.tb_session.Name = "tb_session";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tb_customer_address
            // 
            resources.ApplyResources(this.tb_customer_address, "tb_customer_address");
            this.tb_customer_address.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_address.Name = "tb_customer_address";
            this.tb_customer_address.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tb_customer_name
            // 
            resources.ApplyResources(this.tb_customer_name, "tb_customer_name");
            this.tb_customer_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_name.Name = "tb_customer_name";
            this.tb_customer_name.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lb_delivery_item
            // 
            resources.ApplyResources(this.lb_delivery_item, "lb_delivery_item");
            this.lb_delivery_item.FormattingEnabled = true;
            this.lb_delivery_item.Name = "lb_delivery_item";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tb_customer_phone
            // 
            resources.ApplyResources(this.tb_customer_phone, "tb_customer_phone");
            this.tb_customer_phone.BackColor = System.Drawing.SystemColors.Info;
            this.tb_customer_phone.Name = "tb_customer_phone";
            this.tb_customer_phone.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            // Arrange_Delivery_Page
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Arrange_Delivery_Page";
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
        private System.Windows.Forms.ListBox lb_unscheduled_team;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button btn_unschedule;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox lb_scheduled_features;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_delivery_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_customer_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_customer_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tb_customer_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_session;
    }
}