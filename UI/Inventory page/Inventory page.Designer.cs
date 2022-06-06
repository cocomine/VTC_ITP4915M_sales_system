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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRequestedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pl_childForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pl_childForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.myProfileToolStripMenuItem,
            this.warehouseToolStripMenuItem,
            this.itemRequestedToolStripMenuItem,
            this.purchaseItemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            // warehouseToolStripMenuItem
            // 
            this.warehouseToolStripMenuItem.Name = "warehouseToolStripMenuItem";
            this.warehouseToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.warehouseToolStripMenuItem.Text = "Inventory quantity";
            this.warehouseToolStripMenuItem.Click += new System.EventHandler(this.warehouseToolStripMenuItem_Click);
            // 
            // itemRequestedToolStripMenuItem
            // 
            this.itemRequestedToolStripMenuItem.Name = "itemRequestedToolStripMenuItem";
            this.itemRequestedToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.itemRequestedToolStripMenuItem.Text = "Item requested";
            this.itemRequestedToolStripMenuItem.Click += new System.EventHandler(this.itemRequestedToolStripMenuItem_Click);
            // 
            // purchaseItemToolStripMenuItem
            // 
            this.purchaseItemToolStripMenuItem.Name = "purchaseItemToolStripMenuItem";
            this.purchaseItemToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.purchaseItemToolStripMenuItem.Text = "Purchase item";
            this.purchaseItemToolStripMenuItem.Click += new System.EventHandler(this.purchaseItemToolStripMenuItem_Click);
            // 
            // pl_childForm
            // 
            this.pl_childForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pl_childForm.Controls.Add(this.label1);
            this.pl_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_childForm.Location = new System.Drawing.Point(0, 24);
            this.pl_childForm.Name = "pl_childForm";
            this.pl_childForm.Size = new System.Drawing.Size(800, 426);
            this.pl_childForm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(274, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a feature above";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Inventory_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_childForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Inventory_page";
            this.Text = "Inventory page";
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
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemRequestedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseToolStripMenuItem;
        private System.Windows.Forms.Panel pl_childForm;
        private System.Windows.Forms.Label label1;
    }
}