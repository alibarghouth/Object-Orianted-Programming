using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int AddressId)
        {
                this.AddressId = AddressId;
        }
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }


        /// <summary>
        /// Validation The Data
        /// </summary>
        /// <returns></returns>
        /// 
        public bool Validation()
        {
            bool isValid = true;
            if(PostalCode == null) isValid = false;    
            return isValid;
        }
    }
}
