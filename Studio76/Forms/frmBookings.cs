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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Studio76.Forms
{
    public partial class frmBookings : Form
    {
        //Master Form
        public frmMain masterForm;

        //Bookings
        private List<Booking> allBookings = new List<Booking>();
        private List<Booking> allArtistBookings = new List<Booking>();

        //Connections
        private string connectionString = Helper.connectionString;

        //SQL
        private SqlDataAdapter daBookings, daBookingDetails, daArtistType, daArtists, daEditBookings;
        private DataSet dsStudio = new DataSet();

        private string sqlBookings, sqlBookingDetails, sqlArtist, sqlEditBookingCustomerSearch;

        //Color Variables
        private Color defaultCellBackColour;
        private Color defaultCellForColour;

        //Date Controls
        private int currentWeekOffset = 0;

        //Cell Selection
        private List<DataGridViewCell> selectedTimeSlots = new List<DataGridViewCell>();

        //Edit Options
        public bool isEditOpen = false;

        public frmBookings()
        {
            InitializeComponent();
            GetAllBookings();

            SetupDateSelectionContent();

            UpdateArtistSelection();
            UpdateDeleteBookingForm();

            GetBoookingInformation();
        }

        #region Add Booking

        private void frmBookings_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmDates_Click(object sender, EventArgs e)
        {
            if(selectedTimeSlots.Count > 0)
            {
                int artistID = Int32.Parse(cboAddBookingArtist.SelectedValue.ToString());

                SelectionBooking s = new SelectionBooking(DateTime.Now.ToShortDateString(),
                    BookingStartTime(), selectedTimeSlots.Count,
                    GetDateFromBookings(selectedTimeSlots[0]), 
                    new Artists(artistID, GetArtistName(artistID), GetArtistHourlyPrice(artistID)));

               
                masterForm.ClearCurrentForm();
                masterForm.ChangeFormToBookingConfirmation(s);

            }
            else
            {
                MessageBox.Show("You must select more than 1 slot for the booking", "No Slots Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TimeSpan BookingStartTime()
        {
            List<TimeSpan> times = new List<TimeSpan>();

            for (int i = 0; i < selectedTimeSlots.Count; i++)
            {
                TimeSpan t = TimeSpan.Parse(selectedTimeSlots[0].Value.ToString());
                times.Add(t);
            }

            return times.Min();
            
        }

        private string GetDateFromBookings(DataGridViewCell _cell)
        {
            int colIndex = _cell.ColumnIndex;
            string columnHeader = dgAddBookingSelectDate.Columns[colIndex].HeaderText;

            return columnHeader;
        }

        //Fill the time slots in the cells of the time selector
        private void SetupDateSelectionContent()
        {
            //9am, 9:30 am, 10am...
            dgAddBookingSelectDate.RowCount = 17;

            DataTable table = new DataTable();
            DateTime now = DateTime.Now.Date;

            //Days of week
            for (int i = 0; i < 7; i++)
            {
                DateTime current = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0);
                //Hours in day
                for (int x = 0; x < 17; x++)
                {
                    dgAddBookingSelectDate[i, x].Value = current.TimeOfDay.ToString();
                    current = current.AddMinutes(30);
                }
            }

            //Get Default Colours
            defaultCellBackColour = dgAddBookingSelectDate.Rows[0].Cells[0].Style.BackColor;
            defaultCellForColour = dgAddBookingSelectDate.Rows[0].Cells[0].Style.ForeColor;

            SetupBookingTable();
        }

        private void dgAddBookingSelectDate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgAddBookingSelectDate.CurrentCell = dgAddBookingSelectDate.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (dgAddBookingSelectDate.CurrentCell.ColumnIndex != -1 && dgAddBookingSelectDate.CurrentRow.Index != -1)
            {
                //If its not null or it's not a sunday and not passed
                if (dgAddBookingSelectDate.CurrentCell != null && dgAddBookingSelectDate.CurrentCell.ColumnIndex != 6 && dgAddBookingSelectDate.CurrentCell.Style.BackColor != Color.Black && dgAddBookingSelectDate.CurrentCell.Style.BackColor != Color.Green)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        if (selectedTimeSlots.Contains(dgAddBookingSelectDate.CurrentCell) == true)
                        {                 
                            dgAddBookingSelectDate.CurrentCell.Style.BackColor = defaultCellBackColour;
                            dgAddBookingSelectDate.CurrentCell.Style.ForeColor = defaultCellForColour;
                            dgAddBookingSelectDate.CurrentCell.Selected = false;

                            selectedTimeSlots.Remove(dgAddBookingSelectDate.CurrentCell);
                          
                        }
                    }
                    else if(e.Button == MouseButtons.Left)
                    {
                        if (selectedTimeSlots.Contains(dgAddBookingSelectDate.CurrentCell) == false)
                        {
                            bool canSelect = true;

                            foreach (DataGridViewCell item in selectedTimeSlots)
                            {
                                if (dgAddBookingSelectDate.CurrentCell.ColumnIndex != item.ColumnIndex)
                                {
                                    canSelect = false;
                                }
                            }

                            if (canSelect)
                            {
                                Color selectedColorBack = System.Drawing.ColorTranslator.FromHtml("#487eb0");
                                Color selectedColorFor = System.Drawing.ColorTranslator.FromHtml("#f5f6fa");

                                dgAddBookingSelectDate.CurrentCell.Style.BackColor = selectedColorBack;
                                dgAddBookingSelectDate.CurrentCell.Style.ForeColor = selectedColorFor;
                                dgAddBookingSelectDate.CurrentCell.Selected = false;

                                selectedTimeSlots.Add(dgAddBookingSelectDate.CurrentCell);
                            }
                            else
                            {
                                MessageBox.Show("Bookings must be made on the same day!", "Cannot Select Time Slot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The Artist already has a booking for this time slot, please choose another!", "Cannot Select Time Slot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetupBookingTable()
        {
            //Assign dates to all of the columns
            foreach (DataGridViewColumn column in dgAddBookingSelectDate.Columns)
            {
                //Get the system time
                CultureInfo info = Thread.CurrentThread.CurrentCulture;

                //Get the first day of the week
                DayOfWeek first = info.DateTimeFormat.FirstDayOfWeek;

                //Calculate the date of the first day
                DateTime date = DateTime.Today.AddDays(-(DateTime.Today.DayOfWeek - first)).AddDays(7 * currentWeekOffset);

                //Update header text
                lblCurrentDates.Text = date.ToShortDateString() + " - " + date.AddDays(6).ToShortDateString();

                //Setup headers
                DateTime headerDate = date.AddDays(dgAddBookingSelectDate.Columns.IndexOf(column));
                column.HeaderText = headerDate.ToString("dddd") + "\n" + headerDate.ToShortDateString();

                for (int i = 0; i < 7; i++)
                {
                    //Get the first day of the week
                    first = info.DateTimeFormat.FirstDayOfWeek + i;

                    //Calculate the date of the first day
                    date = DateTime.Today.AddDays(-(DateTime.Today.DayOfWeek - first)).AddDays(7 * currentWeekOffset);

                    //Itterate the days
                    //date = date.AddDays(i);

                    //Check if date has passed
                    if (HasDatePassed(date.ToShortDateString()))
                    {
                        for (int x = 0; x < 17; x++)
                        {
                            dgAddBookingSelectDate[i, x].Value = "";
                            dgAddBookingSelectDate[i, x].Style.BackColor = Color.Black;
                            dgAddBookingSelectDate[i, x].Style.ForeColor = Color.Black;
                        }

                    }
                    else
                    {
                        for (int x = 0; x < 17; x++)
                        {
                            dgAddBookingSelectDate[i, x].Style.BackColor = defaultCellBackColour;
                            dgAddBookingSelectDate[i, x].Style.ForeColor = defaultCellForColour;
                             
                        }
                    }

                    if (first.ToString() == "7")
                    {
                        DisableSundayCells();
                    }                 
                }
            }
        }

        private void CboAddBookingArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBoookingInformation();
        }

        public bool HasDatePassed(string _date)
        {
            DateTime from = DateTime.Parse(_date);

            int result = DateTime.Compare(DateTime.Now, from);

            if (result <= 0)
            {
                return false;
            }
            else if(result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void UpdateCellText()
        {
            //9am, 9:30 am, 10am...
            dgAddBookingSelectDate.RowCount = 17;

            DataTable table = new DataTable();
            DateTime now = DateTime.Now.Date;

            //Days of week
            for (int i = 0; i < 6; i++)
            {
                DateTime current = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0).AddDays(1 * currentWeekOffset);
                //Hours in day
                if (HasDatePassed(current.ToShortDateString()) == false)
                {
                    for (int x = 0; x < 17; x++)
                    {
                        dgAddBookingSelectDate[i, x].Value = current.TimeOfDay.ToString();
                        current = current.AddMinutes(30);
                    }
                }
                else
                {
                    for (int x = 0; x < 17; x++)
                    {
                        DataGridViewCell cell = dgAddBookingSelectDate[i, x];

                        if(string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            cell.Value = current.TimeOfDay.ToString();
                            current = current.AddMinutes(30);
                        }
                    }
                }
            }
        }

        private void CboEditBookingArtistName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisableSundayCells()
        {
            //Sunday has in index of 6
            //17 rows in the table

            for (int i = 0; i < 17; i++)
            {
                dgAddBookingSelectDate[6, i].Value = "";
                dgAddBookingSelectDate[6, i].Style.BackColor = Color.Black;
            }
        }

        private void TpAdd_Click(object sender, EventArgs e)
        {

        }

        private void PbDatesPervious_Click(object sender, EventArgs e)
        {       
            selectedTimeSlots.Clear();

            //Go back 1 week
            currentWeekOffset -= 1;
            SetupBookingTable();
            UpdateCellText();
            if (currentWeekOffset == 0)
            {
                pbDatesPervious.Enabled = false;
            }

            UpdateDisplayForBookings();
        }

        private void PbDatesNext_Click(object sender, EventArgs e)
        {
            selectedTimeSlots.Clear();
            //Go forward 1 week
            currentWeekOffset += 1;
            SetupBookingTable();
            UpdateCellText();
            if (currentWeekOffset > 0)
            {
                pbDatesPervious.Enabled = true;
            }

            UpdateDisplayForBookings();
        }

        private void GetBookingsFromArtist(int _artistID)
        {
            sqlBookings = @"SELECT * FROM Booking WHERE ArtistID = '" + _artistID + "'";

            daBookings = new SqlDataAdapter(sqlBookings, connectionString);
            daBookings.FillSchema(dsStudio, SchemaType.Source, "Bookings");

            daBookings.Fill(dsStudio, "Bookings");
   
            foreach (DataRow dr in dsStudio.Tables["Bookings"].Rows)
            {
                Booking b = new Booking();
                b.BookingID =  Int32.Parse(dr["BookingID"].ToString());
                b.ArtistID = Int32.Parse(dr["ArtistID"].ToString());
                b.CustomerID = Int32.Parse(dr["CustomerID"].ToString());
                b.DateBooked = dr["DateBooked"].ToString().Split(' ')[0];

                b.bookingDetails = GetBookingDetails(Int32.Parse(dr["BookingID"].ToString()));
                allArtistBookings.Add(b);
            }
            UpdateDisplayForBookings();

        }

        private float GetArtistHourlyPrice(int _artistID)
        {
            float price = 0.0f;

            sqlBookings = @"SELECT * FROM Artist WHERE ArtistID = '" + _artistID + "'";

            daBookings = new SqlDataAdapter(sqlBookings, connectionString);
            daBookings.FillSchema(dsStudio, SchemaType.Source, "Artists");

            daBookings.Fill(dsStudio, "Artists");

            foreach (DataRow dr in dsStudio.Tables["Artists"].Rows)
            {
                price = float.Parse(dr["ArtistHourlyPrice"].ToString());                                                                                                                                                                                                     
            }

            return price;
        }

        private string GetArtistName(int _artistID)
        {
            string forename = "";
            string surname = "";

            sqlBookings = @"SELECT * FROM Artist WHERE ArtistID = '" + _artistID + "'";

            daBookings = new SqlDataAdapter(sqlBookings, connectionString);
            daBookings.FillSchema(dsStudio, SchemaType.Source, "Artists");

            daBookings.Fill(dsStudio, "Artists");

            foreach (DataRow dr in dsStudio.Tables["Artists"].Rows)
            {
                forename = dr["ArtistForename"].ToString();
                surname = dr["ArtistSurname"].ToString();
            }

            return forename + " " + surname;
        }

        private BookingDetails GetBookingDetails(int _bookingID)
        { 
            BookingDetails bd = new BookingDetails();

            sqlBookingDetails = @"SELECT * FROM BookingDetails WHERE BookingID = '" + _bookingID + "' AND SessionDate >= getdate()";
            daBookingDetails = new SqlDataAdapter(sqlBookingDetails, connectionString);
            daBookingDetails.FillSchema(dsStudio, SchemaType.Source, "BookingDetails");
            daBookingDetails.Fill(dsStudio, "BookingDetails");

            foreach (DataRow dr in dsStudio.Tables["BookingDetails"].Rows)
            {
                bd.BookingID = Int32.Parse(dr["BookingID"].ToString());
                bd.Time = TimeSpan.Parse(dr["SessionTime"].ToString());
                bd.BookingLength = Int32.Parse(dr["SessionLength"].ToString());
                bd.BookingDate = dr["SessionDate"].ToString().Split(' ')[0];

            }

            return bd;

        }

        private void UpdateDisplayForBookings()
        {
            SetupBookingTable();

            foreach (Booking item in allArtistBookings)
            {
                foreach (DataGridViewColumn column in dgAddBookingSelectDate.Columns)
                {
                    if (column.HeaderText.Contains(item.bookingDetails.BookingDate))
                    {
                        int id = dgAddBookingSelectDate.Columns.IndexOf(column);
                        for (int i = 0; i < 17; i++)
                        {
                            string cell = dgAddBookingSelectDate[id, i].Value.ToString();
                            if (cell.Contains(item.bookingDetails.Time.ToString()))
                            {
                                for (int x = 0; x < item.bookingDetails.BookingLength; x++)
                                {
                                    dgAddBookingSelectDate[id, i + x].Style.BackColor = Color.Green;
                                    dgAddBookingSelectDate[id, i + x].Style.ForeColor = Color.Black;
                                    dgAddBookingSelectDate[id, i + x].Value = "";
                                }
                            }
                        }
                    }             
                }
            }
        }

        private void UpdateArtistSelection()
        {
            try
            {
                sqlArtist = @"SELECT ArtistForename + ' ' + ArtistSurname AS Name, ArtistID FROM Artist";

                daArtists = new SqlDataAdapter(sqlArtist, connectionString);
                daArtists.FillSchema(dsStudio, SchemaType.Source, "Artist");

                daArtists.Fill(dsStudio, "Artist");

                cboAddBookingArtist.DataSource = dsStudio.Tables["Artist"];
                cboAddBookingArtist.ValueMember = "ArtistID";
                cboAddBookingArtist.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                    
            }
        }

        private void BtnEditBooking_Click(object sender, EventArgs e)
        {
            if(!isEditOpen)
            {
                Booking b = GetSelectedBooking();

                EditBookingForm eb = new EditBookingForm();
                eb.Master = this;
                eb.currentBooking = b;
                eb.Show();

                isEditOpen = true;              
            }
            else
            {
                MessageBox.Show("Edit Booking form is already open, please close it and try again!", "Form Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddBookingFindDate_Click(object sender, EventArgs e)
        {
            GetBoookingInformation();           
        }

        public void GetBoookingInformation()
        {
            if (cboAddBookingArtist.SelectedIndex >= 0 && cboAddBookingArtist.SelectedValue.GetType() != typeof(DataRowView))
            {
                allArtistBookings.Clear();

                ClearPreviousBookings();

                GetBookingsFromArtist(Int32.Parse(cboAddBookingArtist.SelectedValue.ToString()));

                //Next then Previous to reset the form visuals
                PbDatesNext_Click(null, null);
                PbDatesPervious_Click(null, null);

            }
        }

        private void BtnDeleteBooking_Click(object sender, EventArgs e)
        {
            if(dgDeleteBookings.SelectedRows.Count > 0)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        Booking b = GetSelectedBookingDelete();
                        if (b != null)
                        {
                            string sql = @"DELETE FROM BookingDetails WHERE BookingID = '" + b.BookingID+"'; DELETE FROM Booking WHERE BookingID = '" + b.BookingID + "';";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            conn.Open();

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            int id = 0;

                            foreach (Booking booking in allBookings)
                            {
                                if(booking.BookingID == b.BookingID)
                                {
                                    id = allBookings.IndexOf(booking);
                                }
                            }

                            allBookings.RemoveAt(id);

                            UpdateDeleteBookingForm();
                            UpdateEditBookingTable();

                            dgDeleteBookings.Update();
                            dgvEditBookings.Update();

                            GetBoookingInformation();

                            MessageBox.Show("Booking Successfully Deleted", "Booking Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error Getting Selected Booking, Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Deleting Booking!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                MessageBox.Show("Please selected a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPreviousBookings()
        {
            if (dsStudio.Tables["Bookings"] != null && dsStudio.Tables["BookingDetails"] != null)
            {
                dsStudio.Tables["Bookings"].Clear();
                dsStudio.Tables["BookingDetails"].Clear();
            }

            foreach (DataGridViewColumn column in dgAddBookingSelectDate.Columns)
            {
                int id = dgAddBookingSelectDate.Columns.IndexOf(column);
                for (int i = 0; i < 17; i++)
                {
                    DataGridViewCell cell = dgAddBookingSelectDate[id, i];
  
                    if(cell.Style.BackColor == Color.Green)
                    {
                        cell.Style.BackColor = DefaultBackColor;
                        cell.Style.ForeColor = DefaultForeColor;

                    }
                }
            }

            SetupBookingTable();
        }

        private void btnAllBookings_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Users\gal16100778\source\repos\Studio76\Studio76\Reports\AllBookings.rpt");

            crvReports.ReportSource = report;
            crvReports.Refresh();
        }

        private void CboAddBookingArtistType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateArtistSelection();
        }

        #endregion

        #region Edit Booking
        private void TcBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Edit Bookings
            if(tcBookings.SelectedIndex == 1)
            {
             
            }
        }
        
        public void GetAllBookings()
        {
            allBookings.Clear();

            sqlBookings = @"SELECT * FROM Booking";

            daEditBookings = new SqlDataAdapter(sqlBookings, connectionString);
            daEditBookings.FillSchema(dsStudio, SchemaType.Source, "AllBookings");

            daEditBookings.Fill(dsStudio, "AllBookings");

            foreach (DataRow dr in dsStudio.Tables["AllBookings"].Rows)
            {
                BookingDetails bd = GetBookingDetails(Int32.Parse(dr["BookingID"].ToString()));
                if (bd != null)
                {
                    Booking b = new Booking();
                    b.BookingID = Int32.Parse(dr["BookingID"].ToString());
                    b.ArtistID = Int32.Parse(dr["ArtistID"].ToString());
                    b.CustomerID = Int32.Parse(dr["CustomerID"].ToString());
                    b.DateBooked = dr["DateBooked"].ToString().Split(' ')[0];

                    b.bookingDetails = GetBookingDetails(b.BookingID);
                    allBookings.Add(b);
                }
            }

            UpdateEditBookingTable();
        }
        public void UpdateEditBookingTable()
        {
            dgvEditBookings.DataSource = null;
            dgvEditBookings.DataSource = allBookings.Select(Booking => new {
                Booking.BookingID,
                Booking.CustomerName,
                Booking.ArtistName,
                Booking.bookingDetails.BookingDate,
                Booking.bookingDetails.Time,
                Booking.BookingLengthTime,
                Booking.bookingDetails.DepositPaid
            }).ToList();

        }

        private Booking GetSelectedBooking()
        {
            foreach (DataGridViewRow row in dgvEditBookings.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                foreach (Booking booking in allBookings)
                {
                    if(id == booking.BookingID)
                    {
                        return booking;
                    }
                }
            }

            return null;
        }

        #endregion

        #region Delete Booking
        public void UpdateDeleteBookingForm()
        {
            dgDeleteBookings.DataSource = null;
            dgDeleteBookings.DataSource = allBookings.Select(Booking => new {
                Booking.BookingID,
                Booking.CustomerName,
                Booking.ArtistName,
                Booking.bookingDetails.BookingDate,
                Booking.bookingDetails.Time,
                Booking.BookingLengthTime,
                Booking.bookingDetails.DepositPaid
            }).ToList();

        }

        private Booking GetSelectedBookingDelete()
        {
            foreach (DataGridViewRow row in dgDeleteBookings.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                foreach (Booking booking in allBookings)
                {
                    if (id == booking.BookingID)
                    {
                        return booking;
                    }
                }
            }

            return null;
        }

        #endregion
    }
}
