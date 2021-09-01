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
    public partial class MainMenu : Form
    {
        bool login_status;
        string staff_id;
        string staff_name;
                                                            
        Methods myMethod = new Methods();                           // Instantiate object from class Methods.cs

        public MainMenu(bool status, string id, string name)        // receive login status, staff id and staff name
        {
            InitializeComponent();
            login_status = status;
            staff_id = id;
            staff_name = name;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (!login_status)                                     // not logged in 
            {
                LoggedOutAdjustment();
            }
            else
            {
                LoggedInAdjustment();
            }
        }

        private void LoggedOutAdjustment()
        {
            lblStaffID.Visible = false;
            lblStaffName.Visible = false;

            insuranceScreenButton.Enabled = false;
            customerScreenButton.Enabled = false;
        }

        private void LoggedInAdjustment()
        {
            lblStaffID.Visible = true;
            lblStaffName.Visible = true;

            insuranceScreenButton.Enabled = true;
            customerScreenButton.Enabled = true;

            lblStaffID.Text = staff_id;
            lblStaffName.Text = staff_name;
        }

        private void showcaseButton1_Click(object sender, EventArgs e)
        {
            if (!login_status)
            {
                myMethod.ShowStaffMenu(this, login_status, staff_id, staff_name);  // 1st parameter (this) refer to the current forms to call the this.Close method
            }                                               
            else
            {
                myMethod.ShowInsuranceMenu(this, staff_id, staff_name);
            }
        }

        private void showcaseButton2_Click(object sender, EventArgs e)
        {
            if (!login_status)
            {
                myMethod.ShowStaffMenu(this, login_status, staff_id, staff_name);
            }
            else
            {
                myMethod.ShowInsuranceMenu(this, staff_id, staff_name);
            }
        }

        private void showcaseButton3_Click(object sender, EventArgs e)
        {
            if (!login_status)
            {
                myMethod.ShowStaffMenu(this, login_status, staff_id, staff_name);
            }
            else
            {
                myMethod.ShowInsuranceMenu(this, staff_id, staff_name);
            }
        }

        private void insuranceScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowInsuranceMenu(this, staff_id, staff_name);
        }

        private void customerScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowUserMenu(this, staff_id, staff_name);
        }

        private void staffScreenButton_Click(object sender, EventArgs e)
        {
            myMethod.ShowStaffMenu(this, login_status, staff_id, staff_name);
        }
    }
}
