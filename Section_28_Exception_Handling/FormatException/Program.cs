using System;

namespace FormatException1
{
    class BankAccount
    {
        public string AccountHolderName { get; set; }

        public int AccountNumber { get; set; }

        public double CurrentBalance { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            try
            {
                //create object of BankAcoount
                BankAccount bankAccount = new BankAccount();

                //input from keyboard
                Console.Write("Enter account holder name: ");
                bankAccount.AccountHolderName = Console.ReadLine();
                Console.WriteLine("Enter account number: ");
                bankAccount.AccountNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter current balance: ");
                bankAccount.CurrentBalance = double.Parse(Console.ReadLine());

                Console.WriteLine("\nNew bank account details:");
                Console.WriteLine("Account holder name: " + bankAccount.AccountHolderName);
                Console.WriteLine("Account number: " + bankAccount.AccountNumber);
                Console.WriteLine("Current Balance : " + bankAccount.CurrentBalance);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
