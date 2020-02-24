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
    public partial class frmArtists : Form
    {
        private string connectionString = Helper.connectionString;
        private SqlDataAdapter daArtistType, daArtist;
        private DataSet dsStudio = new DataSet();

        private List<Artist> allArtists = new List<Artist>();
        public bool isEditOpen = false;

        public frmArtists()
        {
            InitializeComponent();

            GetArtistType();
            GetAllArtists();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                int id = GetArtistID() + 1;
                string forename = txtArtistForename.Text;
                string surname = txtArtistSurname.Text;
                string dob = dtDOB.Value.ToString("yyyy-M-d");
                string hourly = txtHourlyRate.Text;

                try
                {

                    string sql = @"INSERT INTO Artist (ArtistID, ArtistForename, ArtistSurname, ArtistDOB, ArtistHourlyPrice, ArtistTypeID) VALUES('" + id+"', '" + forename+"', '" + surname +"', '" + dob + "', '" + hourly+"', '" + cboArtistType.SelectedValue +"')";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand addCustomer = new SqlCommand(sql, conn);
                        conn.Open();

                        SqlDataReader customerReader = addCustomer.ExecuteReader();
                        while (customerReader.Read()) { }
                        conn.Close();
                    }

                    MessageBox.Show("Artist Successfuly Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetAllArtists();

                    UpdateEditArtistList();
                    UpdateDeleteAritstList();

                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Adding the Artist, please try again!\n" + ex.Message, "Error Adding Artist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            bool success = true;
            string error = "";

            //Customer Forename
            if(string.IsNullOrWhiteSpace(txtArtistForename.Text) == false && txtArtistForename.Text.Length > 3)
            {

            }
            else
            {
                error += "The Artist Forename cannot be empty and must be more than 3 characters long!\n";
                success = false;
            }

            //Customer Surname
            if(string.IsNullOrWhiteSpace(txtArtistSurname.Text) == false && txtArtistSurname.Text.Length > 3)
            {

            }
            else
            {
                error += "The Artist Surname cannot be empty and must be more than 3 characters long!\n";
                success = false;
            }

            if(string.IsNullOrWhiteSpace(txtHourlyRate.Text) == false)
            {

            }
            else
            {
                success = false;
            }
            if(!success)
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return success;
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

        private int GetArtistID()
        {
            int customerID = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand getCount = new SqlCommand("SELECT ArtistID FROM Artist", conn);
                    conn.Open();

                    SqlDataReader countReader = getCount.ExecuteReader();

                    int id = -1;

                    while (countReader.Read())
                    {
                        id = Int32.Parse(countReader[0].ToString());
                    }
                    conn.Close();

                    //Assign Booking Variables
                    customerID = id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Getting Artist ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return customerID;
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

        private void ClearFields()
        {
            txtArtistForename.Text = "";
            txtArtistSurname.Text = "";
            dtDOB.Value = DateTime.Now;
            txtHourlyRate.Text = "";
        }

        public void GetAllArtists()
        {
            allArtists.Clear();

            string sqlCustomer = @"SELECT * FROM Artist";

            daArtist = new SqlDataAdapter(sqlCustomer, connectionString);
            daArtist.FillSchema(dsStudio, SchemaType.Source, "Artists");

            daArtist.Fill(dsStudio, "Artists");

            foreach (DataRow dr in dsStudio.Tables["Artists"].Rows)
            {
                Artist a = new Artist();
                a.ArtistID = Int32.Parse(dr["ArtistID"].ToString());
                a.Forename = dr["ArtistForename"].ToString();
                a.Surname = dr["ArtistSurname"].ToString();
                a.DOB = dr["ArtistDOB"].ToString().Split(' ')[0];
                a.Hourly = float.Parse(dr["ArtistHourlyPrice"].ToString());
                a.Type = new ArtistType();

                foreach (DataRow item in dsStudio.Tables["ArtistType"].Rows)
                {
                    if(item[0].ToString() == dr["ArtistTypeID"].ToString())
                    {
                        a.Type.ArtistTypeID = Int32.Parse(dr["ArtistTypeID"].ToString());
                        a.Type.ArtistTypeDescription = item[1].ToString();
                    }
                }

                allArtists.Add(a);
            }

            UpdateEditArtistList();
            UpdateDeleteAritstList();
        }

        public void UpdateEditArtistList()
        {
            dgvEditArtist.DataSource = null;

            dgvEditArtist.DataSource = allArtists.Select(Artist => new {
                Artist.ArtistID,
                Artist.Forename,
                Artist.Surname,
                Artist.DOB,
                Artist.Hourly,
                Artist.Type.ArtistTypeDescription
            }).ToList();

            dgvEditArtist.Update();
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            Artist a = SelectedDeleteArtist();

            if(a != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the artist?", "Delete Artist?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //Delete
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string sql = @"DELETE FROM Artist WHERE ArtistID = '" + a.ArtistID + "'";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            conn.Open();

                            cmd.ExecuteNonQuery();

                            conn.Close();

                            int id = 0;

                            foreach (Artist artist in allArtists)
                            {
                                if (artist.ArtistID == a.ArtistID)
                                {
                                    id = allArtists.IndexOf(artist);
                                }
                            }

                            allArtists.RemoveAt(id);

                            UpdateEditArtistList();
                            UpdateDeleteAritstList();

                            MessageBox.Show("Artist Successfully Deleted", "Artist Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error getting the selected Artist, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Artist SelectedDeleteArtist()
        {
            foreach (DataGridViewRow row in dgvDeleteArtist.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                foreach (Artist artist in allArtists)
                {
                    if (id == artist.ArtistID)
                    {
                        return artist;
                    }
                }
            }

            return null;
        }

        private Artist SelectedEditArtist()
        {
            foreach (DataGridViewRow row in dgvEditArtist.SelectedRows)
            {
                int id = Int32.Parse(row.Cells[0].Value.ToString());

                foreach (Artist artist in allArtists)
                {
                    if (id == artist.ArtistID)
                    {
                        return artist;
                    }
                }
            }

            return null;
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            Artist a = SelectedEditArtist();
            if(a != null)
            {
                if (!isEditOpen)
                {
                    frmEditArtist ea = new frmEditArtist();
                    ea.currentArtist = a;
                    ea.Master = this;
                    isEditOpen = true;
                    ea.Show();
                }
                else
                {
                    MessageBox.Show("Edit window already open, please close it and try again!", "Edit Window already Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error Selecting artist to edit, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDeleteAritstList()
        {
            dgvDeleteArtist.DataSource = null;
            dgvDeleteArtist.DataSource = allArtists.Select(Artist => new {
                Artist.ArtistID,
                Artist.Forename,
                Artist.Surname,
                Artist.DOB,
                Artist.Hourly,
                Artist.Type.ArtistTypeDescription
            }).ToList();
        }
    }
}
