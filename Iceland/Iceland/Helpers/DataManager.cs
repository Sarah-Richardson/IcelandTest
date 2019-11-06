using Iceland.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Iceland.Helpers
{
    public class DataManager
    {
        private const string FileName = "Data\\products.json";

        /// <summary>
        /// Saves a list of products to a json file.
        /// </summary>
        /// <param name="products"></param>
        /// <param name="fileName"></param>
        public void Save(List<Product> products, string fileName = FileName)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            var json = JsonSerializer.Serialize(products);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Loads a list of products from a json file.
        /// </summary>
        /// <returns></returns>
        public List<Product> Load()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var products = JsonSerializer.Deserialize<List<Product>>(json);
                return products;
            }
            else
            {
                Console.WriteLine("Product JSON file not found.");
                Console.ReadLine();
            }

            return null;
        }
    }
}
