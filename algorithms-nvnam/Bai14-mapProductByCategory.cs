using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Bai14_MapProductByCategory
    {
        // show list of products grouped by Category
        public static List<Product> MapProductByCategory(List<Product> products, List<Category> categories)
        {
            List<Product> productSorted = new List<Product>();
            foreach (var category in categories)
            {
                for (int i = 0; i < products.Count(); i++)
                    if (products[i].categoryId == category.id)
                    {
                        productSorted.Add(new Product() { name = products[i].name , price = products[i].price, quality = products[i].quality, categoryId = products[i].categoryId, categoryName = category.name });
                    }    
            }
           return productSorted;
        }
    }
}
