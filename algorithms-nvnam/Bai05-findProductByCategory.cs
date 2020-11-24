using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai5_findProductByCategory
    {
        // Show list of products with provided categoryId
        public static List<Product> FindProductByCategory(List<Product> products, int id)
        {
            List<Product> results = new List<Product>();

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].categoryId == id)
                {
                    results.Add(products[i]);
                }
            }
            return results;
        }
    }
}
