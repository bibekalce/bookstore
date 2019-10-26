using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public int Postcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
