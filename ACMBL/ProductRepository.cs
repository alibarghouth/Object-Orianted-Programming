using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public class ProductRepository 
    {
        public Product Retrieve(int ProductId)
        {
            Product product = new Product(ProductId);
            if(ProductId == 2)
            {
                product.ProductName = "Cookies";
                product.Descriptionroduct = "is nice";
                product.CurrentPrice = 16.99M;
            }
            return product;
            
        }
        Object m = new Object();
     
        public bool Save(Product product)
        {
            
            var success = true;
            if (product.Haschange)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
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
