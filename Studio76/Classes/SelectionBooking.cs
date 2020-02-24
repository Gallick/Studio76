using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio76.Classes
{
    public class SelectionBooking
    {
        public string BookedDate;
        public TimeSpan StartTime;
        public int BookingLength;
        public string BookingDate;
        public Artists ArtistDetails;

        public SelectionBooking(string _booked, TimeSpan _start, int _length, string _date, Artists _a)
        {
            BookedDate = _booked;
            StartTime = _start;
            BookingLength = _length;
            BookingDate = _date;
            ArtistDetails = _a;
        }
    }

    public class Artists
    {
        public int ArtistID;
        public string ArtistName;
        public float Price;

        public Artists(int _id, string _name, float _hourly)
        {
            ArtistID = _id;
            Price = _hourly;
            ArtistName = _name;
        }
    }
}
