using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_CYB
{
    class Methods
    { 
        public void ShowMainMenu(Form screen, bool status, string id, string name)
        {
            MainMenu m = new MainMenu(status, id, name);
            screen.Hide();
            m.ShowDialog();
        }

        public void ShowInsuranceMenu(Form screen, string id, string name)              // Does not have status as parameter because InsuranceMenu.cs can only be accessed when staff is logged in
        {
            InsuranceMenu im = new InsuranceMenu(id, name);
            screen.Hide();
            im.ShowDialog();
        }

        public void ShowUserMenu(Form screen, string id, string name)                   // Does not have status as parameter because UserMenu.cs can only be accessed when staff is logged in
        {
            UserMenu u = new UserMenu(id, name);
            screen.Hide();
            u.ShowDialog();
        }

        public void ShowStaffMenu(Form screen, bool status, string id, string name)
        {
            StaffMenu s = new StaffMenu(status, id, name);
            screen.Hide();
            s.ShowDialog();
        }
    }
}
