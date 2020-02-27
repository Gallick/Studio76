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
using CrystalDecisions.Windows.Forms;
using Studio76.Classes;
using Studio76.CrystalReports;

namespace Studio76.Forms
{
    public partial class frmReportWinodw : Form
    {
        public int BookingID;
        private BookingRecipt recipt;

        public frmReportWinodw()
        {
            InitializeComponent();

        }

        private void frmReportWinodw_Load(object sender, EventArgs e)
        {
            recipt = new BookingRecipt();
            recipt.SetParameterValue(0, BookingID);
            rpvViewer.ReportSource = recipt;

            //recipt.Parameter__bookingID.CurrentValues.AddValue(BookingID);
        }
    }
}