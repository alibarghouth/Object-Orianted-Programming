using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class AddressRepository
    {
        public Address Retrieve(int AddressId)
        {
            Address address = new Address(AddressId);

            if(AddressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "BagShot row";
                address.City = "Nablus";
                address.State = "shire";
                address.Country = "Asia";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int CustomerId)
        {
            var AddressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
               StreetLine1 = "Bag End",
               StreetLine2 = "BagShot row",
               City = "Nablus",
               State = "shire",
              Country = "Asia",
               PostalCode = "144"
            };
            AddressList.Add(address);
            Address address2 = new Address(2)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "BagShot row",
                City = "Nablus",
                State = "shire",
                Country = "Asia",
                PostalCode = "144"
            };
            AddressList.Add(address2);

            return AddressList;
        }


        public bool Save(Address address)
        {
            return true;
        }
    }
}
