using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3___Q_4
{
        class Product
        {
            public string ProductName;
            public double Price;

            public Product(string productName, double price)
            {
                ProductName = productName;
                Price = price;
            }
        }

        class program
        {
            static void Main()
            {
                Product product1 = new Product("Laptop", 999.99);
                Product product2 = new Product("Smartphone", 599.99);

                Console.WriteLine("Product 1: " + product1.ProductName + " - $" + product1.Price);
                Console.WriteLine("Product 2: " + product2.ProductName + " - $" + product2.Price);
            }
        }

    }

