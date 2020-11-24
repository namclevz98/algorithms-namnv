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
            var results = from product in products
                          join category in categories on product.categoryId equals category.id
                          orderby category.name ascending
                          select new { name = product.name, price = product.price, quality = product.quality, categoryId = category.id, categoryName = category.name };
            //foreach (var product in results)
            //{
            //    Console.WriteLine(product.name + " " + product.categoryName);
            //}
            List<Product> mapedProducts = new List<Product>();
            foreach (var product in results)
            {
                mapedProducts.Add(new Product() { name = product.name, price = product.price, quality = product.quality, categoryId = product.categoryId });
            }
            //return mapedProducts;

            // tìm kiếm theo từng id
            // add product
            // sắp xếp
            
            List<Product> productByCategory = new List<Product>();
            foreach (var category in categories)
            {
                Console.WriteLine(category.name + ":");
                for (int i = 0; i < products.Count(); i++)
                {
                    if (products[i].categoryId == category.id)
                    {
                        productByCategory.Add(products[i]);
                        Console.WriteLine("Product {" + products[i].name + ", " + products[i].price + ", " + products[i].quality + ", " + products[i].categoryId + " - " + category.name + "}");
                    }
                }
            }
            //return productByCategory;

        }
    }
}
