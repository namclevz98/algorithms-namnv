using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai6_findProductByPrice
    {
        // show list of products'name with lower or equal to provided price
        public static List<string> FindProductByPrice(List<Product> products, int price)
        {
            List<string> results = new List<string>();

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].price < price)
                {
                    results.Add(products[i].name);
                }
            }
            return results;
        }
    }
}
