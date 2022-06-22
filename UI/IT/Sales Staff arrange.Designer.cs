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
            this.list_store.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_store.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colummHeader5,
            this.colummHeader6});
            this.list_store.FullRowSelect = true;
            this.list_store.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_store.HideSelection = false;
            this.list_store.Location = new System.Drawing.Point(12, 21);
            this.list_store.MultiSelect = false;
            this.list_store.Name = "list_store";
            this.list_store.ShowGroups = false;
            this.list_store.Size = new System.Drawing.Size(239, 393);
            this.list_store.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_store.TabIndex = 0;
            this.list_store.UseCompatibleStateImageBehavior = false;
            this.list_store.View = System.Windows.Forms.View.Details;
            this.list_store.SelectedIndexChanged += new System.EventHandler(this.list_store_SelectedIndexChanged);
            this.list_store.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_store_DragDrop);
            this.list_store.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_store_DragEnter);
            this.list_store.DragOver += new System.Windows.Forms.DragEventHandler(this.list_store_DragOver);
            // 
            // colummHeader5
            // 
            this.colummHeader5.Text = "ID";
            this.colummHeader5.Width = 73;
            // 
            // colummHeader6
            // 
            this.colummHeader6.Text = "Name";
            this.colummHeader6.Width = 162;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.list_store);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 426);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the store to show the staff has been arranged";
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(254, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 426);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "You can drag the staff add in store or remove from store";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_remove
            // 
            this.bt_remove.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_remove.Location = new System.Drawing.Point(255, 217);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(29, 23);
            this.bt_remove.TabIndex = 16;
            this.bt_remove.Text = ">";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_add.Location = new System.Drawing.Point(255, 147);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(29, 23);
            this.bt_add.TabIndex = 15;
            this.bt_add.Text = "<";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Not arranged in any store";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Arranged in store";
            // 
            // list_unInStore
            // 
            this.list_unInStore.AllowDrop = true;
            this.list_unInStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_unInStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.list_unInStore.FullRowSelect = true;
            this.list_unInStore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_unInStore.HideSelection = false;
            this.list_unInStore.Location = new System.Drawing.Point(293, 38);
            this.list_unInStore.Name = "list_unInStore";
            this.list_unInStore.ShowGroups = false;
            this.list_unInStore.Size = new System.Drawing.Size(241, 310);
            this.list_unInStore.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_unInStore.TabIndex = 11;
            this.list_unInStore.UseCompatibleStateImageBehavior = false;
            this.list_unInStore.View = System.Windows.Forms.View.Details;
            this.list_unInStore.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.list_unInStore_ItemDrag);
            this.list_unInStore.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_unInStore_DragDrop);
            this.list_unInStore.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_unInStore_DragEnter);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Account ID";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Full Real Name";
            this.columnHeader4.Width = 129;
            // 
            // list_inStore
            // 
            this.list_inStore.AllowDrop = true;
            this.list_inStore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_inStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_inStore.FullRowSelect = true;
            this.list_inStore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_inStore.HideSelection = false;
            this.list_inStore.Location = new System.Drawing.Point(6, 38);
            this.list_inStore.Name = "list_inStore";
            this.list_inStore.ShowGroups = false;
            this.list_inStore.Size = new System.Drawing.Size(241, 310);
            this.list_inStore.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_inStore.TabIndex = 10;
            this.list_inStore.UseCompatibleStateImageBehavior = false;
            this.list_inStore.View = System.Windows.Forms.View.Details;
            this.list_inStore.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.list_unInStore_ItemDrag);
            this.list_inStore.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_inStore_DragDrop);
            this.list_inStore.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_unInStore_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Account ID";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Real Name";
            this.columnHeader2.Width = 129;
            // 
            // Sales_Staff_arrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Sales_Staff_arrange";
            this.Text = "Sales Staff arrange";
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