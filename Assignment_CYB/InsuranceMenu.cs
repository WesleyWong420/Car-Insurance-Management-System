using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_CYB
{                                                                           
    public partial class InsuranceMenu : Form
    {
        public string staff_id;
        string staff_name;

        Methods myMethod = new Methods();                                  // Instantiate object from class Methods.cs
        Customer myCustomer = new Customer();                              // Instantiate object from class Customer.cs by using Parameterless constructor

        public InsuranceMenu(string id, string name)
        {
            InitializeComponent();
            staff_id = id;
            staff_name = name;
        }

        private void InsuranceMenu_Load(object sender, EventArgs e)
        {
            lblStaffID.Text = staff_id;
            lblStaffName.Text = staff_name;
        }

        private void homeScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowMainMenu(this, true, staff_id, staff_name);
        }

        private void customerScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowUserMenu(this, staff_id, staff_name);
        }

        private void staffScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowStaffMenu(this, true, staff_id, staff_name);
        }

        private void PostAdjustment()
        {
            customerIDTextBox.Enabled = true;
            lblCustomerName.Visible = false;

            foreach (Control toolbox in insuranceDetailsGroupBox.Controls)
            {
                if ((toolbox.Name.StartsWith("lbl") && toolbox is Label) || toolbox is ComboBox || toolbox is DateTimePicker)
                {
                    toolbox.Visible = false;
                }
            }

            cancelButton.Enabled = false;
            multiButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (customerIDTextBox.Text != "")                               // check for empty field
            {
                Customer customer = new Customer(customerIDTextBox.Text);

                if (customer.CUST_ID != "")                                 // refer to line 68 in Customer.cs
                {
                    customerIDTextBox.Enabled = false;
                    cancelButton.Enabled = true;
                    multiButton.Enabled = true;
                    insuranceTypeComboBox.Enabled = true;
                    insuranceDateTimePicker.Enabled = true;

                    lblCustomerName.Text = customer.CUST_NAME;
                    lblInsuranceDuration.Text = customer.INSURANCE_DURATION.ToString();
                    lblVehicleModel.Text = customer.VEHICLE_MODEL;
                    lblVehicleCost.Text = "MYR " + customer.VEHICLE_COST.ToString();
                    lblLastClaimDate.Text = customer.LAST_CLAIM_DATE;
                    lblNCDEntitlement.Text = (customer.DISCOUNT_PERCENTAGE * 100).ToString() + "%";

                    insuranceTypeComboBox.SelectedIndex = customer.INSURANCE_INDEX;
                    insuranceDateTimePicker.Value = DateTime.Today;         // default date is set to the current day

                    foreach (Control toolbox in insuranceDetailsGroupBox.Controls)
                    {
                        if ((toolbox.Name.StartsWith("lbl") && toolbox is Label) || toolbox is ComboBox || toolbox is DateTimePicker)
                        {
                            toolbox.Visible = true;
                        }
                    }

                    lblCustomerName.Visible = true;                         // same action in line 90, but because lblCustomerName is inside customerDetailsGroupBox, not insuranceDetailsGroupBox, so this line 87 had to be called explicitly

                    bool insurance_ownership = customer.insuranceOwnership();

                    if (!insurance_ownership)                               // brand new customer
                    {
                        multiButton.Text = "Purchase";
                    }
                    else                                                    // existing customer
                    {
                        multiButton.Text = "Renew";
                    }

                    myCustomer = customer;                                  // overwritting the object of parameterless constructor with the object customer that we are currently accessing
                }                                                           // to preserve it's fields and attributes so that we can use them at line 135 of button click event handler
            }                                                               // The reason behind this is because the current customer we are currently accessing is only available within this context (searchButton_click event handler)
            else                                                            // Hence we need a way to export this current object out of this context and into another event handler in line 135.
            {
                MessageBox.Show("Please Enter Customer ID");

                foreach (Control toolbox in insuranceDetailsGroupBox.Controls)
                {
                    if (toolbox.Name.StartsWith("lbl") && toolbox is Label)
                    {
                        toolbox.Text = string.Empty;
                    }
                }

                lblCustomerName.Text = string.Empty;                      // same action in line 112, but because lblCustomerName is inside customerDetailsGroupBox, not insuranceDetailsGroupBox, so this line 120 had to be called explicitly
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            PostAdjustment();
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            string insurance_id;
            if (insuranceDateTimePicker.Value < DateTime.Today)           // Insurance Start Date selected is a date before the current day
            {
                MessageBox.Show("You can't choose this date!", "Invalid Start Date");
            }
            else
            {
                if (multiButton.Text == "Purchase")                       // purchase
                {
                    if (insuranceTypeComboBox.SelectedIndex != -1)        // Index -1 indicated no selection
                    {
                        insurance_id = myCustomer.setRate_getID(insuranceTypeComboBox.SelectedIndex);
                        myCustomer.calculateTotalPayableAmount("Purchase");
                        myCustomer.updateQuery(insurance_id, customerIDTextBox.Text);
                        PostAdjustment();
                    }
                    else
                    {
                        MessageBox.Show("Please select an Insurance Package!", "Invalid Insurance Package");
                    }
                }
                else                                                      // renew
                {
                    if (int.Parse(lblInsuranceDuration.Text) > 2)
                    {
                        MessageBox.Show("You can only renew up to 2 months in advanced!", "Renewal Disapprove");
                    }
                    else
                    {
                        insurance_id = myCustomer.setRate_getID(insuranceTypeComboBox.SelectedIndex);
                        myCustomer.calculateTotalPayableAmount("Renew");
                        myCustomer.updateQuery(insurance_id, customerIDTextBox.Text);
                        PostAdjustment();
                    }
                }
            }
        }
    }
}
