using CrystalDecisions.Shared;
using Studio76.CrystalReports;
using Studio76.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio76.Classes
{
    public class Reports
    {
        public static void GenerateBookingRecipt(int _id)
        {
            frmReportWinodw r = new frmReportWinodw();
            r.BookingID = _id;
            r.Show();

        }

        private static BookingRecipt GetBookingReciptInformation(int _id)
        {
            DataTable dtBookings = new DataTable();
            SqlConnection conn = new SqlConnection(Helper.connectionString);

            string sql = @"SELECT c.customerID, (c.CustomerForename + ' ' + c.CustomerSurname) AS Name, c.TelNo, " +
                "bd.SessionTime, bd.SessionLength, bd.SessionDate, a.ArtistID, (a.ArtistForename + ' ' + a.ArtistSurname) AS ArtistName, " +
                "b.BookingID, b.ArtistID, b.DepositPaid " +
                "FROM Booking AS b " +
                "JOIN Customer c ON c.CustomerID = b.CustomerID " +
                "JOIN Artist a ON b.ArtistID = a.ArtistID " +
                "JOIN BookingDetails bd ON b.BookingID = bd.BookingID " +
                "WHERE b.BookingID =" + _id;

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dtBookings);

            BookingRecipt rpt = new BookingRecipt();
            rpt.SetDataSource(dtBookings);

            return rpt;
            
        }
    }
}
