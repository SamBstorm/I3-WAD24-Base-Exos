using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    public struct Person {
        public string firstname;
        public string lastname;
        public DateTime? birthdate;
        public Address? address;
    }
    public struct Address {
        public string street;
        public string number;
        public string city;
        public string zipCode;
        public string country;
    }
}
