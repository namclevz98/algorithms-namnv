using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai4_findProduct
    {
        // Show list of products with provided name
        public static Product FindProduct(List<Product> products, string name)
        {
            Product product = new Product();
            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].name == name)
                {
                    product = products[i];
                }
            }
            return product;
        }
    }
}
