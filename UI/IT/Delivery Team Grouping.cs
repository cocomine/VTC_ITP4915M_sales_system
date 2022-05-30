using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace ITP4915M.IT {
    public partial class Delivery_Team_Grouping : Form {

        private MySqlConnection conn;

        public Delivery_Team_Grouping(MySqlConnection conn) {
            this.conn = conn;
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Delivery_Team_Grouping_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Delivery_Team_Grouping_Load(object sender, EventArgs e) {
            Program.addPage();

            ShowDeliveryTeam();
            tree_Teams.ExpandAll(); //Expand tree

            ShowUnTeamStaff();
        }

        private void ShowUnTeamStaff() {
            //get unteam staff
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT staff.AccountID, staff.FullRealName FROM staff WHERE staff.AccountID NOT IN(SELECT delivery_team_staff.StaffAccountID FROM delivery_team_staff) AND staff.DepartmentID = " + Department.Delivery, conn);
                MySqlDataReader unTeamStaffData = cmd.ExecuteReader();

                if (unTeamStaffData.HasRows) {
                    list_unteam.Items.Clear(); //clear all item
                    while (unTeamStaffData.Read()) {

                        //setup ListViewItem
                        ListViewItem listViewItem = new ListViewItem(new String[] { unTeamStaffData.GetString("AccountID"), unTeamStaffData.GetString("FullRealName") }) {
                            Tag = unTeamStaffData.GetString("AccountID")
                        };
                        list_unteam.Items.Add(listViewItem); //add in
                    }
                }
                unTeamStaffData.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void ShowDeliveryTeamStaff() {
            //get delivery team staff
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT d.Delivery_TeamID, s.AccountID, s.FullRealName FROM delivery_team_staff d, staff s WHERE d.StaffAccountID = s.AccountID ORDER BY Delivery_TeamID ASC;", conn);
                MySqlDataReader teamStaffData = cmd.ExecuteReader();

                if (teamStaffData.HasRows) {
                    while (teamStaffData.Read()) {

                        //setup treeNode
                        TreeNode treeNode = new TreeNode(teamStaffData.GetString("FullRealName") + " (" + teamStaffData.GetString("AccountID") + ")") {
                            Name = teamStaffData.GetString("AccountID")
                        };
                        tree_Teams.Nodes[teamStaffData.GetString("Delivery_TeamID")].Nodes.Add(treeNode); //add in
                    }
                }
                teamStaffData.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void ShowDeliveryTeam() {
            //Get delivery team
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM delivery_team ORDER BY TeamID ASC;", conn);
                MySqlDataReader teamData = cmd.ExecuteReader();

                if (!teamData.HasRows) {
                    MessageBox.Show("No team exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    tree_Teams.Nodes.Clear(); //clear all node
                    while (teamData.Read()) {

                        //setup treeNode
                        TreeNode treeNode = new TreeNode("Team - " + teamData.GetString("TeamID")) {
                            Name = teamData.GetString("TeamID"),
                            Tag = teamData.GetInt32("Status"),
                        };

                        tree_Teams.Nodes.Add(treeNode); //add in
                        cb_sel_team.Items.Add(teamData.GetString("TeamID")); //add 'cb_sel_team' list
                    }
                }
                teamData.Close();
                ShowDeliveryTeamStaff(); //show in team staff
            } catch (MySqlException ex) {
                MessageBox.Show("Unable to disband the team.\nMaybe the team still has orders that have not been completed.", "Disband team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void tree_Teams_AfterSelect(object sender, TreeViewEventArgs e) {
            //treeNode team selected
            TreeNode node = tree_Teams.SelectedNode; //get node
            if (node.Tag != null) { //check is Team node
                cb_sel_team.SelectedItem = node.Name; //set 'cb_sel_team' select item

                //set team status radio button
                if ((int)node.Tag == Delivery_team.StandBy) rb_status_0.Checked = true;
                if ((int)node.Tag == Delivery_team.Unable) rb_status_1.Checked = true;
                if ((int)node.Tag == Delivery_team.InDelivery) rb_status_2.Checked = true;
            }
        }

        private void bt_createTeam_Click(object sender, EventArgs e) {
            //create new team
            try {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `delivery_team` (`TeamID`, `Status`) VALUES (NULL, '0'); SELECT LAST_INSERT_ID() AS TeamID;", conn);
                MySqlDataReader data = cmd.ExecuteReader();
                    while (data.Read()) {

                        //setup treeNode
                        TreeNode treeNode = new TreeNode("Team - " + data.GetString("TeamID")) {
                            Name = data.GetString("TeamID"),
                            Tag = 0
                        };
                        tree_Teams.Nodes.Add(treeNode); //add in

                        cb_sel_team.Items.Add(data.GetString("TeamID")); //add 'cb_sel_team' list
                    }
                data.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void bt_deleteTeam_Click(object sender, EventArgs e) {
            //delete team
            if(tree_Teams.SelectedNode == null) return; //check is select?
            DialogResult result = MessageBox.Show("Are you sure you want to disband the selected team?", "Disband team", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {

                try {
                    //del from database
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM delivery_team WHERE TeamID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", tree_Teams.SelectedNode.Name);
                    cmd.ExecuteNonQuery();

                    tree_Teams.Nodes.Remove(tree_Teams.SelectedNode); //del from treeView
                    ShowUnTeamStaff();
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
        }

        private void bt_addToTeam_Click(object sender, EventArgs e) {
            //add unteam staff in to team
            String teamID = (String) cb_sel_team.SelectedItem;
            ListView.SelectedListViewItemCollection items = list_unteam.SelectedItems;
            if (cb_sel_team.SelectedIndex < 0 || items.Count <= 0) return; //check is select?

            //update database
            try {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO delivery_team_staff (Delivery_TeamID, StaffAccountID) VALUES (@TeamID, @AccountID)", conn);
                cmd.Parameters.AddWithValue("@TeamID", teamID);
                cmd.Parameters.AddWithValue("@AccountID", "");

                //loop all selects item
                foreach (ListViewItem item in items) {
                    cmd.Parameters["@AccountID"].Value = item.SubItems[0].Text; //set value
                    cmd.ExecuteNonQuery();

                    //setup treenode
                    TreeNode treenode = new TreeNode(item.SubItems[1].Text + " (" + item.SubItems[0].Text + ")") {
                        Name = item.SubItems[0].Text
                    };
                    list_unteam.Items.Remove(item); //remove from 'list_unteam'
                    tree_Teams.Nodes[teamID].Nodes.Add(treenode); //Add in
                }
            }catch(MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
            tree_Teams.ExpandAll();
        }

        private void bt_status_save_Click(object sender, EventArgs e) {
            //save delivery team status
            if (tree_Teams.SelectedNode == null) return; //check is select?
            RadioButton checkedButton = gb_team_status.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked); //get check radio button
            if (checkedButton == null) return; //check radio is check?

            try {
                MySqlCommand cmd = new MySqlCommand("UPDATE delivery_team SET Status = @Status WHERE TeamID = @TeamID", conn);
                cmd.Parameters.AddWithValue("@Status", Int32.Parse(checkedButton.Tag.ToString()));
                cmd.Parameters.AddWithValue("@TeamID", Int32.Parse(tree_Teams.SelectedNode.Name));
                cmd.ExecuteNonQuery();

                tree_Teams.SelectedNode.Tag = checkedButton.Tag.ToString();
                MessageBox.Show("Update Status successfully!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void bt_removeFromTeam_Click(object sender, EventArgs e) {
            //unteam the staff
            if(tree_Teams.SelectedNode == null) return; //check is select
            if(tree_Teams.SelectedNode.Tag != null) return; //check is not select team node

            TreeNode node = tree_Teams.SelectedNode;
            String accountID = node.Name.ToString();

            //update databass
            try {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM delivery_team_staff WHERE StaffAccountID = @id", conn);
                cmd.Parameters.AddWithValue("@id", accountID);
                cmd.ExecuteNonQuery();

                //update UI
                ShowUnTeamStaff();
                tree_Teams.Nodes[tree_Teams.SelectedNode.Parent.Name].Nodes.Remove(node);
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }
    }
}
