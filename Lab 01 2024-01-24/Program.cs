using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_01_2024_01_24
{
    /*    Q-01
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the height");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width");
            int w = Convert.ToInt32(Console.ReadLine());

            CalculateRectangleArea(h, w);
          }


        static void CalculateRectangleArea(int height, int width)
          {
            
            int area;

            
           area = height * width;

          Console.WriteLine("The area is :" + area);
          Console.ReadLine();
          }
    }
    */

    /* Q-02
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{number} is {(number % 2 == 0 ? "even" : "odd")}");
            }
        }

    }
    */


    /* Q-03
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num <= 0)
                {
                    Console.WriteLine("ERROR");

                }
                else
                {
                    sum += i;
                    Console.WriteLine("the total is " + sum);
                }
            }

            Console.ReadLine();


        }
    }
    */


    /* Q-04
    static void Main(string[] args)

    {

        Console.WriteLine("Enter the value of fibonacci you want");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("First " + n + " teras of the fibonacci series: ");

        for (int i = 0; i < n; i++)
        {
            int result = Fibbonacci(1);
            Console.WriteLine(result);

        }
        Console.ReadLine();
    }

    static int Fibbonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibbonacci(n - 1) + Fibbonacci(n - 2);
        }


    }
    */


    /* Q-05
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number you want to get multiplication table : ");
            int number = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                int result = number * i;
                Console.WriteLine(number + " * " + i + " = " + result);
            }

            Console.ReadLine();

        }

    }
    */



    /* Q-06
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your marks: ");
            double marks = double.Parse(Console.ReadLine());
            if(marks>100)
            {
                Console.WriteLine("Enter a valid marks");
            }

            else if (marks >= 75)
            {
               Console.WriteLine(name + " your grade is A");
            }
            else if (marks >= 65)
            {
               Console.WriteLine(name + " your grade is B");
            }
            else if (marks >= 50)
            {
               Console.WriteLine(name + " your grade is C");
            }
            else if (marks >= 40)
            {
               Console.WriteLine(name + " your grade is D");
            }
            else if (marks < 39)
            {
               Console.WriteLine(name + " your grade is F");
            }
            else if (marks < 0)
            {
               Console.WriteLine("Enter a valid mark ");
            }
            Console.ReadLine();
        }
    }
    */


    /* Q-07

    public class BankAccount
    {
        private double balance; // Privet field

        // Constructer

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        // Method to deposit money

        public void Deposit(double amount)
        {
            // Accessing the privet field balance within the class
            balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance : ${balance}");
        }

        // Method to display the balance

        public void DisplayBalance()
        {
            // Accessing the privet field balance within the class
            Console.WriteLine($"Current balance : ${balance}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1000);

            // Trying to access the private field balance directly (Error)
            // myAccount.balance = 50000; // Error: 'BankAccount.balance' is inaccessible due to its protection level

            myAccount.Deposit(200);
            myAccount.DisplayBalance();
            Console.Read();
        }
    }


    */
}











