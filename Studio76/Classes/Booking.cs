using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio76.Classes
{
    public class Booking
    {
        public int BookingID { get; set; }
        public BookingDetails bookingDetails { get; set; }
        public int DetailsID {

            get { return bookingDetails.BookingID; }
            protected set { DetailsID = value; }
        }
        public int CustomerID { get; set; }
        public int ArtistID { get; set; }
        public int BookingDetailsID { get; set; }
        public string DateBooked { get; set; }

        public Booking() { }

        public Booking(int _id, BookingDetails _details, int _customerID, int _artistiD, string _dateBooked)
        {
            BookingID = _id;
            bookingDetails = _details;
            CustomerID = _customerID;
            ArtistID = _artistiD;
            DateBooked = _dateBooked;
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
