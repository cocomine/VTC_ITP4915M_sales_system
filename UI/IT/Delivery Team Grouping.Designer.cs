namespace ITP4915M.IT {
    partial class Delivery_Team_Grouping {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tree_Teams = new System.Windows.Forms.TreeView();
            this.list_unteam = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sel_team = new System.Windows.Forms.ComboBox();
            this.bt_addToTeam = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_status_save = new System.Windows.Forms.Button();
            this.rb_status_2 = new System.Windows.Forms.RadioButton();
            this.rb_status_1 = new System.Windows.Forms.RadioButton();
            this.rb_status_0 = new System.Windows.Forms.RadioButton();
            this.bt_createTeam = new System.Windows.Forms.Button();
            this.bt_deleteTeam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
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
            // tree_Teams
            // 
            this.tree_Teams.AllowDrop = true;
            this.tree_Teams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tree_Teams.HideSelection = false;
            this.tree_Teams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tree_Teams.Location = new System.Drawing.Point(6, 21);
            this.tree_Teams.Name = "tree_Teams";
            this.tree_Teams.Size = new System.Drawing.Size(273, 399);
            this.tree_Teams.TabIndex = 2;
            // 
            // list_unteam
            // 
            this.list_unteam.AllowDrop = true;
            this.list_unteam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_unteam.FormattingEnabled = true;
            this.list_unteam.ItemHeight = 12;
            this.list_unteam.Location = new System.Drawing.Point(6, 21);
            this.list_unteam.Name = "list_unteam";
            this.list_unteam.Size = new System.Drawing.Size(278, 316);
            this.list_unteam.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_sel_team);
            this.groupBox1.Controls.Add(this.bt_addToTeam);
            this.groupBox1.Controls.Add(this.list_unteam);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(510, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UnTeam staff";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assign teams";
            // 
            // cb_sel_team
            // 
            this.cb_sel_team.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_sel_team.FormattingEnabled = true;
            this.cb_sel_team.Location = new System.Drawing.Point(9, 371);
            this.cb_sel_team.Name = "cb_sel_team";
            this.cb_sel_team.Size = new System.Drawing.Size(275, 20);
            this.cb_sel_team.TabIndex = 5;
            // 
            // bt_addToTeam
            // 
            this.bt_addToTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addToTeam.Location = new System.Drawing.Point(9, 397);
            this.bt_addToTeam.Name = "bt_addToTeam";
            this.bt_addToTeam.Size = new System.Drawing.Size(275, 23);
            this.bt_addToTeam.TabIndex = 4;
            this.bt_addToTeam.Text = "Add to select team";
            this.bt_addToTeam.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.bt_createTeam);
            this.groupBox2.Controls.Add(this.bt_deleteTeam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tree_Teams);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 426);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teams";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bt_status_save);
            this.groupBox3.Controls.Add(this.rb_status_2);
            this.groupBox3.Controls.Add(this.rb_status_1);
            this.groupBox3.Controls.Add(this.rb_status_0);
            this.groupBox3.Location = new System.Drawing.Point(285, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 117);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Team Status";
            // 
            // bt_status_save
            // 
            this.bt_status_save.Location = new System.Drawing.Point(6, 88);
            this.bt_status_save.Name = "bt_status_save";
            this.bt_status_save.Size = new System.Drawing.Size(201, 23);
            this.bt_status_save.TabIndex = 3;
            this.bt_status_save.Text = "button4";
            this.bt_status_save.UseVisualStyleBackColor = true;
            // 
            // rb_status_2
            // 
            this.rb_status_2.AutoSize = true;
            this.rb_status_2.Location = new System.Drawing.Point(6, 67);
            this.rb_status_2.Name = "rb_status_2";
            this.rb_status_2.Size = new System.Drawing.Size(74, 16);
            this.rb_status_2.TabIndex = 2;
            this.rb_status_2.TabStop = true;
            this.rb_status_2.Tag = "3";
            this.rb_status_2.Text = "In delivery";
            this.rb_status_2.UseVisualStyleBackColor = true;
            // 
            // rb_status_1
            // 
            this.rb_status_1.AutoSize = true;
            this.rb_status_1.Location = new System.Drawing.Point(6, 44);
            this.rb_status_1.Name = "rb_status_1";
            this.rb_status_1.Size = new System.Drawing.Size(56, 16);
            this.rb_status_1.TabIndex = 1;
            this.rb_status_1.TabStop = true;
            this.rb_status_1.Tag = "1";
            this.rb_status_1.Text = "Unable";
            this.rb_status_1.UseVisualStyleBackColor = true;
            // 
            // rb_status_0
            // 
            this.rb_status_0.AutoSize = true;
            this.rb_status_0.Location = new System.Drawing.Point(6, 21);
            this.rb_status_0.Name = "rb_status_0";
            this.rb_status_0.Size = new System.Drawing.Size(70, 16);
            this.rb_status_0.TabIndex = 0;
            this.rb_status_0.TabStop = true;
            this.rb_status_0.Tag = "0";
            this.rb_status_0.Text = "Standy by";
            this.rb_status_0.UseVisualStyleBackColor = true;
            // 
            // bt_createTeam
            // 
            this.bt_createTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_createTeam.Location = new System.Drawing.Point(285, 368);
            this.bt_createTeam.Name = "bt_createTeam";
            this.bt_createTeam.Size = new System.Drawing.Size(219, 23);
            this.bt_createTeam.TabIndex = 5;
            this.bt_createTeam.Text = "Create new team";
            this.bt_createTeam.UseVisualStyleBackColor = true;
            // 
            // bt_deleteTeam
            // 
            this.bt_deleteTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deleteTeam.Location = new System.Drawing.Point(285, 397);
            this.bt_deleteTeam.Name = "bt_deleteTeam";
            this.bt_deleteTeam.Size = new System.Drawing.Size(219, 23);
            this.bt_deleteTeam.TabIndex = 4;
            this.bt_deleteTeam.Text = "Disband selection team";
            this.bt_deleteTeam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(283, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "(You can drag team members to other teams)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Delivery_Team_Grouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Delivery_Team_Grouping";
            this.Text = "Delivery Team Grouping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delivery_Team_Grouping_FormClosed);
            this.Load += new System.EventHandler(this.Delivery_Team_Grouping_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TreeView tree_Teams;
        private System.Windows.Forms.ListBox list_unteam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sel_team;
        private System.Windows.Forms.Button bt_addToTeam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_status_save;
        private System.Windows.Forms.RadioButton rb_status_2;
        private System.Windows.Forms.RadioButton rb_status_1;
        private System.Windows.Forms.RadioButton rb_status_0;
        private System.Windows.Forms.Button bt_createTeam;
        private System.Windows.Forms.Button bt_deleteTeam;
        private System.Windows.Forms.Label label2;
    }
}