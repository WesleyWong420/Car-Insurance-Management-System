using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_CYB
{
    class Staff
    {

        private string StaffID;
        private string StaffName;
        private string StaffPassword;

        public Staff()
        {
            StaffID = "";
            StaffName = "";
            StaffPassword = "";
        }

        public string STAFF_ID
        {
            get { return StaffID; }
            set { StaffID = value; }
        }

        public string STAFF_NAME
        {
            get { return StaffName; }
            set { StaffName = value; }
        }

        public string STAFF_PASSWORD
        {
            get { return StaffPassword; }
            set { StaffPassword = value; }
        }
    }
}
