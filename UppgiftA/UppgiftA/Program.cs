using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "Röd Groda", Price = 3.50 });
            products.Add(new Product() { Name = "Grön Groda", Price = 37.30 });
            products.Add(new Product() { Name = "Blå Groda", Price = 220 });
            products.Add(new Product() { Name = "Lila Groda", Price = 666 });
            products.Add(new Product() { Name = "Gul groda", Price = 1125.67 });

            Console.WriteLine(string.Format("Det finns {0} produkter i listan.", products.Count));
            Console.WriteLine();

            for (int i = 0; i < products.Count-1; i++)
            {
                Product p = (Product)products[i];
                Console.Write(string.Format("{0} | ",p.Name));
            }
            Product q = (Product)products[products.Count - 1];
            Console.Write(q.Name);
            Console.WriteLine();

            List<Product> sorted;
            sorted = products.OrderByDescending(s => s.Price).ToList();


            Console.WriteLine(string.Format("Den dyraste produkten är {0} och kostar {1} kr.",sorted[0].Name, sorted[0].Price));

            Console.WriteLine(string.Format("Snittpriset på alla produkter är {0} kr", products.Average(s => s.Price)));
        }
    }
}
