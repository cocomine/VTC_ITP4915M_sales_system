namespace ITP4915M {
    partial class Main_Menu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.lb_name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_myprofile = new System.Windows.Forms.Button();
            this.gp_sales = new System.Windows.Forms.GroupBox();
            this.bt_salesMange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancelOrder = new System.Windows.Forms.Button();
            this.bt_salesPage = new System.Windows.Forms.Button();
            this.gp_inventory = new System.Windows.Forms.GroupBox();
            this.bt_purchaseItem = new System.Windows.Forms.Button();
            this.bt_itemRequest = new System.Windows.Forms.Button();
            this.bt_inventoryQty = new System.Windows.Forms.Button();
            this.gp_technical = new System.Windows.Forms.GroupBox();
            this.bt_arrangeWorker = new System.Windows.Forms.Button();
            this.gp_delivery = new System.Windows.Forms.GroupBox();
            this.bt_arrangeTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_delivery = new System.Windows.Forms.Button();
            this.gp_install = new System.Windows.Forms.GroupBox();
            this.bt_install = new System.Windows.Forms.Button();
            this.gp_admin = new System.Windows.Forms.GroupBox();
            this.bt_assignSales = new System.Windows.Forms.Button();
            this.bt_deliveryGroup = new System.Windows.Forms.Button();
            this.bt_account = new System.Windows.Forms.Button();
            this.gp_accounting = new System.Windows.Forms.GroupBox();
            this.bt_purchaseReport = new System.Windows.Forms.Button();
            this.bt_orderReport = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gp_sales.SuspendLayout();
            this.gp_inventory.SuspendLayout();
            this.gp_technical.SuspendLayout();
            this.gp_delivery.SuspendLayout();
            this.gp_install.SuspendLayout();
            this.gp_admin.SuspendLayout();
            this.gp_accounting.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            resources.ApplyResources(this.lb_name, "lb_name");
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_name.Name = "lb_name";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lb_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_logout);
            this.panel1.Controls.Add(this.bt_myprofile);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // bt_logout
            // 
            resources.ApplyResources(this.bt_logout, "bt_logout");
            this.bt_logout.Image = global::ITP4915M.Properties.Resources.Entypo_LogOut_16x16;
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_myprofile
            // 
            resources.ApplyResources(this.bt_myprofile, "bt_myprofile");
            this.bt_myprofile.Image = global::ITP4915M.Properties.Resources.FontAwesome_AddressCardRegular_24x24;
            this.bt_myprofile.Name = "bt_myprofile";
            this.bt_myprofile.UseVisualStyleBackColor = true;
            this.bt_myprofile.Click += new System.EventHandler(this.bt_myprofile_Click);
            // 
            // gp_sales
            // 
            this.gp_sales.Controls.Add(this.bt_salesMange);
            this.gp_sales.Controls.Add(this.label2);
            this.gp_sales.Controls.Add(this.bt_cancelOrder);
            this.gp_sales.Controls.Add(this.bt_salesPage);
            resources.ApplyResources(this.gp_sales, "gp_sales");
            this.gp_sales.Name = "gp_sales";
            this.gp_sales.TabStop = false;
            // 
            // bt_salesMange
            // 
            resources.ApplyResources(this.bt_salesMange, "bt_salesMange");
            this.bt_salesMange.Image = global::ITP4915M.Properties.Resources.FontAwesome_TasksSolid_64x64;
            this.bt_salesMange.Name = "bt_salesMange";
            this.bt_salesMange.UseVisualStyleBackColor = true;
            this.bt_salesMange.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // bt_cancelOrder
            // 
            this.bt_cancelOrder.Image = global::ITP4915M.Properties.Resources.PicolIcons_DocumentSansCancel_64x64;
            resources.ApplyResources(this.bt_cancelOrder, "bt_cancelOrder");
            this.bt_cancelOrder.Name = "bt_cancelOrder";
            this.bt_cancelOrder.UseVisualStyleBackColor = true;
            this.bt_cancelOrder.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_salesPage
            // 
            this.bt_salesPage.Image = global::ITP4915M.Properties.Resources.Material_PrinterPos_64x64;
            resources.ApplyResources(this.bt_salesPage, "bt_salesPage");
            this.bt_salesPage.Name = "bt_salesPage";
            this.bt_salesPage.UseVisualStyleBackColor = true;
            this.bt_salesPage.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // gp_inventory
            // 
            this.gp_inventory.Controls.Add(this.bt_purchaseItem);
            this.gp_inventory.Controls.Add(this.bt_itemRequest);
            this.gp_inventory.Controls.Add(this.bt_inventoryQty);
            resources.ApplyResources(this.gp_inventory, "gp_inventory");
            this.gp_inventory.Name = "gp_inventory";
            this.gp_inventory.TabStop = false;
            // 
            // bt_purchaseItem
            // 
            this.bt_purchaseItem.Image = global::ITP4915M.Properties.Resources.FontAwesome_TruckLoadingSolid_64x64;
            resources.ApplyResources(this.bt_purchaseItem, "bt_purchaseItem");
            this.bt_purchaseItem.Name = "bt_purchaseItem";
            this.bt_purchaseItem.UseVisualStyleBackColor = true;
            this.bt_purchaseItem.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_itemRequest
            // 
            this.bt_itemRequest.Image = global::ITP4915M.Properties.Resources.FontAwesome_DollyFlatbedSolid_64x64;
            resources.ApplyResources(this.bt_itemRequest, "bt_itemRequest");
            this.bt_itemRequest.Name = "bt_itemRequest";
            this.bt_itemRequest.UseVisualStyleBackColor = true;
            this.bt_itemRequest.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_inventoryQty
            // 
            this.bt_inventoryQty.Image = global::ITP4915M.Properties.Resources.FontAwesome_WarehouseSolid_64x64;
            resources.ApplyResources(this.bt_inventoryQty, "bt_inventoryQty");
            this.bt_inventoryQty.Name = "bt_inventoryQty";
            this.bt_inventoryQty.UseVisualStyleBackColor = true;
            this.bt_inventoryQty.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // gp_technical
            // 
            this.gp_technical.Controls.Add(this.bt_arrangeWorker);
            resources.ApplyResources(this.gp_technical, "gp_technical");
            this.gp_technical.Name = "gp_technical";
            this.gp_technical.TabStop = false;
            // 
            // bt_arrangeWorker
            // 
            this.bt_arrangeWorker.Image = global::ITP4915M.Properties.Resources.Material_AccountHardHat_64x64;
            resources.ApplyResources(this.bt_arrangeWorker, "bt_arrangeWorker");
            this.bt_arrangeWorker.Name = "bt_arrangeWorker";
            this.bt_arrangeWorker.UseVisualStyleBackColor = true;
            this.bt_arrangeWorker.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // gp_delivery
            // 
            this.gp_delivery.Controls.Add(this.bt_arrangeTeam);
            this.gp_delivery.Controls.Add(this.label1);
            this.gp_delivery.Controls.Add(this.bt_delivery);
            resources.ApplyResources(this.gp_delivery, "gp_delivery");
            this.gp_delivery.Name = "gp_delivery";
            this.gp_delivery.TabStop = false;
            // 
            // bt_arrangeTeam
            // 
            resources.ApplyResources(this.bt_arrangeTeam, "bt_arrangeTeam");
            this.bt_arrangeTeam.Image = global::ITP4915M.Properties.Resources.Material_TruckDelivery_64x64;
            this.bt_arrangeTeam.Name = "bt_arrangeTeam";
            this.bt_arrangeTeam.UseVisualStyleBackColor = true;
            this.bt_arrangeTeam.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bt_delivery
            // 
            this.bt_delivery.Image = global::ITP4915M.Properties.Resources.FontAwesome_TruckSolid_64x64;
            resources.ApplyResources(this.bt_delivery, "bt_delivery");
            this.bt_delivery.Name = "bt_delivery";
            this.bt_delivery.UseVisualStyleBackColor = true;
            this.bt_delivery.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // gp_install
            // 
            this.gp_install.Controls.Add(this.bt_install);
            resources.ApplyResources(this.gp_install, "gp_install");
            this.gp_install.Name = "gp_install";
            this.gp_install.TabStop = false;
            // 
            // bt_install
            // 
            this.bt_install.Image = global::ITP4915M.Properties.Resources.BoxIcons_SolidWrench_64x64;
            resources.ApplyResources(this.bt_install, "bt_install");
            this.bt_install.Name = "bt_install";
            this.bt_install.UseVisualStyleBackColor = true;
            this.bt_install.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // gp_admin
            // 
            this.gp_admin.Controls.Add(this.bt_assignSales);
            this.gp_admin.Controls.Add(this.bt_deliveryGroup);
            this.gp_admin.Controls.Add(this.bt_account);
            resources.ApplyResources(this.gp_admin, "gp_admin");
            this.gp_admin.Name = "gp_admin";
            this.gp_admin.TabStop = false;
            // 
            // bt_assignSales
            // 
            this.bt_assignSales.Image = global::ITP4915M.Properties.Resources.BoxIcons_SolidStore_64x64;
            resources.ApplyResources(this.bt_assignSales, "bt_assignSales");
            this.bt_assignSales.Name = "bt_assignSales";
            this.bt_assignSales.UseVisualStyleBackColor = true;
            this.bt_assignSales.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_deliveryGroup
            // 
            this.bt_deliveryGroup.Image = global::ITP4915M.Properties.Resources.BoxIcons_SolidGroup_64x64;
            resources.ApplyResources(this.bt_deliveryGroup, "bt_deliveryGroup");
            this.bt_deliveryGroup.Name = "bt_deliveryGroup";
            this.bt_deliveryGroup.UseVisualStyleBackColor = true;
            this.bt_deliveryGroup.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_account
            // 
            this.bt_account.Image = global::ITP4915M.Properties.Resources.BoxIcons_SolidUserAccount_64x64;
            resources.ApplyResources(this.bt_account, "bt_account");
            this.bt_account.Name = "bt_account";
            this.bt_account.UseVisualStyleBackColor = true;
            this.bt_account.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // gp_accounting
            // 
            this.gp_accounting.Controls.Add(this.bt_purchaseReport);
            this.gp_accounting.Controls.Add(this.bt_orderReport);
            resources.ApplyResources(this.gp_accounting, "gp_accounting");
            this.gp_accounting.Name = "gp_accounting";
            this.gp_accounting.TabStop = false;
            // 
            // bt_purchaseReport
            // 
            this.bt_purchaseReport.Image = global::ITP4915M.Properties.Resources.BoxIcons_SolidPurchaseTagAlt_64x64;
            resources.ApplyResources(this.bt_purchaseReport, "bt_purchaseReport");
            this.bt_purchaseReport.Name = "bt_purchaseReport";
            this.bt_purchaseReport.UseVisualStyleBackColor = true;
            this.bt_purchaseReport.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_orderReport
            // 
            this.bt_orderReport.Image = global::ITP4915M.Properties.Resources.BoxIcons_SolidReport_64x64;
            resources.ApplyResources(this.bt_orderReport, "bt_orderReport");
            this.bt_orderReport.Name = "bt_orderReport";
            this.bt_orderReport.UseVisualStyleBackColor = true;
            this.bt_orderReport.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Controls.Add(this.gp_admin);
            this.menu.Controls.Add(this.gp_accounting);
            this.menu.Controls.Add(this.gp_inventory);
            this.menu.Controls.Add(this.gp_technical);
            this.menu.Controls.Add(this.gp_install);
            this.menu.Controls.Add(this.gp_delivery);
            this.menu.Controls.Add(this.gp_sales);
            this.menu.Name = "menu";
            // 
            // Main_Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main_Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Menu_FormClosed);
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gp_sales.ResumeLayout(false);
            this.gp_inventory.ResumeLayout(false);
            this.gp_technical.ResumeLayout(false);
            this.gp_delivery.ResumeLayout(false);
            this.gp_install.ResumeLayout(false);
            this.gp_admin.ResumeLayout(false);
            this.gp_accounting.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_myprofile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.GroupBox gp_sales;
        private System.Windows.Forms.Button bt_salesPage;
        private System.Windows.Forms.Button bt_cancelOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_salesMange;
        private System.Windows.Forms.GroupBox gp_inventory;
        private System.Windows.Forms.Button bt_purchaseItem;
        private System.Windows.Forms.Button bt_itemRequest;
        private System.Windows.Forms.Button bt_inventoryQty;
        private System.Windows.Forms.GroupBox gp_technical;
        private System.Windows.Forms.Button bt_arrangeWorker;
        private System.Windows.Forms.GroupBox gp_delivery;
        private System.Windows.Forms.Button bt_arrangeTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_delivery;
        private System.Windows.Forms.GroupBox gp_install;
        private System.Windows.Forms.Button bt_install;
        private System.Windows.Forms.GroupBox gp_admin;
        private System.Windows.Forms.Button bt_assignSales;
        private System.Windows.Forms.Button bt_deliveryGroup;
        private System.Windows.Forms.Button bt_account;
        private System.Windows.Forms.GroupBox gp_accounting;
        private System.Windows.Forms.Button bt_orderReport;
        private System.Windows.Forms.Button bt_purchaseReport;
        private System.Windows.Forms.Panel menu;
    }
}