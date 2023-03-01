using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskutusRyhmaMayhem
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public DateTime BillingDate { get; set; }

        public Customer(string name, string address, string zipcode, string city, string email, DateTime billingdate) 
        {
            Name= name;
            Address= address;   
            ZipCode= zipcode;
            City= city;
            Email= email;
        }

    }
}
