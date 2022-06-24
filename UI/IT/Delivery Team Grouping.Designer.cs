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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery_Team_Grouping));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tree_Teams = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_unteam = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sel_team = new System.Windows.Forms.ComboBox();
            this.bt_addToTeam = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_line = new System.Windows.Forms.Label();
            this.bt_removeFromTeam = new System.Windows.Forms.Button();
            this.gb_team_status = new System.Windows.Forms.GroupBox();
            this.bt_status_save = new System.Windows.Forms.Button();
            this.rb_status_2 = new System.Windows.Forms.RadioButton();
            this.rb_status_1 = new System.Windows.Forms.RadioButton();
            this.rb_status_0 = new System.Windows.Forms.RadioButton();
            this.bt_createTeam = new System.Windows.Forms.Button();
            this.bt_deleteTeam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_team_status.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            // tree_Teams
            // 
            this.tree_Teams.AllowDrop = true;
            resources.ApplyResources(this.tree_Teams, "tree_Teams");
            this.tree_Teams.HideSelection = false;
            this.tree_Teams.ItemHeight = 18;
            this.tree_Teams.Name = "tree_Teams";
            this.tree_Teams.ShowPlusMinus = false;
            this.tree_Teams.ShowRootLines = false;
            this.tree_Teams.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tree_Teams_ItemDrag);
            this.tree_Teams.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_Teams_AfterSelect);
            this.tree_Teams.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_Teams_DragDrop);
            this.tree_Teams.DragEnter += new System.Windows.Forms.DragEventHandler(this.tree_Teams_DragEnter);
            this.tree_Teams.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_Teams_DragOver);
            this.tree_Teams.DragLeave += new System.EventHandler(this.tree_Teams_DragLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_unteam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_sel_team);
            this.groupBox1.Controls.Add(this.bt_addToTeam);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // list_unteam
            // 
            this.list_unteam.AllowDrop = true;
            resources.ApplyResources(this.list_unteam, "list_unteam");
            this.list_unteam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_unteam.FullRowSelect = true;
            this.list_unteam.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list_unteam.HideSelection = false;
            this.list_unteam.Name = "list_unteam";
            this.list_unteam.ShowGroups = false;
            this.list_unteam.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_unteam.UseCompatibleStateImageBehavior = false;
            this.list_unteam.View = System.Windows.Forms.View.Details;
            this.list_unteam.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.list_unteam_ItemDrag);
            this.list_unteam.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_unteam_DragDrop);
            this.list_unteam.DragEnter += new System.Windows.Forms.DragEventHandler(this.tree_Teams_DragEnter);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
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
            // cb_sel_team
            // 
            resources.ApplyResources(this.cb_sel_team, "cb_sel_team");
            this.cb_sel_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sel_team.FormattingEnabled = true;
            this.cb_sel_team.Name = "cb_sel_team";
            // 
            // bt_addToTeam
            // 
            resources.ApplyResources(this.bt_addToTeam, "bt_addToTeam");
            this.bt_addToTeam.Name = "bt_addToTeam";
            this.bt_addToTeam.UseVisualStyleBackColor = true;
            this.bt_addToTeam.Click += new System.EventHandler(this.bt_addToTeam_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_line);
            this.groupBox2.Controls.Add(this.bt_removeFromTeam);
            this.groupBox2.Controls.Add(this.gb_team_status);
            this.groupBox2.Controls.Add(this.bt_createTeam);
            this.groupBox2.Controls.Add(this.bt_deleteTeam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tree_Teams);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lb_line
            // 
            this.lb_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lb_line, "lb_line");
            this.lb_line.Name = "lb_line";
            // 
            // bt_removeFromTeam
            // 
            resources.ApplyResources(this.bt_removeFromTeam, "bt_removeFromTeam");
            this.bt_removeFromTeam.Name = "bt_removeFromTeam";
            this.bt_removeFromTeam.UseVisualStyleBackColor = true;
            this.bt_removeFromTeam.Click += new System.EventHandler(this.bt_removeFromTeam_Click);
            // 
            // gb_team_status
            // 
            resources.ApplyResources(this.gb_team_status, "gb_team_status");
            this.gb_team_status.Controls.Add(this.bt_status_save);
            this.gb_team_status.Controls.Add(this.rb_status_2);
            this.gb_team_status.Controls.Add(this.rb_status_1);
            this.gb_team_status.Controls.Add(this.rb_status_0);
            this.gb_team_status.Name = "gb_team_status";
            this.gb_team_status.TabStop = false;
            // 
            // bt_status_save
            // 
            resources.ApplyResources(this.bt_status_save, "bt_status_save");
            this.bt_status_save.Name = "bt_status_save";
            this.bt_status_save.UseVisualStyleBackColor = true;
            this.bt_status_save.Click += new System.EventHandler(this.bt_status_save_Click);
            // 
            // rb_status_2
            // 
            resources.ApplyResources(this.rb_status_2, "rb_status_2");
            this.rb_status_2.Name = "rb_status_2";
            this.rb_status_2.TabStop = true;
            this.rb_status_2.Tag = "2";
            this.rb_status_2.UseVisualStyleBackColor = true;
            // 
            // rb_status_1
            // 
            resources.ApplyResources(this.rb_status_1, "rb_status_1");
            this.rb_status_1.Name = "rb_status_1";
            this.rb_status_1.TabStop = true;
            this.rb_status_1.Tag = "1";
            this.rb_status_1.UseVisualStyleBackColor = true;
            // 
            // rb_status_0
            // 
            resources.ApplyResources(this.rb_status_0, "rb_status_0");
            this.rb_status_0.Name = "rb_status_0";
            this.rb_status_0.TabStop = true;
            this.rb_status_0.Tag = "0";
            this.rb_status_0.UseVisualStyleBackColor = true;
            // 
            // bt_createTeam
            // 
            resources.ApplyResources(this.bt_createTeam, "bt_createTeam");
            this.bt_createTeam.Name = "bt_createTeam";
            this.bt_createTeam.UseVisualStyleBackColor = true;
            this.bt_createTeam.Click += new System.EventHandler(this.bt_createTeam_Click);
            // 
            // bt_deleteTeam
            // 
            resources.ApplyResources(this.bt_deleteTeam, "bt_deleteTeam");
            this.bt_deleteTeam.Name = "bt_deleteTeam";
            this.bt_deleteTeam.UseVisualStyleBackColor = true;
            this.bt_deleteTeam.Click += new System.EventHandler(this.bt_deleteTeam_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Delivery_Team_Grouping
            // 
            this.AcceptButton = this.bt_status_save;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Delivery_Team_Grouping";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delivery_Team_Grouping_FormClosed);
            this.Load += new System.EventHandler(this.Delivery_Team_Grouping_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gb_team_status.ResumeLayout(false);
            this.gb_team_status.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TreeView tree_Teams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sel_team;
        private System.Windows.Forms.Button bt_addToTeam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_team_status;
        private System.Windows.Forms.Button bt_status_save;
        private System.Windows.Forms.RadioButton rb_status_2;
        private System.Windows.Forms.RadioButton rb_status_1;
        private System.Windows.Forms.RadioButton rb_status_0;
        private System.Windows.Forms.Button bt_createTeam;
        private System.Windows.Forms.Button bt_deleteTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_unteam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button bt_removeFromTeam;
        private System.Windows.Forms.Label lb_line;
    }
}