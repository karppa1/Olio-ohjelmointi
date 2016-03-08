using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            Product product1 = new Product("Milk", 1.4);
            Product product2 = new Product("Beer", 2.2);
            Product product3 = new Product("Butter", 3.2);
            Product product4 = new Product("Cheese", 4.2);

            products.Add(product1.ToString());
            products.Add(product2.ToString());
            products.Add(product3.ToString());
            products.Add(product4.ToString());
            
            Console.WriteLine("All products in collection: \n");            
            foreach(string data in products)
            {
                Console.WriteLine(data);
            }            

            Console.ReadLine();
        }
    }
}
