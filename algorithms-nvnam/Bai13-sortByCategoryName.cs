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
            Product temp;
            int i, j, minPosition;
            for (i = 0; i < products.Count() - 1; i++)
            {
                minPosition = i;
                for (j = i + 1; j < products.Count(); j++)
                {
                    if (String.Compare(GetCategoryName(products[j],categories), GetCategoryName(products[minPosition], categories)) < 0)
                        minPosition = j;
                }
                if (minPosition != i)
                {
                    temp = products[minPosition];
                    products[minPosition] = products[i];
                    products[i] = temp;
                }
            }
            return products;
        }
        static string GetCategoryName(Product product, List<Category> categories)
        {
            string categoryName = "";
            for(int i = 0; i < categories.Count(); i++)
            {
                if (product.categoryId == categories[i].id)
                {
                    categoryName = categories[i].name;
                    product.categoryName = categories[i].name;
                    break;
                }
            }
            return categoryName;
        }
    }
}
