using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
           Customer customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "alijbarghouth@gmail.com";
                customer.FirstName = "Ali";
                customer.LastName = "Barghouth";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        //Retrieve all customer

     

        //save the current customer
        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.Haschange)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        //Call an insert stored procedure
                    }
                    else
                    {
                        //Call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
