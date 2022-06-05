namespace UI.Inventory_page
{
    partial class Item
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DESC = new System.Windows.Forms.Button();
            this.ACS = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.NumericUpDown();
            this.serach1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_desc_name = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 275);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Order By (Price)";
            // 
            // DESC
            // 
            this.DESC.Location = new System.Drawing.Point(666, 342);
            this.DESC.Name = "DESC";
            this.DESC.Size = new System.Drawing.Size(78, 33);
            this.DESC.TabIndex = 15;
            this.DESC.Text = "DESC";
            this.DESC.UseVisualStyleBackColor = true;
            this.DESC.Click += new System.EventHandler(this.DESC_Click);
            // 
            // ACS
            // 
            this.ACS.Location = new System.Drawing.Point(582, 342);
            this.ACS.Name = "ACS";
            this.ACS.Size = new System.Drawing.Size(78, 33);
            this.ACS.TabIndex = 14;
            this.ACS.Text = "ASC";
            this.ACS.UseVisualStyleBackColor = true;
            this.ACS.Click += new System.EventHandler(this.ACS_Click);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(87, 340);
            this.search1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(89, 22);
            this.search1.TabIndex = 19;
            // 
            // serach1
            // 
            this.serach1.Location = new System.Drawing.Point(182, 342);
            this.serach1.Name = "serach1";
            this.serach1.Size = new System.Drawing.Size(73, 22);
            this.serach1.TabIndex = 18;
            this.serach1.Text = "Serach";
            this.serach1.UseVisualStyleBackColor = true;
            this.serach1.Click += new System.EventHandler(this.serach1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "SupplierID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 20;
            this.button1.Text = "Normal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "Order By (Item Name)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 33);
            this.button2.TabIndex = 22;
            this.button2.Text = "ASC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_desc_name
            // 
            this.bt_desc_name.Location = new System.Drawing.Point(666, 293);
            this.bt_desc_name.Name = "bt_desc_name";
            this.bt_desc_name.Size = new System.Drawing.Size(78, 33);
            this.bt_desc_name.TabIndex = 23;
            this.bt_desc_name.Text = "DESC";
            this.bt_desc_name.UseVisualStyleBackColor = true;
            this.bt_desc_name.Click += new System.EventHandler(this.bt_desc_name_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 33);
            this.button4.TabIndex = 24;
            this.button4.Text = "Normal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 387);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bt_desc_name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.serach1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DESC);
            this.Controls.Add(this.ACS);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 426);
            this.Name = "Item";
            this.Text = "Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Item_Closing);
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DESC;
        private System.Windows.Forms.Button ACS;
        private System.Windows.Forms.NumericUpDown search1;
        private System.Windows.Forms.Button serach1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_desc_name;
        private System.Windows.Forms.Button button4;
    }
}