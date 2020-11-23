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
            Console.WriteLine("Product {" + product.name + ", " + product.price + ", " + product.quality + ", " + product.categoryId  + "}");
        }
        public static Product FindProduct(List<Product> products,string name)
        {
            Product product = new Product();
            for(int i = 0; i < products.Count(); i++)
            {
                if (products[i].name == name)
                {
                    product = products[i];
                }                    
            }    
            return product;
        }
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

        public static void SortByPrice(List<Product> products)
        {
            Product temp;
            int i, j;
            for ( i = 0; i < products.Count() - 1; i++)
                for ( j = 0; j < products.Count() - 1 - i; j++)
                    if (products[j].price > products[j + 1].price)
                    {
                        temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
            Console.WriteLine("(BubbleSort) SortByPrice:");
            foreach (var product in products)
                DisplayProduct(product);
        }
        public static List<Product> findProductByPrice(List<Product> products, int price)
        {
            List<Product> results = new List<Product>();

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].price < price)
                {
                    results.Add(products[i]);
                }
            }
            return results;
        }
        static void Main(string[] args)
        {
            string searchString = "CPU";
            List<Product> products = new List<Product>();
            products.Add(new Product() { name = "CPU", price = 750, quality = 10, categoryId = 1});
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
            foreach (var pr in products)
                DisplayProduct(pr);
            Console.WriteLine("Product with name = " + searchString + ":");
            Product product = FindProduct(products, searchString);
            DisplayProduct(product);

            List<Product> productsByCategoryID = FindProductByCategory(products, 2);
            Console.WriteLine("Products's list with CategoryID = 2:");
            foreach (var pr in productsByCategoryID)
                DisplayProduct(pr);

            List<Product> productsByPrice = findProductByPrice(products, 100);
            Console.WriteLine("Products's list with lower price or equal to 100:");
            foreach (var pr in productsByPrice)
                DisplayProduct(pr);

            SortByPrice(products);
            
            int[] arr = { 2, 1, 3, 5, 4, 8, 9, 6, 7 };
            int i, j, temp;
            foreach (var a in arr)
                Console.Write(a + " ");
            Array.Sort(arr);
            for (i = 0; i < arr.Length - 1; i++)
                for (j = 0; j< arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }    
                }
            foreach (var a in arr)
                Console.Write(a + " ");
            Console.ReadKey();
        }
    }
}
