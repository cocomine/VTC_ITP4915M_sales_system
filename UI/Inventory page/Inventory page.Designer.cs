namespace UI.Inventory_page
{
    partial class Inventory_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pl_childForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pl_childForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1,
            this.inventoryQuantityToolStripMenuItem,
            this.itemRequestToolStripMenuItem,
            this.purchaseItemToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            resources.ApplyResources(this.logoutToolStripMenuItem1, "logoutToolStripMenuItem1");
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // inventoryQuantityToolStripMenuItem
            // 
            this.inventoryQuantityToolStripMenuItem.Name = "inventoryQuantityToolStripMenuItem";
            resources.ApplyResources(this.inventoryQuantityToolStripMenuItem, "inventoryQuantityToolStripMenuItem");
            this.inventoryQuantityToolStripMenuItem.Click += new System.EventHandler(this.warehouseToolStripMenuItem_Click);
            // 
            // itemRequestToolStripMenuItem
            // 
            this.itemRequestToolStripMenuItem.Name = "itemRequestToolStripMenuItem";
            resources.ApplyResources(this.itemRequestToolStripMenuItem, "itemRequestToolStripMenuItem");
            this.itemRequestToolStripMenuItem.Click += new System.EventHandler(this.itemRequestedToolStripMenuItem_Click);
            // 
            // purchaseItemToolStripMenuItem1
            // 
            this.purchaseItemToolStripMenuItem1.Name = "purchaseItemToolStripMenuItem1";
            resources.ApplyResources(this.purchaseItemToolStripMenuItem1, "purchaseItemToolStripMenuItem1");
            this.purchaseItemToolStripMenuItem1.Click += new System.EventHandler(this.purchaseItemToolStripMenuItem_Click);
            // 
            // pl_childForm
            // 
            this.pl_childForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pl_childForm.Controls.Add(this.label1);
            resources.ApplyResources(this.pl_childForm, "pl_childForm");
            this.pl_childForm.Name = "pl_childForm";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // Inventory_page
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_childForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventory_page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventory_page_FormClosed);
            this.Load += new System.EventHandler(this.Inventory_page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pl_childForm.ResumeLayout(false);
            this.pl_childForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pl_childForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventoryQuantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseItemToolStripMenuItem1;
    }
}