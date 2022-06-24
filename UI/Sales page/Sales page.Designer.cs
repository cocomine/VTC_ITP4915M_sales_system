namespace UI.Sales_page
{
    partial class Sales_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_remove_item = new System.Windows.Forms.Button();
            this.lv_item_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_add_name = new System.Windows.Forms.TextBox();
            this.tb_reshow_order = new System.Windows.Forms.TextBox();
            this.bt_reshow_order = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.bt_add_name = new System.Windows.Forms.Button();
            this.bt_add_id = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_add_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_item_description = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_item_price = new System.Windows.Forms.TextBox();
            this.chb_item_large = new System.Windows.Forms.CheckBox();
            this.tb_item_name = new System.Windows.Forms.TextBox();
            this.chb_item_install = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_save = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_reveived = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_paid = new System.Windows.Forms.Label();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_cancel = new System.Windows.Forms.Label();
            this.bt_receipt = new System.Windows.Forms.Button();
            this.lb_orderID = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_deposit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_change = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_epay = new System.Windows.Forms.Button();
            this.bt_cash = new System.Windows.Forms.Button();
            this.tb_charge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_reset);
            this.panel1.Controls.Add(this.bt_remove_item);
            this.panel1.Controls.Add(this.lv_item_list);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // bt_reset
            // 
            resources.ApplyResources(this.bt_reset, "bt_reset");
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_remove_item
            // 
            resources.ApplyResources(this.bt_remove_item, "bt_remove_item");
            this.bt_remove_item.Name = "bt_remove_item";
            this.bt_remove_item.UseVisualStyleBackColor = true;
            this.bt_remove_item.Click += new System.EventHandler(this.bt_remove_item_Click);
            // 
            // lv_item_list
            // 
            resources.ApplyResources(this.lv_item_list, "lv_item_list");
            this.lv_item_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.lv_item_list.FullRowSelect = true;
            this.lv_item_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_item_list.HideSelection = false;
            this.lv_item_list.Name = "lv_item_list";
            this.lv_item_list.ShowGroups = false;
            this.lv_item_list.UseCompatibleStateImageBehavior = false;
            this.lv_item_list.View = System.Windows.Forms.View.Details;
            this.lv_item_list.SelectedIndexChanged += new System.EventHandler(this.lv_item_list_SelectedIndexChanged);
            this.lv_item_list.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_item_list_KeyUp);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_add_name);
            this.groupBox3.Controls.Add(this.tb_reshow_order);
            this.groupBox3.Controls.Add(this.bt_reshow_order);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.bt_add_name);
            this.groupBox3.Controls.Add(this.bt_add_id);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_add_id);
            this.groupBox3.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tb_add_name
            // 
            resources.ApplyResources(this.tb_add_name, "tb_add_name");
            this.tb_add_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_add_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_add_name.Name = "tb_add_name";
            this.tb_add_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_add_name_KeyUp);
            // 
            // tb_reshow_order
            // 
            resources.ApplyResources(this.tb_reshow_order, "tb_reshow_order");
            this.tb_reshow_order.Name = "tb_reshow_order";
            this.tb_reshow_order.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_reshow_order_KeyUp);
            // 
            // bt_reshow_order
            // 
            resources.ApplyResources(this.bt_reshow_order, "bt_reshow_order");
            this.bt_reshow_order.Name = "bt_reshow_order";
            this.bt_reshow_order.UseVisualStyleBackColor = true;
            this.bt_reshow_order.Click += new System.EventHandler(this.bt_reshow_order_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // bt_add_name
            // 
            resources.ApplyResources(this.bt_add_name, "bt_add_name");
            this.bt_add_name.Name = "bt_add_name";
            this.bt_add_name.UseVisualStyleBackColor = true;
            this.bt_add_name.Click += new System.EventHandler(this.bt_add_name_Click);
            // 
            // bt_add_id
            // 
            resources.ApplyResources(this.bt_add_id, "bt_add_id");
            this.bt_add_id.Name = "bt_add_id";
            this.bt_add_id.UseVisualStyleBackColor = true;
            this.bt_add_id.Click += new System.EventHandler(this.bt_add_id_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tb_add_id
            // 
            resources.ApplyResources(this.tb_add_id, "tb_add_id");
            this.tb_add_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_add_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_add_id.Name = "tb_add_id";
            this.tb_add_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_add_id_KeyUp);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_item_description);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tb_item_price);
            this.groupBox4.Controls.Add(this.chb_item_large);
            this.groupBox4.Controls.Add(this.tb_item_name);
            this.groupBox4.Controls.Add(this.chb_item_install);
            this.groupBox4.Controls.Add(this.label5);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // tb_item_description
            // 
            resources.ApplyResources(this.tb_item_description, "tb_item_description");
            this.tb_item_description.BackColor = System.Drawing.SystemColors.Info;
            this.tb_item_description.Name = "tb_item_description";
            this.tb_item_description.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tb_item_price
            // 
            resources.ApplyResources(this.tb_item_price, "tb_item_price");
            this.tb_item_price.BackColor = System.Drawing.SystemColors.Info;
            this.tb_item_price.Name = "tb_item_price";
            this.tb_item_price.ReadOnly = true;
            // 
            // chb_item_large
            // 
            this.chb_item_large.AutoCheck = false;
            resources.ApplyResources(this.chb_item_large, "chb_item_large");
            this.chb_item_large.Name = "chb_item_large";
            this.chb_item_large.UseVisualStyleBackColor = true;
            // 
            // tb_item_name
            // 
            resources.ApplyResources(this.tb_item_name, "tb_item_name");
            this.tb_item_name.BackColor = System.Drawing.SystemColors.Info;
            this.tb_item_name.Name = "tb_item_name";
            this.tb_item_name.ReadOnly = true;
            // 
            // chb_item_install
            // 
            resources.ApplyResources(this.chb_item_install, "chb_item_install");
            this.chb_item_install.AutoCheck = false;
            this.chb_item_install.Name = "chb_item_install";
            this.chb_item_install.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lb_save);
            this.groupBox2.Controls.Add(this.tb_total);
            this.groupBox2.Controls.Add(this.tb_reveived);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lb_paid);
            this.groupBox2.Controls.Add(this.tb_subtotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_discount);
            this.groupBox2.Controls.Add(this.label8);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // lb_save
            // 
            resources.ApplyResources(this.lb_save, "lb_save");
            this.lb_save.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_save.Name = "lb_save";
            // 
            // tb_total
            // 
            resources.ApplyResources(this.tb_total, "tb_total");
            this.tb_total.BackColor = System.Drawing.SystemColors.Info;
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            // 
            // tb_reveived
            // 
            resources.ApplyResources(this.tb_reveived, "tb_reveived");
            this.tb_reveived.BackColor = System.Drawing.SystemColors.Info;
            this.tb_reveived.Name = "tb_reveived";
            this.tb_reveived.ReadOnly = true;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // lb_paid
            // 
            resources.ApplyResources(this.lb_paid, "lb_paid");
            this.lb_paid.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_paid.Name = "lb_paid";
            // 
            // tb_subtotal
            // 
            resources.ApplyResources(this.tb_subtotal, "tb_subtotal");
            this.tb_subtotal.BackColor = System.Drawing.SystemColors.Info;
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // tb_discount
            // 
            resources.ApplyResources(this.tb_discount, "tb_discount");
            this.tb_discount.BackColor = System.Drawing.SystemColors.Info;
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_cancel);
            this.groupBox1.Controls.Add(this.bt_receipt);
            this.groupBox1.Controls.Add(this.lb_orderID);
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.tb_deposit);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tb_change);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.bt_epay);
            this.groupBox1.Controls.Add(this.bt_cash);
            this.groupBox1.Controls.Add(this.tb_charge);
            this.groupBox1.Controls.Add(this.label11);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lb_cancel
            // 
            resources.ApplyResources(this.lb_cancel, "lb_cancel");
            this.lb_cancel.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_cancel.Name = "lb_cancel";
            // 
            // bt_receipt
            // 
            resources.ApplyResources(this.bt_receipt, "bt_receipt");
            this.bt_receipt.Name = "bt_receipt";
            this.bt_receipt.UseVisualStyleBackColor = true;
            this.bt_receipt.Click += new System.EventHandler(this.bt_receipt_Click);
            // 
            // lb_orderID
            // 
            resources.ApplyResources(this.lb_orderID, "lb_orderID");
            this.lb_orderID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lb_orderID.Name = "lb_orderID";
            // 
            // bt_save
            // 
            resources.ApplyResources(this.bt_save, "bt_save");
            this.bt_save.Name = "bt_save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_deposit
            // 
            resources.ApplyResources(this.tb_deposit, "tb_deposit");
            this.tb_deposit.BackColor = System.Drawing.SystemColors.Info;
            this.tb_deposit.Name = "tb_deposit";
            this.tb_deposit.ReadOnly = true;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // tb_change
            // 
            resources.ApplyResources(this.tb_change, "tb_change");
            this.tb_change.BackColor = System.Drawing.SystemColors.Info;
            this.tb_change.Name = "tb_change";
            this.tb_change.ReadOnly = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // bt_epay
            // 
            resources.ApplyResources(this.bt_epay, "bt_epay");
            this.bt_epay.Name = "bt_epay";
            this.bt_epay.UseVisualStyleBackColor = true;
            this.bt_epay.Click += new System.EventHandler(this.bt_epay_Click);
            // 
            // bt_cash
            // 
            resources.ApplyResources(this.bt_cash, "bt_cash");
            this.bt_cash.Name = "bt_cash";
            this.bt_cash.UseVisualStyleBackColor = true;
            this.bt_cash.Click += new System.EventHandler(this.bt_cash_Click);
            // 
            // tb_charge
            // 
            resources.ApplyResources(this.tb_charge, "tb_charge");
            this.tb_charge.Name = "tb_charge";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // Sales_Page
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sales_Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sales_Page_FormClosed);
            this.Load += new System.EventHandler(this.Sales_Page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox tb_item_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_item_name;
        private System.Windows.Forms.CheckBox chb_item_install;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chb_item_large;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_item_price;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_add_name;
        private System.Windows.Forms.Button bt_add_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_add_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_epay;
        private System.Windows.Forms.Button bt_cash;
        private System.Windows.Forms.TextBox tb_charge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.TextBox tb_reveived;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label lb_save;
        private System.Windows.Forms.TextBox tb_deposit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_paid;
        private System.Windows.Forms.TextBox tb_change;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lv_item_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tb_reshow_order;
        private System.Windows.Forms.Button bt_reshow_order;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tb_add_name;
        private System.Windows.Forms.Button bt_remove_item;
        private System.Windows.Forms.Label lb_orderID;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_receipt;
        private System.Windows.Forms.Label lb_cancel;
    }
}