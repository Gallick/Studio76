using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio76.Classes
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerForename { get; set; }
        public string CustomerSurname { get; set; }
        public string DOB { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Customer() { }
    }
}

