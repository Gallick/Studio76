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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio76.Forms
{
    public partial class frmBookingConfirmation : Form
    {
        //Details
        public SelectionBooking currentBooking;
        public frmMain Master;

        private string connectionString = Helper.connectionString;

        //SQL
        private SqlDataAdapter daCustomers, daPreviousBookings;
        private DataSet dsStudio = new DataSet();
        private SqlCommand cmdCustomers;
        private SqlCommandBuilder cmdBCustomers;
        private DataRow drCustomers, drPreviousBookings;

        private string sqlCustomers, sqlPreviousBookings;
        private int selectedCustomerID;

        public frmBookingConfirmation()
        {
            InitializeComponent();

            CustomerAutoCompleteSetup();
        }

        private void frmBookingConfirmation_Load(object sender, EventArgs e)
        {
            lblArtistName.Text = currentBooking.ArtistDetails.ArtistName;
            lblPricePerHour.Text = "£" + currentBooking.ArtistDetails.Price.ToString("F2");

            int price = 0;
            foreach (MultiBook item in currentBooking.Multi)
            {
                price += item.Length;
            }


            lblTotalCostResult.Text = "£" + ((float)(price * currentBooking.ArtistDetails.Price)/ 2).ToString("F2");
        }

        private void CustomerAutoCompleteSetup()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT CustomerID, CustomerForename + ' ' + CustomerSurname AS Name FROM Customer", conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                while(reader.Read())
                {
                    col.Add(reader.GetString(1));
                }


                txtCustomerSearch.AutoCompleteCustomSource = col;
                conn.Close();
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            //Make sure customer is selected

            if (DoesCustomerExist(txtCustomerSearch.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm this booking?", "Confirm Booking?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    CreateBooking();
                }
            }
            else
            {
                MessageBox.Show("A Customer with the name of, " + txtCustomerSearch.Text + " does not exist!", "Customer Does not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private bool DoesCustomerExist(string _name)
        {
            if (string.IsNullOrEmpty(_name) || _name.Contains(' ') == false)
                return false;

            string[] name = _name.Split(' ');

            string forename = name[0];
            string surname = name[1];

            string sql = @"SELECT COUNT(*) FROM Customer WHERE CustomerForename = '" + forename + "' AND CustomerSurname = '" + surname +"'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();

                int customerCount = (int)cmd.ExecuteScalar();

                if (customerCount > 0)
                    return true;

                return false;
            }
              
        }

        private void CreateBooking()
        {
            //BOOKING
            //BookingId, CustomerID, ArtistID, DateBooked, DepositPaid

            //BOOKING DETAILS
            //BookingID, SessionTime, SessionLength, SessionDate
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand getCount = new SqlCommand("SELECT BookingID FROM Booking", conn);
                    conn.Open();

                    SqlDataReader reader = getCount.ExecuteReader();

                    int id = -1;

                    while(reader.Read())
                    {
                        id = Int32.Parse(reader[0].ToString());
                    };

                    conn.Close();

                    //Assign Booking Variables
                    int bookingID = id + 1;
                    int customerID = selectedCustomerID;
                    int artistID = currentBooking.ArtistDetails.ArtistID;
                    string dateBooked = DateTime.Now.ToString("yyyy-MM-dd");
                    int depositPaid = cbDepositPaid.Checked ? 1 : 0;

                    //Insert into booking table
                    SqlCommand addBooking = new SqlCommand("INSERT INTO Booking (BookingID, CustomerID, ArtistID, DateBooked, DepositPaid) VALUES ('" + bookingID + "', '" +
                        customerID + "','" + artistID + "','" + dateBooked + "', '" + depositPaid + "')", conn);
                    conn.Open();

                    SqlDataReader bookingReader = addBooking.ExecuteReader();
                    while (bookingReader.Read()) { }
                    conn.Close();


                    foreach (var item in currentBooking.Multi)
                    {
                        //Assign Booking Details Variables
                        TimeSpan sessionTime = item.StartTime;
                        int sessionLength = item.Length;

                        string bookingDate = item.Date;
                        bookingDate = bookingDate.Trim();



                        DateTime dt = DateTime.ParseExact(bookingDate, "d/M/yyyy", CultureInfo.InvariantCulture);

                        string finalBooking = dt.ToString("M/d/yyyy");

                        //Insert into Booking Details
                        SqlCommand addBookingDetails = new SqlCommand("INSERT INTO BookingDetails (BookingID, SessionTime, SessionLength, SessionDate) VALUES ('" + bookingID + "', '" +
                            sessionTime + "','" + sessionLength + "','" + finalBooking + "')", conn);
                        conn.Open();

                        SqlDataReader bookingDetailsReader = addBookingDetails.ExecuteReader();
                        while (bookingDetailsReader.Read()) { }
                        conn.Close();

                        MessageBox.Show("Booking Created for " + bookingDate + " at " + sessionTime + "!", "Booking Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("There was an error creating the booking!\n" + ex.Message, "Error Creating Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmBookingConfirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Master.ChangeToBookingForm();
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerSearch.Text.Contains(" "))
            {
                string[] name = txtCustomerSearch.Text.Split(' ');
                UpdateSelectedCustomerDetails(name[0], name[1]);
            }
        }

        private void UpdateSelectedCustomerDetails(string _fore, string _sur)
        {
            sqlCustomers = @"SELECT * FROM Customer WHERE CustomerForename = '" + _fore + "' AND CustomerSurname = '" + _sur + "'";

            daCustomers = new SqlDataAdapter(sqlCustomers, connectionString);
            daCustomers.FillSchema(dsStudio, SchemaType.Source, "Customers");

            daCustomers.Fill(dsStudio, "Customers");

            foreach (DataRow dr in dsStudio.Tables["Customers"].Rows)
            {
                lblForenameDisplay.Text = dr["CustomerForename"].ToString();
                lblSurnameDisplay.Text = dr["CustomerSurname"].ToString();
                lblDOBDetails.Text = dr["CustomerDOB"].ToString().Split(' ')[0];

                lblStreetDetails.Text = dr["Street"].ToString();
                lblTownDetails.Text = dr["Town"].ToString();
                lblCountyDetails.Text = dr["County"].ToString();
                lblPostcodeDetails.Text = dr["PostCode"].ToString();

                lblPhoneNoDetails.Text = dr["TelNo"].ToString();
                lblEmailDetails.Text = dr["Email"].ToString();

                selectedCustomerID = Int32.Parse(dr["CustomerID"].ToString());

            }
        }

        public void SetupInformation()
        {
            lblBookingDates.Text = currentBooking.Multi[0].Date;
            for (int i = 1; i < currentBooking.Multi.Count; i++)
            {
                if(lblBookingDates.Text.Contains(currentBooking.Multi[i].Date) == false)
                    lblBookingDates.Text += " / " + currentBooking.Multi[i].Date;
            }
            int length = 0;

            foreach (MultiBook item in currentBooking.Multi)
            {
                length += item.Length;
            }    
            lblBookingLength.Text = ((float)length / 2).ToString("F1") + " Hour(s)";

            lblArtistName.Text = currentBooking.ArtistDetails.ArtistName;            
        }

        /*private void GetPreviousBookings(int _customerID)
        {
            sqlPreviousBookings = @"SELECT DepositPaid FROM Bookings WHERE CustomerID = '" + _customerID + "'";
            daPreviousBookings = new SqlDataAdapter(sqlPreviousBookings, connectionString);
            daPreviousBookings.FillSchema(dsStudio, SchemaType.Source, "Previous");

            daPreviousBookings.Fill(dsStudio, "Previous");

            dgvPreviousBookings.DataSource = dsStudio.Tables["Previous"];
        }

        private void GetPreviousBookingPrice()
        {

        }
        */
    }
}
