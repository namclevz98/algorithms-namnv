using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai11_sortByPrice
    {
        // show list of products sorted by price
        public static List<Product> SortByPrice(List<Product> products)
        {
            Product temp;
            int i, j;
            for (i = 0; i < products.Count() - 1; i++)
                for (j = 0; j < products.Count() - 1 - i; j++)
                    if (products[j].price > products[j + 1].price)
                    {
                        temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
            return products;
        }
    }
}
