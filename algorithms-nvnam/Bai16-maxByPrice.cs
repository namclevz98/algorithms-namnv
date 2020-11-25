using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai16_maxByPrice
    {
        // show product has the highest price
        public static Product MaxByPrice(List<Product> products)
        {
            Product productMax = products[0];
            foreach (var product in products)
            {
                if (productMax.price < product.price)
                {
                    productMax = product;
                }
            }                    
            return productMax;
        }
    }
}
