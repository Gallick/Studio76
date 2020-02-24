using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio76.Classes
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public float Hourly { get; set; }
        public ArtistType Type { get; set; }

        public Artist() { }
    }

    public class ArtistType
    {
        public int ArtistTypeID { get; set; }
        public string ArtistTypeDescription { get; set; }

        public ArtistType() { }
    }
}