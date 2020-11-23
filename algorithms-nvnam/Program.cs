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
        public static Product FindProduct(List<Product> products, string name)
        {
            Product product = new Product();
            for (int i = 0; i < products.Count(); i++)
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
        public static List<string> FindProductByPrice(List<Product> products, int price)
        {
            List<string> results = new List<string>();

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].price < price)
                {
                    results.Add(products[i].name);
                }
            }
            return results;
        }

        public static List<Product> SortByPrice(List<Product> products)
        {
            Product temp;
            int i, j;
            for (i = 0; i < products.Count() - 1; i++)
                for (j = 0; j < products.Count() - 1 - i; j++)
                    if (products[j].price > products[j + 1].price)
                    {
                        temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
            return products;
        }

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
        //public static List<Product> MapProductByCategory(List<Product> products, List<Category> categories)
        //{

        //}
        //public static List<Product> SortByCategory(List<Product> products)
        //{
        //    Product temp;
        //    int i, j, minPosition;
        //    for (i = 0; i < products.Count() - 1; i++)
        //    {
        //        minPosition = i;
        //        for (j = i + 1; j < products.Count(); i++)
        //        {
        //            if (products[j].Category.name > products[minPosition].Category.name) CompareStrings(strFirst, strFirst)
        //                minPosition = j;
        //        }
        //        if (minPosition != 1)
        //        {
        //            temp = products[minPosition];
        //            products[minPosition] = products[i];
        //            products[i] = temp;
        //        }
        //    }
        //    return products;
        //}
        public static Product MinByPrice(List<Product> products)
        {
            Product product = products[0];
            foreach (var pr in products)
                if (product.price > pr.price)
                {
                    product = pr;
                }
            return product;
        }
        public static Product MaxByPrice(List<Product> products)
        {
            Product product = products[0];
            foreach (var pr in products)
                if (product.price < pr.price)
                {
                    product = pr;
                }
            return product;
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
            foreach (var pr in products)
                DisplayProduct(pr);
            Console.WriteLine("Product with name = " + searchString + ":");
            Product product = FindProduct(products, searchString);
            DisplayProduct(product);

            List<Product> productsByCategoryID = FindProductByCategory(products, 2);
            Console.WriteLine("Products's list with CategoryID = 2:");
            foreach (var pr in productsByCategoryID)
                DisplayProduct(pr);

            List<string> productsByPrice = FindProductByPrice(products, 100);
            Console.WriteLine("Products's list with lower price or equal to 100:");
            foreach (var pr in productsByPrice)
                Console.Write(pr + ", ");

            List<Product> productsSortByPrice = SortByPrice(products);
            Console.WriteLine("\n(BubbleSort) SortByPrice:");
            foreach (var pr in productsSortByPrice)
                DisplayProduct(pr);

            List<Product> productsSortByName = SortByName(products);
            Console.WriteLine("(InsertionSort) SortByName:");
            foreach (var pr in productsSortByName)
                DisplayProduct(pr);

            var ProductListSort = categories.OrderBy(P => P.name);
            foreach (var pr in ProductListSort)
                Console.WriteLine("{0}, {1}", pr.id, pr.name);

            Console.WriteLine("Product with minimum price:");
            DisplayProduct(MinByPrice(products));

            Console.WriteLine("Product with maximum price:");
            DisplayProduct(MaxByPrice(products));
            Console.ReadKey();
        }
    }
}
