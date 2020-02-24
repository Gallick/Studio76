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
    public partial class frmEditArtist : Form
    {
        public Artist currentArtist;
        public frmArtists Master;

        private SqlDataAdapter daArtistType;
        private DataSet dsStudio = new DataSet();
        private string connectionString = Helper.connectionString;

        public frmEditArtist()
        {
            InitializeComponent();
            GetArtistType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                try
                {
                    int id = currentArtist.ArtistID;
                    string forename = txtArtistForename.Text;
                    string surname = txtArtistSurname.Text;
                    string dob = dtDOB.Value.ToString("yyyy-M-d");
                    string hourly = txtHourlyRate.Text;

                    string sql = @"UPDATE Artist SET ArtistID = '" + id +"', ArtistForename = '" + forename + "', ArtistSurname = '" + surname +"', ArtistDOB = '" + dob +"', ArtistHourlyPrice = '" + hourly +"', ArtistTypeID = '" + cboArtistType.SelectedValue +"' WHERE ArtistID = '" + id +"'";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        conn.Close();
                        this.Close();
                    }

                    Master.GetAllArtists();
                    Master.UpdateEditArtistList();
                    Master.UpdateDeleteAritstList();

                    MessageBox.Show("Artist Successfuly Edited!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Updating Customer, Please try again!\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            bool success = true;
            string error = "";

            //Customer Forename
            if (string.IsNullOrWhiteSpace(txtArtistForename.Text) == false && txtArtistForename.Text.Length > 3)
            {

            }
            else
            {
                error += "The Artist Forename cannot be empty and must be more than 3 characters long!\n";
                success = false;
            }

            //Customer Surname
            if (string.IsNullOrWhiteSpace(txtArtistSurname.Text) == false && txtArtistSurname.Text.Length > 3)
            {

            }
            else
            {
                error += "The Artist Surname cannot be empty and must be more than 3 characters long!\n";
                success = false;
            }

            if (string.IsNullOrWhiteSpace(txtHourlyRate.Text) == false)
            {

            }
            else
            {
                success = false;
            }
            if (!success)
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return success;
        }

        private void frmEditArtist_Load(object sender, EventArgs e)
        {
            txtArtistForename.Text = currentArtist.Forename;
            txtArtistSurname.Text = currentArtist.Surname;
            txtHourlyRate.Text = currentArtist.Hourly.ToString();

            cboArtistType.Text = currentArtist.Type.ArtistTypeDescription;

            dtDOB.Value = DateTime.ParseExact(currentArtist.DOB.Split(' ')[0], "d/M/yyyy", CultureInfo.InvariantCulture);

        }

        private void GetArtistType()
        {
            try
            {
                string sqlArtist = @"SELECT * FROM ArtistType";

                daArtistType = new SqlDataAdapter(sqlArtist, connectionString);
                daArtistType.FillSchema(dsStudio, SchemaType.Source, "ArtistType");

                daArtistType.Fill(dsStudio, "ArtistType");

                cboArtistType.DataSource = dsStudio.Tables["ArtistType"];
                cboArtistType.ValueMember = "ArtistTypeID";
                cboArtistType.DisplayMember = "ArtistTypeDescription";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmEditArtist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Master.isEditOpen = false;
        }

        private void txtHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
