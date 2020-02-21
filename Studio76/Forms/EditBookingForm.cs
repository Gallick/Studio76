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
    public partial class EditBookingForm : Form
    {
        //Home
        //private const string connectionString = @"Data Source=DESKTOP-TAB21TK\SQLEXPRESS;Initial Catalog=Studio76;Integrated Security=True";

        //Tech
        private string connectionString = @"Data Source=B602-012;Initial Catalog=Studio76;Integrated Security=True";

        public frmBookings Master;
        public Booking currentBooking;

        private SqlDataAdapter daArtists, daCustomers;
        private DataSet dsStudio = new DataSet();

        private int selectedCustomerID;

        private int currentBookingLength;

        public EditBookingForm()
        {
            InitializeComponent();
        }

        private void EditBookingForm_Load(object sender, EventArgs e)
        {
            GetArtistList();
            GetCustomerList();
            UpdateSelectedCustomerDetails(currentBooking.CustomerID);

            //Set Customer text name
            txtCustomerName.Text = currentBooking.CustomerName;

            //Setup datetime picker
            dtDate.MinDate = DateTime.Now.AddDays(-1);
            dtDate.Value = DateTime.ParseExact(currentBooking.bookingDetails.BookingDate, "d/M/yyyy", CultureInfo.InvariantCulture);

            //Price
            if (String.IsNullOrEmpty(txtBookingLength.Text) == false)
            {
                currentBookingLength = Int32.Parse(txtBookingLength.Text);
                UpdatePriceText();
            }

            //Length
            currentBookingLength = currentBooking.bookingDetails.BookingLength;
            txtBookingLength.Text = currentBooking.bookingDetails.BookingLength.ToString();

            lblStartTime.Text = GetStartTime();
        }

        private string GetStartTime()
        {
            string t = currentBooking.bookingDetails.Time.ToString();
            return t.Substring(0, t.Length - 3);
        }

        private void GetArtistList()
        {
            try
            {
                string sqlArtist = @"SELECT ArtistForename + ' ' + ArtistSurname AS Name, ArtistID FROM Artist";

                daArtists = new SqlDataAdapter(sqlArtist, connectionString);
                daArtists.FillSchema(dsStudio, SchemaType.Source, "Artist");

                daArtists.Fill(dsStudio, "Artist");

                cboEditBookingArtist.DataSource = dsStudio.Tables["Artist"];
                cboEditBookingArtist.ValueMember = "ArtistID";
                cboEditBookingArtist.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditBookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Master.isEditOpen = false;
        }
        private void GetCustomerList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT CustomerID, CustomerForename + ' ' + CustomerSurname AS Name FROM Customer", conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    selectedCustomerID = reader.GetInt32(0);
                    col.Add(reader.GetString(1));
                }


                txtCustomerName.AutoCompleteCustomSource = col;
                conn.Close();
            }
        }

        private float GetAristHourlyPrice(int _id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                SqlCommand getCount = new SqlCommand("SELECT ArtistHourlyPrice FROM Artist WHERE ArtistID = '" + _id + "'", conn);
                conn.Open();

                string price = getCount.ExecuteScalar().ToString();
                conn.Close();

                return float.Parse(price);
            };
        }

        private void CboEditBookingArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = GetSelectedArtistID();
            if (id != -1)
            {
                GetAristHourlyPrice(id);
                UpdatePriceText();
            }
        }

        private void UpdatePriceText()
        {
            lblHourlyPrice.Text = "£" + GetAristHourlyPrice(GetSelectedArtistID());
            lblTotalCost.Text = "£" + ((GetAristHourlyPrice(GetSelectedArtistID()) * currentBookingLength) / 2).ToString("F2");
        }

        private int GetSelectedArtistID()
        {
            if (cboEditBookingArtist.SelectedValue.GetType() != typeof(DataRowView))
            {
                int id = Int32.Parse(cboEditBookingArtist.SelectedValue.ToString());
                return id;
            }

            return -1;
        }

        private void TxtBookingLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;

            int keyvalue = e.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            // Allow nothing else
            e.Handled = true;

            if (String.IsNullOrWhiteSpace(txtBookingLength.Text) == false)
            {
                currentBookingLength = Int32.Parse(txtBookingLength.Text);
                UpdatePriceText();
            }
        }

        private void BtnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingLength.Text) == false)
            {
                if (currentBookingLength == 0)
                {
                    MessageBox.Show("Booking Length must be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Update Booking
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string sql = @"UPDATE BookingDetails SET SessionLength = '" + currentBookingLength + "', SessionDate = '" + GetSessionDate() + "' WHERE BookingID ='" + currentBooking.BookingID + "';" +
                                "UPDATE Booking SET ArtistID = '" + cboEditBookingArtist.SelectedValue.ToString() + "', DepositPaid = '" + (cbDepositPaid.Checked ? 1 : 0) + "' WHERE BookingID ='" + currentBooking.BookingID+ "';";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            conn.Open();

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            MessageBox.Show("Booking Successfully Edited", "Booking Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Master.GetBoookingInformation();
                            this.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error Editing the Booking, Please double check the values and try again!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter a value for the booking length!", "No Booking Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSessionDate()
        {
            string date = dtDate.Value.ToShortDateString();
            string dt = DateTime.ParseExact(date, "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-M-dd");
            return dt;
        }

        private void TxtBookingLength_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingLength.Text) == false)
            {
                currentBookingLength = Int32.Parse(txtBookingLength.Text);
                UpdatePriceText();
            }
        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void UpdateSelectedCustomerDetails(int _id)
        {
            string sqlCustomers = @"SELECT * FROM Customer WHERE CustomerID ='" + _id + "'";

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
    }
}
