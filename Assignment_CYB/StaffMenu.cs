using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment_CYB
{
    public partial class StaffMenu : Form
    {
        bool login_status;
        string staff_id;
        string staff_name;

        Methods myMethod = new Methods();                                               // Instantiate object from class Methods.cs      

        public StaffMenu(bool status, string id, string name)
        {
            InitializeComponent();
            login_status = status;
            staff_id = id;
            staff_name = name;
        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {
            if (!login_status)
            {
                LoggedOutAdjustment();
            }
            else
            {
                LoggedInAdjustment();
            }
        }

        public void LoggedOutAdjustment()
        {
            login_status = false;

            lblStaffID.Visible = false;
            lblStaffName.Visible = false;

            insuranceScreenButton.Enabled = false;
            customerScreenButton.Enabled = false;

            multiButton.Text = "Login";

            newRadioButton.Enabled = true;
            existingRadioButton.Enabled = true;
            existingRadioButton.Checked = true;

            foreach (Control toolbox in this.Controls)
            {
                if (toolbox is TextBox)
                {
                    toolbox.Text = string.Empty;
                    toolbox.Enabled = true;
                }
            }
        }

        public void LoggedInAdjustment()
        {
            login_status = true;

            lblStaffID.Visible = true;
            lblStaffName.Visible = true;

            insuranceScreenButton.Enabled = true;
            customerScreenButton.Enabled = true;

            multiButton.Text = "Log Out";

            newRadioButton.Enabled = false;
            existingRadioButton.Enabled = false;

            foreach (Control toolbox in this.Controls)
            {
                if (toolbox is TextBox)
                {
                    toolbox.Enabled = false;
                }
            }

            lblStaffID.Text = staff_id;
            lblStaffName.Text = staff_name;
        }

        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowMainMenu(this, login_status, staff_id, staff_name);
        }

        private void insuranceScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowInsuranceMenu(this, staff_id, staff_name);
        }

        private void customerScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowUserMenu(this, staff_id, staff_name);
        }

        private void existingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            multiButton.Text = "Login";
            staffIDTextBox.Enabled = true;

            foreach (Control toolbox in this.Controls)
            {
                if ( toolbox is TextBox)
                {
                    toolbox.Text = string.Empty;
                }
            }
        }
        private void newRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            multiButton.Text = "Register";
            staffIDTextBox.Enabled = false;
            
            foreach (Control toolbox in this.Controls)
            {
                if (toolbox is TextBox)
                {
                    toolbox.Text = string.Empty;
                }
            }

            autoFillStaffID();
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            if(!login_status)
            {
                if (staffIDTextBox.Text.Replace(" ","") != "" && staffnameTextBox.Text.Replace(" ", "") != "" && passwordTextBox.Text.Replace(" ", "") != "") // check for empty fields, while eliminating blank characters
                {
                    Staff staff = new Staff();                                                              // Instantiate an object from class Staff.cs

                    OleDbConnection connection = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;");
                    OleDbCommand cmd = connection.CreateCommand();
                    connection.Open();
                    cmd.Connection = connection;

                    if (newRadioButton.Checked == true)                                                    // register (allow same name and password for different staff, but will have different StaffID)
                    {
                        cmd.CommandText = "INSERT INTO Staff(StaffID,StaffName,StaffPassword) VALUES ('" + staffIDTextBox.Text + "','" + staffnameTextBox.Text + "','" + passwordTextBox.Text + "')";
                        OleDbDataReader writer = cmd.ExecuteReader();
                        MessageBox.Show("Successfully Registered!","Registration");
                        LoggedOutAdjustment();
                        writer.Close();
                    }
                    else if (existingRadioButton.Checked == true)                                          // login
                    {
                        cmd.CommandText = "SELECT * FROM Staff WHERE (StaffID = '" + staffIDTextBox.Text + "') AND (StaffName = '" + staffnameTextBox.Text + "') AND (StaffPassword = '" + passwordTextBox.Text + "')";
                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())                                                                 // if a match is found in the database
                        {
                            staff.STAFF_ID = reader[0].ToString();
                            staff.STAFF_NAME = reader[1].ToString();
                            staff_id = staff.STAFF_ID;
                            staff_name = staff.STAFF_NAME;
                            LoggedInAdjustment();
                            MessageBox.Show("Successfully log in!","Log in");
                        }
                        else
                        {
                            MessageBox.Show("Please re-enter the credentials!","Invalid Credentials");
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in all required details!","Missing Field");
                }
            }
            else                                                                                           // logout
            {
                staff_id = "";
                staff_name = "";
                LoggedOutAdjustment();
            }
        }

        private void autoFillStaffID()
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;");
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT COUNT(StaffID) FROM Staff";
            OleDbDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = int.Parse(reader[0].ToString()) + 1;
            }

            if (count < 10)
            {
                staffIDTextBox.Text = "S" + "00" + count;                                                  // if the next ID is in the ONES place
            }
            else if (count < 100)
            {
                staffIDTextBox.Text = "S" + "0" + count;                                                   // if the next ID is in the TENS place
            }
            else if (count < 1000)
            {
                staffIDTextBox.Text = "S" + count;                                                         // if the next ID is in HUNDREDS place
            }

            reader.Close();
            connection.Close();
        }

        private void staffnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
