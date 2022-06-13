namespace ITP4915M.Sales_page {
    partial class Delivery_time_select {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery_time_select));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_time = new System.Windows.Forms.ComboBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.bt_save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select your delivery time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delivery time";
            // 
            // cb_time
            // 
            this.cb_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_time.FormattingEnabled = true;
            this.cb_time.Items.AddRange(new object[] {
            "9:00 - 12:00",
            "13:00 - 17:00",
            "18:00 - 22:00"});
            this.cb_time.Location = new System.Drawing.Point(87, 63);
            this.cb_time.Name = "cb_time";
            this.cb_time.Size = new System.Drawing.Size(200, 20);
            this.cb_time.TabIndex = 2;
            // 
            // dt_date
            // 
            this.dt_date.CustomFormat = "";
            this.dt_date.Location = new System.Drawing.Point(87, 31);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(200, 22);
            this.dt_date.TabIndex = 1;
            this.dt_date.Value = new System.DateTime(2022, 6, 13, 22, 14, 55, 0);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(227, 106);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 3;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Delivery_time_select
            // 
            this.AcceptButton = this.bt_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 141);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.cb_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 180);
            this.Name = "Delivery_time_select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Time Select";
            this.Load += new System.EventHandler(this.delivery_time_select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_time;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}