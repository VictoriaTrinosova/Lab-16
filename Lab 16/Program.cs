using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[5];
            product[0] = new Product();
            product[1] = new Product();
            product[2] = new Product();
            product[3] = new Product();
            product[4] = new Product();
            foreach (var i in product)
            {
                i.String();
            }


            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented=true
            };
            string jsonString1 = JsonSerializer.Serialize(product, options);
            Console.WriteLine(jsonString1);
            StreamWriter file = new StreamWriter("C:/Users/Виктория/Desktop/Bim проектирование/лр 16/Products.json");
            file.Write(jsonString1);
            file.Close();
            Console.ReadKey();
        }
    }

    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public void String()
        {
            Code = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Price = Convert.ToDouble(Console.ReadLine());
        }

    }

    
}











