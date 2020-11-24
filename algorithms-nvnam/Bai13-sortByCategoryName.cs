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
            //Product temp;
            //int i, j, minPosition;
            //for (i = 0; i < products.Count() - 1; i++)
            //{
            //    minPosition = i;
            //    for (j = i + 1; j < products.Count(); j++)
            //    {
            //        if (String.Compare(products[j].Category.name.ToString(), products[minPosition].Category.name.ToString()) < 0)
            //            //if (String.Compare(products[j].name.ToString(), products[minPosition].name.ToString()) < 0)
            //            minPosition = j;
            //    }
            //    if (minPosition != i)
            //    {
            //        temp = products[minPosition];
            //        products[minPosition] = products[i];
            //        products[i] = temp;
            //    }
            //}
            Category temp;
            int i, j, minPosition;
            for (i = 0; i < categories.Count() - 1; i++)
            {
                minPosition = i;
                for (j = i + 1; j < categories.Count(); j++)
                {
                    if (String.Compare(categories[j].name.ToString(), categories[minPosition].name.ToString()) < 0)
                        //if (String.Compare(products[j].name.ToString(), products[minPosition].name.ToString()) < 0)
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

            // tạo dãy category mới đã sắp xếp

        }
    }
}
