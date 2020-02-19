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
    public partial class EditBookingForm : Form
    {
        private const string connectionString = @"Data Source=DESKTOP-TAB21TK\SQLEXPRESS;Initial Catalog=Studio76;Integrated Security=True";
        public frmBookings Master;
        public Booking currentBooking;

        private SqlDataAdapter daArtists;
        private DataSet dsStudio = new DataSet();

        public EditBookingForm()
        {
            InitializeComponent();
        }

        private void EditBookingForm_Load(object sender, EventArgs e)
        {
            GetArtistList();
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
    }
}
