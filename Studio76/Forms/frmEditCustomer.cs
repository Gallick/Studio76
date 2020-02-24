using Studio76.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio76.Forms
{
    public partial class frmEditCustomer : Form
    {
        private string connectionString = Helper.connectionString;

        public frmCustomer Master;
        public Customer currentCustomer;

        public frmEditCustomer()
        {
            InitializeComponent();
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerInformation();

            dtDOB.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void LoadCustomerInformation()
        {
            txtCustomerForename.Text = currentCustomer.CustomerForename;
            txtCustomerSurname.Text = currentCustomer.CustomerSurname;

            txtStreet.Text = currentCustomer.Street;
            txtTown.Text = currentCustomer.Town;
            txtCounty.Text = currentCustomer.County;
            txtPostcode.Text = currentCustomer.Postcode;

            txtPhone.Text = currentCustomer.Phone;
            txtEmail.Text = currentCustomer.Email;
            
            dtDOB.Value = DateTime.ParseExact(currentCustomer.DOB.Split(' ')[0], "d/M/yyyy", CultureInfo.InvariantCulture);
        }

        private void frmEditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Master.isEditOpen = false;
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                //Input into database
                try
                {
                    string forename = txtCustomerForename.Text;
                    string surname = txtCustomerSurname.Text;

                    string street = txtStreet.Text;
                    string town = txtTown.Text;
                    string county = txtTown.Text;
                    string postcode = txtPostcode.Text;

                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;

                    string dob = dtDOB.Value.ToString("yyyy-M-d");

                    string sql = @"UPDATE Customer SET CustomerForename = '" + forename +"', CustomerSurname = '" + surname +"', CustomerDOB = '" + dob +"', Street = '" + street +"', Town = '" + town+ "', County ='" + county +"'" +
                        ", PostCode = '" + postcode +"', TelNo = '" + phone +"', Email = '" + email +"' WHERE CustomerID = '" + currentCustomer.CustomerID+"'";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        Master.GetAllCustomers();
                        this.Close();
                    }

                    MessageBox.Show("Customer Successfuly Edited!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error editing customer! Please try again.\n" + ex.Message, "Error editing Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            if (string.IsNullOrEmpty(street) == false && street.Length >= 3)
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

            string emailRegex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
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

            if (success == false)
            {
                MessageBox.Show(errorText, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return success;
        }

    }
}
