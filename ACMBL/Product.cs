using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class Product :EntityBase,ILoggable
    {
        public Product()
        {

        }
        public Product(int ProductId)
        {
            this.ProductId = ProductId;   
        }
        
        public int ProductId { get; private set; }
        public String Descriptionroduct { get; set; }
        public decimal? CurrentPrice { get; set; }

        private string _ProductName;

        public string ProductName
        {
            get
            {

                return _ProductName.InsertSpace();
            }
            set
            {
                _ProductName = value;   
            }
        }

        public string Log() => $"{ProductId} : {ProductName} Detail {Descriptionroduct} Price {CurrentPrice} Status {EntityState.ToString()}";

        public override string ToString() => ProductName;

        public override bool Validatin()
        {
            bool isvalid = true;
            if (String.IsNullOrWhiteSpace(ProductName)) isvalid = false;
            if(CurrentPrice == null) isvalid = false;
            return isvalid;
            
        }

    }
}
