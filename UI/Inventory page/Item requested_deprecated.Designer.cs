namespace UI.Inventory_page {
    partial class Item_requested_deprecated {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.serach1 = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.NumericUpDown();
            this.search2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rc2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.DESC = new System.Windows.Forms.Button();
            this.ACS = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rc2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serach1
            // 
            this.serach1.Location = new System.Drawing.Point(180, 346);
            this.serach1.Name = "serach1";
            this.serach1.Size = new System.Drawing.Size(73, 22);
            this.serach1.TabIndex = 4;
            this.serach1.Text = "Serach";
            this.serach1.UseVisualStyleBackColor = true;
            this.serach1.Click += new System.EventHandler(this.serach1_Click);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(85, 344);
            this.search1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(89, 22);
            this.search1.TabIndex = 8;
            this.search1.ValueChanged += new System.EventHandler(this.search1_ValueChanged);
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(180, 302);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(73, 22);
            this.search2.TabIndex = 7;
            this.search2.Text = "Serach";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "WarehouseID";
            // 
            // rc2
            // 
            this.rc2.Location = new System.Drawing.Point(83, 304);
            this.rc2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rc2.Name = "rc2";
            this.rc2.Size = new System.Drawing.Size(89, 22);
            this.rc2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order By (Qty)";
            // 
            // DESC
            // 
            this.DESC.Location = new System.Drawing.Point(667, 339);
            this.DESC.Name = "DESC";
            this.DESC.Size = new System.Drawing.Size(78, 33);
            this.DESC.TabIndex = 11;
            this.DESC.Text = "DESC";
            this.DESC.UseVisualStyleBackColor = true;
            this.DESC.Click += new System.EventHandler(this.DESC_Click);
            // 
            // ACS
            // 
            this.ACS.Location = new System.Drawing.Point(583, 339);
            this.ACS.Name = "ACS";
            this.ACS.Size = new System.Drawing.Size(78, 33);
            this.ACS.TabIndex = 10;
            this.ACS.Text = "ASC";
            this.ACS.UseVisualStyleBackColor = true;
            this.ACS.Click += new System.EventHandler(this.ACS_Click);
            // 
            // normal
            // 
            this.normal.Location = new System.Drawing.Point(400, 340);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(87, 30);
            this.normal.TabIndex = 13;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // Item_requested
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 387);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DESC);
            this.Controls.Add(this.ACS);
            this.Controls.Add(this.rc2);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serach1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(800, 426);
            this.Name = "Item_requested";
            this.Text = "Item requested";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Item_requested_Closing);
            this.Load += new System.EventHandler(this.Item_requested_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button serach1;
        private System.Windows.Forms.NumericUpDown search1;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rc2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DESC;
        private System.Windows.Forms.Button ACS;
        private System.Windows.Forms.Button normal;
    }
}