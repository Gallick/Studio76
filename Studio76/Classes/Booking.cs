using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio76.Classes
{
    public class Booking
    { 
        private string connectionString = Helper.connectionString;


        public int BookingID { get; set; }
        public List<BookingDetails> bookingDetails{ get; set; }
        public int DetailsID {

            get { return bookingDetails[0].BookingID; }
            protected set { DetailsID = value; }
        }
        public int CustomerID { get; set; }
        public int ArtistID { get; set; }
        public int BookingDetailsID { get; set; }
        public string DateBooked { get; set; }

        //Extensions
        public string CustomerName {
            get
            {
                return GetCustomerName();
            }
        }

        public string ArtistName
        {
            get
            {
                return GetArtistName();
            }
        }

        public string BookingLengthTime
        {
            get
            {
                return GetBookingLengthTime();
            }
        }

        public Booking() { }

        public Booking(int _id, List<BookingDetails> _details, int _customerID, int _artistiD, string _dateBooked)
        {
            BookingID = _id;
            bookingDetails = _details;
            CustomerID = _customerID;
            ArtistID = _artistiD;
            DateBooked = _dateBooked;
        }

        private string GetCustomerName()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    SqlCommand getCount = new SqlCommand("SELECT CustomerForename + ' ' + CustomerSurname FROM Customer WHERE CustomerID = '" + CustomerID +"'", conn);
                    conn.Open();

                    string name = getCount.ExecuteScalar().ToString();


                    return name;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string GetArtistName()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    SqlCommand getCount = new SqlCommand("SELECT ArtistForename + ' ' + ArtistSurname FROM Artist WHERE ArtistID = '" + ArtistID + "'", conn);
                    conn.Open();

                    string name = getCount.ExecuteScalar().ToString();


                    return name;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string GetBookingLengthTime()
        {
            int length = 0;
            for (int i = 0; i < length; i++)
            {
                length += bookingDetails[i].BookingLength;
            }

            float hours = (float.Parse(length.ToString()) / 2);

            return "" + hours.ToString("F1") + " Hours";
        }
    }

    public class BookingDetails
    {
        public int BookingID { get; set; }
        public TimeSpan Time { get; set; }
        public int BookingLength { get; set; }
        public bool DepositPaid { get; set; }

        public string BookingDate { get; set; }

        public BookingDetails() { }

        public BookingDetails(int _id, TimeSpan _time, int _legnth, bool _paid, string _bookingDate)
        {
            BookingID = _id;
            Time = _time;
            BookingLength = _legnth;
            DepositPaid = _paid;
            BookingDate = _bookingDate;
        }
    }
        
}
