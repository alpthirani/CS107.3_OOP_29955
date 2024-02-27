using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_07
{
    public class BankAccount
    {
        public double balance;
        public string AccountNumber;


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
    class program
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

} 