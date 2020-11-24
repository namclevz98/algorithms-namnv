using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai15_minByPrice
    {
        // show product has the lowest price
        public static Product MinByPrice(List<Product> products)
        {
            Product productMin = products[0];
            foreach (var product in products)
                if (productMin.price > product.price)
                {
                    productMin = product;
                }
            return productMin;
        }
    }
}
