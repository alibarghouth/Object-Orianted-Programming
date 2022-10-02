using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class OrderRepository
    {
        public Order Retrieve(int OrderId)
        {
            Order order = new Order(OrderId);
            if(OrderId == 10)
            {
                order.OrderDate=new DateTimeOffset(DateTime.Now.Year,9,29,10,00,00,new TimeSpan(7,0,0));
            }
            return order;
        }
      
        public bool Save(Order order)
        {
            var success = true;
            if (order.Haschange)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {

                    }
                    else
                    {

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
