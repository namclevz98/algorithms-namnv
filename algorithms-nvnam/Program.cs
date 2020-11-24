using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_nvnam
{
    class Program
    {
        public static void DisplayProduct(Product product)
        {
            Console.WriteLine("Product {" + product.name + ", " + product.price + ", " + product.quality + ", " + product.categoryId + "}");
        }
        static void Main(string[] args)
        {
            string searchString = "CPU";
            List<Product> products = new List<Product>();
            products.Add(new Product() { name = "CPU", price = 750, quality = 10, categoryId = 1 });
            products.Add(new Product() { name = "RAM", price = 50, quality = 2, categoryId = 2 });
            products.Add(new Product() { name = "HDD", price = 70, quality = 1, categoryId = 2 });
            products.Add(new Product() { name = "Main", price = 400, quality = 3, categoryId = 1 });
            products.Add(new Product() { name = "Keyboard", price = 30, quality = 8, categoryId = 4 });
            products.Add(new Product() { name = "Mouse", price = 25, quality = 50, categoryId = 4 });
            products.Add(new Product() { name = "VGA", price = 60, quality = 35, categoryId = 3 });
            products.Add(new Product() { name = "Monitor", price = 120, quality = 28, categoryId = 2 });
            products.Add(new Product() { name = "Case", price = 120, quality = 28, categoryId = 5 });

            List<Category> categories = new List<Category>();
            categories.Add(new Category() { id = 1, name = "Comuter" });
            categories.Add(new Category() { id = 2, name = "Memory" });
            categories.Add(new Category() { id = 3, name = "Card" });
            categories.Add(new Category() { id = 4, name = "Acsesory" });

            List<Menu> menus = new List<Menu>();
            menus.Add(new Menu() { id = 1, title = "Thể thao", parent_id = 0 });
            menus.Add(new Menu() { id = 2, title = "Xã hội", parent_id = 0 });
            menus.Add(new Menu() { id = 3, title = "Thể thao trong nước", parent_id = 1 });
            menus.Add(new Menu() { id = 4, title = "Giao thông", parent_id = 2 });
            menus.Add(new Menu() { id = 5, title = "Môi trường", parent_id = 2 });
            menus.Add(new Menu() { id = 6, title = "Thể thao quốc tế", parent_id = 1 });
            menus.Add(new Menu() { id = 7, title = "Môi trường đô thị", parent_id = 5 });
            menus.Add(new Menu() { id = 8, title = "Giao thông ùn tắc", parent_id = 4 });

            Console.WriteLine("All Products:");
            foreach (var product in products)
                DisplayProduct(product);

            Console.WriteLine("Product with name = " + searchString + ":");
            DisplayProduct(Bai4_findProduct.FindProduct(products, searchString));

            List<Product> productsByCategoryID = Bai5_findProductByCategory.FindProductByCategory(products, 2);
            Console.WriteLine("Products's list with CategoryID = 2:");
            foreach (var product in productsByCategoryID)
                DisplayProduct(product);

            List<string> productsByPrice = Bai6_findProductByPrice.FindProductByPrice(products, 100);
            Console.WriteLine("Products's list with lower price or equal to 100:");
            foreach (var product in productsByPrice)
                Console.Write(product + ", ");

            List<Product> productsSortByPrice = Bai11_sortByPrice.SortByPrice(products);
            Console.WriteLine("\n(BubbleSort) SortByPrice:");
            foreach (var product in productsSortByPrice)
                DisplayProduct(product);

            List<Product> productsSortByName = Bai12_sortByName.SortByName(products);
            Console.WriteLine("(InsertionSort) SortByName:");
            foreach (var product in productsSortByName)
                DisplayProduct(product);
            List<Product> productsSortByCategory = Bai13_sortByCategoryName.SortByCategoryName(products, categories);
            Console.WriteLine("(SelectionSort) SortByCategory:");
            foreach (var product in productsSortByCategory)
                DisplayProduct(product);

            Console.WriteLine("List Procduct mapped by Category");
            Bai14_MapProductByCategory.MapProductByCategory(products, categories);

            Console.WriteLine("Product with minimum price:");
            DisplayProduct(Bai15_minByPrice.MinByPrice(products));

            Console.WriteLine("Product with maximum price:");
            DisplayProduct(Bai16_maxByPrice.MaxByPrice(products));
            Console.ReadKey();

        }
    }
}
