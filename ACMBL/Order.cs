using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class Order : EntityBase,ILoggable
    {
        public Order(int OrderId)
        {
            this.OrderId = OrderId;
            OrderItems = new List<OrderItem>();
           
        }
        public Order():this(0)
        {

        }
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId}) ";

         


        //العلاقة بين الطلب والعميل 
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        //العلاقة بين الطلب والعميل 
        public int OrderId { get; private set; }
        //يمكن تقديم طلب من باريس الساعة العاشرة صباحا وايضا تقديم طلي من بريطانبا الساعة العاشرة صباحا ولكنه يكون ليس في نفس الوقت اي يراعي المناطق الزمنية
        public DateTimeOffset? OrderDate { get; set; }
        
        
        public override bool Validatin()
        {
            bool isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

        public string Log() => $"{OrderId} : {OrderDate} CustomerId :{CustomerId }";
    }
}
