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

        //Connections
        //private string connectionString = @"Data Source=DESKTOP-TAB21TK\SQLEXPRESS;Initial Catalog=Studio76;Integrated Security=True";
        //Tech
        private string connectionString = @"Data Source=B602-012;Initial Catalog=Studio76;Integrated Security=True";

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
            lblTotalCostResult.Text = "£" + ((float)(currentBooking.BookingLength * currentBooking.ArtistDetails.Price) / 2).ToString("F2");
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
                    selectedCustomerID = reader.GetInt32(0);
                    col.Add(reader.GetString(1));
                }


                txtCustomerSearch.AutoCompleteCustomSource = col;
                conn.Close();
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm this booking?", "Confirm Booking?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                CreateBooking();
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
                SqlCommand getCount = new SqlCommand("SELECT COUNT(*) FROM Booking", conn);
                conn.Open();

                string countReader = getCount.ExecuteScalar().ToString();
                conn.Close();

                //Assign Booking Variables
                int bookingID = 1000 + Int32.Parse(countReader);
                int customerID = selectedCustomerID;
                int artistID = currentBooking.ArtistDetails.ArtistID;
                string dateBooked = DateTime.Now.ToString("yyyy-MM-dd");
                int depositPaid = cbDepositPaid.Checked ? 1 : 0;

                //Insert into booking table
                SqlCommand addBooking = new SqlCommand("INSERT INTO Booking (BookingID, CustomerID, ArtistID, DateBooked, DepositPaid) VALUES ('" + bookingID+ "', '" + 
                    customerID + "','" + artistID + "','" + dateBooked + "', '" + depositPaid + "')", conn);
                conn.Open();

                SqlDataReader bookingReader = addBooking.ExecuteReader();
                while (bookingReader.Read()) { }
                conn.Close();

                //Assign Booking Details Variables
                TimeSpan sessionTime = currentBooking.StartTime;
                int sessionLength = currentBooking.BookingLength;

                //Convert date string to correct format
                string bookingDate = currentBooking.BookingDate.Split('\n')[1];
                bookingDate = bookingDate.Trim();

                MessageBox.Show(bookingDate);
                string[] dateParts = bookingDate.Split('/');

                int day = Int32.Parse(dateParts[0]);
                int month = Int32.Parse(dateParts[1]);
                int year = Int32.Parse(dateParts[2]);

                DateTime dt = new DateTime(year, month, day);

                string finalBooking = dt.ToString("M/d/yyyy");
                MessageBox.Show(finalBooking);

                //Insert into Booking Details
                SqlCommand addBookingDetails = new SqlCommand("INSERT INTO BookingDetails (BookingID, SessionTime, SessionLength, SessionDate) VALUES ('" + bookingID + "', '" +
                    sessionTime + "','" + sessionLength + "','" + finalBooking + "')", conn);
                conn.Open();

                SqlDataReader bookingDetailsReader = addBookingDetails.ExecuteReader();
                while (bookingDetailsReader.Read()) { }
                conn.Close();
            }
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

            }
        }

        public void SetupInformation()
        {
            lblBookingDates.Text = currentBooking.BookingDate.Split('\n')[1];
            lblBookingLength.Text = ((float)(Int32.Parse(currentBooking.BookingLength.ToString())) / 2).ToString("F1") + " Hour(s)";

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
