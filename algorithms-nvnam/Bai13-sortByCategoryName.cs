using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai13_sortByCategoryName
    {
        // show list of products sorted by category's name
        public static List<Product> SortByCategoryName(List<Product> products, List<Category> categories)
        {
            Category temp;
            int i, j, minPosition;
            for (i = 0; i < categories.Count() - 1; i++)
            {
                minPosition = i;
                for (j = i + 1; j < categories.Count(); j++)
                {
                    if (String.Compare(categories[j].name.ToString(), categories[minPosition].name.ToString()) < 0)
                        minPosition = j;
                }
                if (minPosition != i)
                {
                    temp = categories[minPosition];
                    categories[minPosition] = categories[i];
                    categories[i] = temp;
                }
            }
            List<Product> productSorted = new List<Product>();
            foreach ( var category in categories)
            {
                for (i = 0; i < products.Count(); i++)
                    if (products[i].categoryId == category.id)
                        productSorted.Add(products[i]);                        
            }    
            return productSorted;

        }
    }
}
