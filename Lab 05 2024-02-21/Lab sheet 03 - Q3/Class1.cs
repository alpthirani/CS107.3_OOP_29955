using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_03___Q3
{
    internal class Class1
    {
        static void Main()
        {
            // Creating an instance of the Product class
            Product laptop = new Product(101, "Laptop", 800, 10);

            // Accessing and displaying the name, price, and quantity of the product
            laptop.DisplayProductInfo();

        }
    }
}
