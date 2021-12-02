using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lab16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:/Users/Виктория/Desktop/Bim проектирование/лр 16/Products.json");
            string jsonString = file.ReadToEnd();
            Console.WriteLine(jsonString);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            double max = 0;
            string Name = "";
            foreach (var prod in products)
            {
                if(prod.Price>max)
                {
                    max = prod.Price;
                    Name = prod.Name;
                }
            }
            Console.WriteLine("Название товара с наибольшей ценой: {0}",Name);
            Console.WriteLine("Наибольшая цена: {0}",max);
            Console.ReadKey();

        }
    }
    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        }
    }
    


