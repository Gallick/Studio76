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
        //Connections
        //private string connectionString = @"Data Source=DESKTOP-TAB21TK\SQLEXPRESS;Initial Catalog=Studio76;Integrated Security=True";
        //Tech
        private string connectionString = @"Data Source=B602-012;Initial Catalog=Studio76;Integrated Security=True";


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
    }
}
