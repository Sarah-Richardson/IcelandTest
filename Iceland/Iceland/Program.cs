using Iceland.Helpers;
using Iceland.Models;
using System;

namespace Iceland
{
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new DataManager();
            var products = dm.Load(); // reads the input data from a json file

            if (products == null) return; // no data found

            foreach (var product in products)
            {
                product.Update();
                DisplayResults(product);
            }

            dm.Save(products, "Data\\output.json");

            Console.ReadKey();
        }

        public static void DisplayResults(Product product)
        {
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Type: {product.ProductType.ToString()}");
            Console.WriteLine($"Sell In: {product.SellIn}");
            Console.WriteLine($"Quality: {product.Quality}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
