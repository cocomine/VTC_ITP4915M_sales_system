namespace ITP4915M.IT {
    partial class Sales_Staff_arrange {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Staff_arrange));
            this.list_store = new System.Windows.Forms.ListView();
            this.colummHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colummHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_unInStore = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_inStore = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_store
            // 
            this.list_store.AllowDrop = true;
            resources.ApplyResources(this.list_store, "list_store");
            this.list_store.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummHeader5,
            this.colummHeader6});
            this.list_store.FullRowSelect = true;
            this.list_store.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_store.HideSelection = false;
            this.list_store.MultiSelect = false;
            this.list_store.Name = "list_store";
            this.list_store.ShowGroups = false;
            this.list_store.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_store.UseCompatibleStateImageBehavior = false;
            this.list_store.View = System.Windows.Forms.View.Details;
            this.list_store.SelectedIndexChanged += new System.EventHandler(this.list_store_SelectedIndexChanged);
            this.list_store.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_store_DragDrop);
            this.list_store.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_store_DragEnter);
            this.list_store.DragOver += new System.Windows.Forms.DragEventHandler(this.list_store_DragOver);
            // 
            // colummHeader5
            // 
            resources.ApplyResources(this.colummHeader5, "colummHeader5");
            // 
            // colummHeader6
            // 
            resources.ApplyResources(this.colummHeader6, "colummHeader6");
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.list_store);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bt_remove);
            this.panel2.Controls.Add(this.bt_add);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.list_unInStore);
            this.panel2.Controls.Add(this.list_inStore);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // bt_remove
            // 
            resources.ApplyResources(this.bt_remove, "bt_remove");
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_add
            // 
            resources.ApplyResources(this.bt_add, "bt_add");
            this.bt_add.Name = "bt_add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
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
            // list_unInStore
            // 
            this.list_unInStore.AllowDrop = true;
            resources.ApplyResources(this.list_unInStore, "list_unInStore");
            this.list_unInStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.list_unInStore.FullRowSelect = true;
            this.list_unInStore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_unInStore.HideSelection = false;
            this.list_unInStore.Name = "list_unInStore";
            this.list_unInStore.ShowGroups = false;
            this.list_unInStore.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_unInStore.UseCompatibleStateImageBehavior = false;
            this.list_unInStore.View = System.Windows.Forms.View.Details;
            this.list_unInStore.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.list_unInStore_ItemDrag);
            this.list_unInStore.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_unInStore_DragDrop);
            this.list_unInStore.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_unInStore_DragEnter);
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // list_inStore
            // 
            this.list_inStore.AllowDrop = true;
            resources.ApplyResources(this.list_inStore, "list_inStore");
            this.list_inStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_inStore.FullRowSelect = true;
            this.list_inStore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_inStore.HideSelection = false;
            this.list_inStore.Name = "list_inStore";
            this.list_inStore.ShowGroups = false;
            this.list_inStore.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_inStore.UseCompatibleStateImageBehavior = false;
            this.list_inStore.View = System.Windows.Forms.View.Details;
            this.list_inStore.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.list_unInStore_ItemDrag);
            this.list_inStore.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_inStore_DragDrop);
            this.list_inStore.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_unInStore_DragEnter);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // Sales_Staff_arrange
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sales_Staff_arrange";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sales_Staff_arrange_FormClosed);
            this.Load += new System.EventHandler(this.Sales_Staff_arrange_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_store;
        private System.Windows.Forms.ColumnHeader colummHeader5;
        private System.Windows.Forms.ColumnHeader colummHeader6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView list_unInStore;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView list_inStore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
    }
}