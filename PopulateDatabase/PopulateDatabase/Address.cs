using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateDatabase
{
    public class Address
    {
        public string Street { get; set; }
        public string Town { get; set; }

        public Address(string _street, string _town)
        {
            Street = _street;
            Town = _town;
        }
    }
}
