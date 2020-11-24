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
        public static void MapProductByCategory(List<Product> products, List<Category> categories)
        {
            List<Product> productSorted = new List<Product>();
            foreach (var category in categories)
            {
                Console.WriteLine(category.name + ":");
                for (int i = 0; i < products.Count(); i++)
                    if (products[i].categoryId == category.id)
                    {
                        productSorted.Add(products[i]);
                        Console.WriteLine("Product {" + products[i].name + ", " + products[i].price + ", " + products[i].quality + ", " + products[i].categoryId + " - " + category.name + "}");
                    }    
            }
            //return productSorted;
        }
    }
}
