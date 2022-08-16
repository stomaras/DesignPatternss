using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample2.Business.Models
{
    /*
     * Address will have city where is going to arrive
     * AddressLine1 and AddressLine2
     * 
     * 
     */
    public class Address
    {
        public string To { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
