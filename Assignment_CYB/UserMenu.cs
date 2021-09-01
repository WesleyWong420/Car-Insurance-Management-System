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
    public partial class UserMenu : Form
    {
        string staff_id;
        string staff_name;

        Methods myMethod = new Methods();                                                      // Instantiate object from class Methods.cs

        public UserMenu(string id, string name)
        {
            InitializeComponent();
            staff_id = id;
            staff_name = name;
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = staff_id;
            lblStaffName.Text = staff_name;

            autoFillCustomerID();
        }

        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowMainMenu(this, true, staff_id, staff_name);
        }

        private void insuranceScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowInsuranceMenu(this, staff_id, staff_name);
        }

        private void staffScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowStaffMenu(this, true, staff_id, staff_name);
        }

        private void registerAdjustment()
        {
            multiButton.Text = "Register";
            multiButton.Enabled = true;
            searchButton.Enabled = false;
            cancelButton.Visible = false;

            autoFillCustomerID();
            customerIDTextBox.Enabled = false;

            foreach (Control toolbox in customerDetailsGroupBox.Controls)
            {
                if (toolbox.Name != "customerIDTextBox" && toolbox is TextBox)
                {
                    toolbox.Enabled = true;
                    toolbox.Text = string.Empty;
                }
            }

            foreach (Control toolbox in vehicleDetailsGroupBox.Controls)
            {
                if (toolbox.Name != "customerIDTextBox" && toolbox is TextBox)
                {
                    toolbox.Enabled = true;
                    toolbox.Text = string.Empty;
                }
            }
        }

        private void updateAdjustment()
        {
            multiButton.Text = "Update";
            multiButton.Enabled = false;
            searchButton.Enabled = true;
            cancelButton.Enabled = false;
            cancelButton.Visible = true;

            customerIDTextBox.Clear();
            customerIDTextBox.Enabled = true;


            foreach (Control toolbox in customerDetailsGroupBox.Controls)
            {
                if (toolbox.Name != "customerIDTextBox" && toolbox is TextBox)
                {
                    toolbox.Enabled = false;
                    toolbox.Text = string.Empty;
                }
            }

            foreach (Control toolbox in vehicleDetailsGroupBox.Controls)
            {
                if (toolbox.Name != "customerIDTextBox" && toolbox is TextBox)
                {
                    toolbox.Enabled = false;
                    toolbox.Text = string.Empty;
                }
            }
        }

        private void newRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            registerAdjustment();
        }

        private void existingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateAdjustment();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (customerIDTextBox.Text != "")                                                 // check for empty field
            {
                Customer customer = new Customer(customerIDTextBox.Text);

                if (customer.CUST_ID != "")                                                   // refer to line 68 in Customer.cs
                {  
                    customerIDTextBox.Enabled = false;
                    customerNumberTextBox.Enabled = true;
                    customerEmailTextBox.Enabled = true;
                    licensePlateTextBox.Enabled = true;
                    cancelButton.Enabled = true;
                    multiButton.Enabled = true;

                    customerNameTextBox.Text = customer.CUST_NAME;
                    customerNumberTextBox.Text = customer.CUST_NUMBER.ToString();
                    customerEmailTextBox.Text = customer.CUST_EMAIL;
                    vehicleModelTextBox.Text = customer.VEHICLE_MODEL;
                    vehicleCostTextBox.Text = customer.VEHICLE_COST.ToString();
                    licensePlateTextBox.Text = customer.CAR_PLATE;
                }
            } 
            else
            {
                MessageBox.Show("Please Enter Customer ID!","Invalid Customer ID");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            customerIDTextBox.Enabled = true;
            cancelButton.Enabled = false;
            multiButton.Enabled = false;
            updateAdjustment();
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            int checkvalue;
            if (customerIDTextBox.Text.Replace(" ", "") != "" && customerNameTextBox.Text.Replace(" ", "") != "" && customerNumberTextBox.Text.Replace(" ", "") != "" && customerEmailTextBox.Text.Replace(" ", "") != "" && vehicleCostTextBox.Text.Replace(" ", "") != "" && vehicleModelTextBox.Text.Replace(" ", "") != "" && licensePlateTextBox.Text.Replace(" ", "") != "") 
            {
                if ((!int.TryParse(customerNumberTextBox.Text, out checkvalue)) || (customerNumberTextBox.Text.Replace("-", "").Length < 8) || (customerNumberTextBox.Text.Replace("-", "").Length > 10))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Invalid Phone Number");        // integer is the only acceptable value type
                }
                else if (!int.TryParse(vehicleCostTextBox.Text, out checkvalue))
                {
                    MessageBox.Show("Please enter numbers only.", "Invalid Vehicle Cost");                // integer is the only acceptable value type
                }
                else
                {
                    OleDbConnection connection = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;");
                    OleDbCommand cmd = connection.CreateCommand();
                    connection.Open();
                    cmd.Connection = connection;

                    if (newRadioButton.Checked)                                          // register
                    {
                        cmd.CommandText = "INSERT INTO Customer(CustomerID,CustomerName, CustomerEmail, CustomerNumber, VehicleModel, VehicleCost, CarPlate) VALUES ('" + customerIDTextBox.Text + "','" + customerNameTextBox.Text + "','" + customerEmailTextBox.Text + "','" + customerNumberTextBox.Text + "','" + vehicleModelTextBox.Text + "','" + vehicleCostTextBox.Text + "','" + licensePlateTextBox.Text + "')";
                        OleDbDataReader writer = cmd.ExecuteReader();
                        MessageBox.Show("Successfully Registered!","Registration");
                        writer.Close();
                        registerAdjustment();
                    }
                    else if (existingRadioButton.Checked)                                // update
                    {
                        cmd.CommandText = "UPDATE Customer SET CustomerEmail = '" + customerEmailTextBox.Text + "', CustomerNumber = '" + customerNumberTextBox.Text + "', CarPlate = '" + licensePlateTextBox.Text + "' WHERE (CustomerID = '" + customerIDTextBox.Text + "' AND CustomerName = '" + customerNameTextBox.Text + "')";
                        OleDbDataReader writer = cmd.ExecuteReader();
                        MessageBox.Show("Details Updated Successfully!","Details Update");
                        writer.Close();
                        updateAdjustment();
                    }    
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required details!","Missing Fields");
            }
        }

        private void autoFillCustomerID()
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;");
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT COUNT(CustomerID) FROM Customer";
            OleDbDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = int.Parse(reader[0].ToString()) + 1;
            }

            if (count < 10)
            {
                customerIDTextBox.Text = "C" + "00" + count;                      // if the next ID is in the ONES place
            }
            else if (count < 100)
            {
                customerIDTextBox.Text = "C" + "0" + count;                       // if the next ID is in the TENS place
            }
            else if (count < 1000)
            {
                customerIDTextBox.Text = "C" + count;                             // if the next ID is in HUNDREDS place
            }

            reader.Close();
            connection.Close();
        }

        private void customerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
