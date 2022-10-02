using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class OrderItem
    {
        public OrderItem(int OrderItemId)
        {
            this.OrderItemId = OrderItemId;
        }
        public OrderItem()
        {
                
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PuschasePrice { get; set; }
        public int Quantity { get; set; }



        //Retrieve one customer
        public OrderItem Retrieve(int OrderItemId)
        {
            return new OrderItem(OrderItemId);
        }
        //Retrieve all customer

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        //save the current customer
        public bool Save()
        {
            return true;
        }

        //validation
        public bool Validation()
        {
            bool isValid = true;
            if(Quantity <= 0) isValid = false;
            if(ProductId <= 0) isValid = false;
            if(PuschasePrice == null) isValid = false;
            return isValid;
        }

    }
}
