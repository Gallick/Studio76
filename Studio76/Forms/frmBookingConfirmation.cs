using Studio76.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        private SqlDataAdapter daCustomers;
        private DataSet dsStudio = new DataSet();
        private SqlCommand cmdCustomers;
        private SqlCommandBuilder cmdBCustomers;
        private DataRow drCustomers;

        private string sqlCustomers;


        public frmBookingConfirmation()
        {
            InitializeComponent();

            CustomerAutoCompleteSetup();
        }

        private void CustomerAutoCompleteSetup()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT CustomerForename + ' ' + CustomerSurname AS Name FROM Customer", conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                while(reader.Read())
                {
                    col.Add(reader.GetString(0));
                }

                txtCustomerSearch.AutoCompleteCustomSource = col;
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
    }
}
