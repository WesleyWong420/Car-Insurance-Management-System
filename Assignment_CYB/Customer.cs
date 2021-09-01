using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment_CYB
{
    class Customer
    {
        private string CustID;
        private string CustName;
        private string CustEmail;
        private int CustNumber;
        private string VehicleModel;
        private double VehicleCost;
        private string CarPlate;

        private int InsuranceIndex;
        private int InsuranceDuration;
        private string LastClaimDate;
        private double DiscountPercentage;
        private double InsuranceRate;
        public Customer()                                                                           // Parameterless Constructor (To be instatiated in the beginning of InsuranceMenu)
        { 
            // pass
        }

        public Customer(string customer_id)                                                         // Constructor Overloading with string as parameter to pass customer_id in order to access database.
        {                                                                                           // This constructor is the default constructor that will be used to create a customer object when 
            string InsuranceID;                                                                     // the Search button is clicked in InsuranceMenu.cs and UserMenu.cs (To be instatiated in event handler) 

            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;");
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "SELECT * FROM Customer WHERE (CustomerID = '" + customer_id + "')";  // Main query statement to retrieve information of a customer
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())                                                                      // assign value to class fields when a match is found in database
            {
                CustID = reader[0].ToString();
                CustName = reader[1].ToString();
                CustEmail = reader[2].ToString();
                CustNumber = int.Parse(reader[3].ToString());
                VehicleModel = reader[4].ToString();
                VehicleCost = double.Parse(reader[5].ToString());
                CarPlate = reader[6].ToString();

                InsuranceID = reader[7].ToString();
                InsuranceDuration = int.Parse(reader[8].ToString());
                LastClaimDate = reader[9].ToString();
                DiscountPercentage = double.Parse(reader[10].ToString());

                reader.Close();
                cmd.CommandText = "SELECT * FROM Insurance WHERE (InsuranceID = '" + InsuranceID + "')";  // Sub query statement to retrieve InsuranceIndex and InsuranceRate from InsuranceTable
                OleDbDataReader reader2 = cmd.ExecuteReader();                                            // by using Foreign Key InsuranceID from CustomerTable

                if (reader2.Read())
                {
                    InsuranceIndex = int.Parse(reader2[1].ToString());
                }
                reader2.Close();
            }
            else
            {
                CustID = "";                                                // If customer is not found, set CustID field to empty string
                MessageBox.Show("Customer Not Found!");                     // We will use this to decide whether a series of code is to be executed after Customer object instatiation
            }                                                               // refer to line 72 in InsuranceMenu.cs
            reader.Close();
            connection.Close();
        }

        public string CUST_ID
        {
            get { return CustID; }
            set { CustID = value; }
        }

        public string CUST_NAME
        {
            get { return CustName; }
            set { CustName = value; }
        }
        public string CUST_EMAIL
        {
            get { return CustEmail; }
            set { CustEmail = value; }
        }

        public int CUST_NUMBER
        {
            get { return CustNumber; }
            set { CustNumber = value; }
        }

        public string VEHICLE_MODEL
        {
            get { return VehicleModel; }
            set { VehicleModel = value; }
        }

        public double VEHICLE_COST
        {
            get { return VehicleCost; }
            set { VehicleCost = value; }
        }

        public string CAR_PLATE
        {
            get { return CarPlate; }
            set { CarPlate = value; }
        }

        public int INSURANCE_INDEX
        {
            get { return InsuranceIndex; }
            set { InsuranceIndex = value; }
        }

        public int INSURANCE_DURATION
        {
            get { return InsuranceDuration; }
            set { InsuranceDuration = value; }
        }

        public string LAST_CLAIM_DATE
        {
            get { return LastClaimDate; }
            set { LastClaimDate = value; }
        }

        public double DISCOUNT_PERCENTAGE
        {
            get { return DiscountPercentage; }
            set { DiscountPercentage = value; }
        }
        public double INSURANCE_RATE
        {
            get { return InsuranceRate; }
            set { InsuranceRate = value; }
        }

        public bool insuranceOwnership()
        {
            if (InsuranceIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string setRate_getID(int index)                                   // We can easily use the selected InsuranceIndex determine it's corresponding InsuranceID and Rate
        {                                                                        // This method is identical as the query {SELECT * FROM Insurance WHERE (InsuranceIndex = index)}
            string insurance_id = "";                                            // But we are using this direct and simple approach to avoid the need to open another database connection
            if (index == 0)                                                      // Moreover, we are only dealing with 3 types of insurance package which all it's attributes are well-known.
            {
                InsuranceRate = 0.0266;
                insurance_id = "I001";
            }
            else if (index == 1)
            {
                InsuranceRate = 0.0275;
                insurance_id = "I002";
            }
            else if (index == 2)
            {
                InsuranceRate = 0.0284;
                insurance_id = "I003";
            }

            return insurance_id;
        }

        public void calculateTotalPayableAmount(string keyword)                 // parameter keyword can be either "Purchased" or "Renewed"
        {
            const int stamp_duty = 10;
            const double SST = 0.06;

            double gross_total = VehicleCost * InsuranceRate;
            double total = gross_total + (gross_total * SST) + stamp_duty;
            double grand_total = total - (total * DiscountPercentage);

            MessageBox.Show("Successfully " + keyword + "! Total Amount: " + grand_total.ToString());
        }

        public void updateQuery(string insurance_id, string cust_id)          
        {
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=IOOPAssignment.mdb;");
            OleDbCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "UPDATE Customer SET InsuranceID = '" + insurance_id + "', InsuranceDuration = 12 WHERE (CustomerID = '" + cust_id + "')";  // New insurance cycle will be 12 months by default
            OleDbDataReader writer = cmd.ExecuteReader();
            writer.Close();
            connection.Close();
        }
    }
}
