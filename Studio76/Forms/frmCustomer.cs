using CrystalDecisions.CrystalReports.Engine;
using Studio76.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio76.Forms
{
    public partial class frmCustomer : Form
    {
        //Connections
        private string connectionString = Helper.connectionString;

        private DataSet dsStudio = new DataSet();
        private SqlDataAdapter daCustomer;
        private List<Customer> allCustomers = new List<Customer>();

        public bool isEditOpen;

        public frmCustomer()
        {
            InitializeComponent();

            //Setup DOB picker
            DateTime minAge = DateTime.Now.AddYears(-18);
            dtDOB.MaxDate = minAge;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                //Input into database
                try
                {
                    int id = GetCustomerID();
                    string forename = txtCustomerForename.Text;
                    string surname = txtCustomerSurname.Text;

                    string street = txtStreet.Text;
                    string town = txtTown.Text;
                    string county = txtTown.Text;
                    string postcode = txtPostcode.Text;

                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;

                    string dob = dtDOB.Value.ToString("yyyy-M-d");

                    string sql = @"INSERT INTO Customer (CustomerID, CustomerForename, CustomerSurname, CustomerDOB, Street, Town, County, PostCode, TelNo, Email) VALUES " + 
                        "('" + id+ "', '" + forename+ "','" + surname+ "', '" + dob + "','" + street+ "','" + town+ "','" + county+ "','" + postcode+ "','" + phone+ "','" + email +"')";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand addCustomer = new SqlCommand(sql, conn);
                        conn.Open();

                        SqlDataReader customerReader = addCustomer.ExecuteReader();
                        while (customerReader.Read()) { }
                        conn.Close();
                    }

                    MessageBox.Show("Customer Successfuly Created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating customer! Please try again.\n" + ex.Message, "Error Creating Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearInput()
        {
            DateTime minAge = DateTime.Now.AddYears(-18);
            dtDOB.MaxDate = minAge;
            txtCustomerForename.Text = "";
            txtCustomerSurname.Text = "";

            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";

            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private bool ValidateInputs()
        {
            bool success = true;
            string errorText = "";

            string forename = txtCustomerForename.Text;
            string surname = txtCustomerSurname.Text;

            string street = txtStreet.Text;
            string town = txtTown.Text;
            string county = txtTown.Text;
            string postcode = txtPostcode.Text;

            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            //forename
            if (string.IsNullOrEmpty(forename) == false && forename.Contains(" ") == false && Regex.IsMatch(forename, @"^[a-zA-Z]+$") && forename.Length >= 3)
            {
                //Forename is valid
            }
            else
            {
                errorText += "Forename must be only letters and cannot contain any spaces! It must also be 3 or more characters long!\n";
                success = false;
            }

            //surname
            if (string.IsNullOrEmpty(surname) == false && surname.Contains(" ") == false && Regex.IsMatch(surname, @"^[a-zA-Z]+$") && surname.Length >= 3)
            {
                //Surname is valid
            }
            else
            {
                errorText += "Surname must be only letters and cannot contain any spaces! It must also be 3 or more characters long!\n";
                success = false;
            }

            //street
            if(string.IsNullOrEmpty(street) == false && street.Length >= 3)
            {
                //Street is valid
            }
            else
            {
                errorText += "Street must not be empty and must be 3 or more characters long!\n";
                success = false;
            }

            //town
            if (string.IsNullOrEmpty(town) == false && town.Length >= 3)
            {
                //Town is valid
            }
            else
            {
                errorText += "Town must not be empty and must be 3 or more characters long!\n";
                success = false;
            }

            //County
            if (string.IsNullOrEmpty(county) == false && county.Length >= 3)
            {
                //County is valid
            }
            else
            {
                errorText += "County must not be empty and must be 3 or more characters long!\n";
                success = false;
            }

            //Postcode
            if (string.IsNullOrEmpty(postcode) == false && Regex.IsMatch(postcode, @"^[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]+$"))
            {
                //Postcode is valid
            }
            else
            {
                errorText += "Postcode is invalid, it must not be empty and must be in the format of XX00 0XX!\n";
                success = false;
            }

            //Phone
            if (string.IsNullOrEmpty(phone) == false && Regex.IsMatch(phone, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]+$")) 
            {
                //Phone is valid
            }
            else
            {
                errorText += "Phone is invalid, it must not be empty and must be 11 characters long!\n";
                success = false;
            }

            string emailRegex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+ "@"+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            //Email
            if (string.IsNullOrEmpty(email) == false && Regex.IsMatch(email, emailRegex))
            {
                //Email is valid
            }
            else
            {
                errorText += "Email is not valid!";
                success = false;
            }

            if(success == false)
            {
                MessageBox.Show(errorText, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }

        private int GetCustomerID()
        {
            int customerID = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand getCount = new SqlCommand("SELECT CustomerID FROM Customer", conn);
                    conn.Open();

                    SqlDataReader countReader = getCount.ExecuteReader();

                    int id = -1;

                    while(countReader.Read())
                    {
                        id = Int32.Parse(countReader[0].ToString());
                    }
                    conn.Close();

                    //Assign Booking Variables
                    customerID = id + 1;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Getting Next Customer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return customerID;
        }

        private void tcBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        public void GetAllCustomers()
        {
            allCustomers.Clear();

            string sqlCustomer = @"SELECT * FROM Customer";

            daCustomer = new SqlDataAdapter(sqlCustomer, connectionString);
            daCustomer.FillSchema(dsStudio, SchemaType.Source, "Customers");

            daCustomer.Fill(dsStudio, "Customers");

            foreach (DataRow dr in dsStudio.Tables["Customers"].Rows)
            {
                Customer c = new Customer();
                c.CustomerID = Int32.Parse(dr["CustomerID"].ToString());
                c.CustomerForename = dr["CustomerForename"].ToString();
                c.CustomerSurname = dr["CustomerSurname"].ToString();
                c.DOB = dr["CustomerDOB"].ToString();
                c.Street = dr["Street"].ToString();
                c.Town = dr["Town"].ToString();
                c.County = dr["County"].ToString();
                c.Postcode = dr["PostCode"].ToString();
                c.Phone = dr["TelNo"].ToString();
                c.Email = dr["Email"].ToString();

                allCustomers.Add(c);
            }

            UpdateEditCustomerView();
            UpdateDeleteCustomerView();
        }

        private void UpdateEditCustomerView()
        {
            dgvEditCustomer.DataSource = allCustomers.Select(Customer => new {
                Customer.CustomerID,
                Customer.CustomerForename,
                Customer.CustomerSurname,
                Customer.DOB,
                Customer.Street,
                Customer.Town,
                Customer.County,
                Customer.Phone,
                Customer.Email
            }).ToList();
        }

        private void UpdateDeleteCustomerView()
        {
            dgvDeleteCustomer.DataSource = allCustomers.Select(Customer => new {
                Customer.CustomerID,
                Customer.CustomerForename,
                Customer.CustomerSurname,
                Customer.DOB,
                Customer.Street,
                Customer.Town,
                Customer.County,
                Customer.Phone,
                Customer.Email
            }).ToList();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Customer c = GetSelectedCustomer();

            if(c != null)
            {
                if(isEditOpen == false)
                {
                    isEditOpen = true;
                    frmEditCustomer ec = new frmEditCustomer();
                    ec.Master = this;
                    ec.currentCustomer = c;
                    ec.Show();
                }
                else
                {
                    MessageBox.Show("Edit for is already open, please close it to open another!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error Selecting Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Customer GetSelectedCustomer()
        {
            foreach (DataGridViewRow row in dgvEditCustomer.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                foreach (Customer customer in allCustomers)
                {
                    if (id == customer.CustomerID)
                    {
                        return customer;
                    }
                }
            }

            return null;
        }

        private Customer GetSelectedCustomerDelete()
        {
            foreach (DataGridViewRow row in dgvDeleteCustomer.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                foreach (Customer customer in allCustomers)
                {
                    if (id == customer.CustomerID)
                    {
                        return customer;
                    }
                }
            }

            return null;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer c = GetSelectedCustomerDelete();

            if(c != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the customer?", "Delete Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //Delete
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string sql = @"DELETE FROM Customer WHERE CustomerID = '" + c.CustomerID + "'";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            conn.Open();

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            int id = 0;

                            foreach (Customer customer in allCustomers)
                            {
                                if (customer.CustomerID == c.CustomerID)
                                {
                                    id = allCustomers.IndexOf(customer);
                                }
                            }

                            allCustomers.RemoveAt(id);

                            GetAllCustomers();

                            UpdateEditCustomerView();
                            UpdateDeleteCustomerView();

                            dgvDeleteCustomer.Update();
                            dgvEditCustomer.Update();

                            MessageBox.Show("Customer Successfully Deleted", "Customer Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Deleting Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                 
                }
            }
            else
            {
                MessageBox.Show("Error Selecting Customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAllCustomers_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Users\gal16100778\source\repos\Studio76\Studio76\Reports\Customers.rpt");

            crvReports.ReportSource = report;
            crvReports.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
