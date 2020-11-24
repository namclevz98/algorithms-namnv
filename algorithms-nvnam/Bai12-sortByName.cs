using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai12_sortByName
    {
        // show list of products sorted by name's length
        public static List<Product> SortByName(List<Product> products)
        {
            Product temp;
            int i, holePosition;

            for (i = 1; i < products.Count(); i++)
            {
                temp = products[i];
                holePosition = i;
                while (holePosition > 0 && products[holePosition - 1].name.Length > temp.name.Length)
                {
                    products[holePosition] = products[holePosition - 1];
                    holePosition--;
                }
                if (holePosition != i)
                    products[holePosition] = temp;
            }
            return products;
        }
    }
}
