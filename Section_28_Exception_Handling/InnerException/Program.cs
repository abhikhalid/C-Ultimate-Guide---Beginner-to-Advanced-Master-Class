using System;

namespace ArgumentNull
{
    class BankAccount
    {
        public int AccountNumber { get; set; }

        public string AccountHolderName { get; set; }

        public double CurrentBalance { get; set; }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount, double amount)
        {
            /*
            try
            {
                sourceAccount.CurrentBalance -= amount;
                destinationAccount.CurrentBalance += amount;
            }
            catch (NullReferenceException ex)
            {
                //throw new ArgumentNullException("destinationAccount");
                //throw new ArgumentNullException("destinationAccount","You have supplied null value to 'destinationAccount' parameter");
                //throw new ArgumentNullException(nameof(sourceAccount));
            }
            */

            //or
            try
            {
                sourceAccount.CurrentBalance -= amount;
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("You have supplied null value to " + nameof(sourceAccount) + "parameter",ex);
            }


            try
            {
                destinationAccount.CurrentBalance += amount;
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("You have supplied null value to " + nameof(destinationAccount) + "parameter",ex);
            }
        }
    }


    internal class Program
    {
        static void Main()
        {
            try
            {
                BankAccount bobBankAccount = new BankAccount()
                {
                    AccountNumber = 101,
                    AccountHolderName = "Bob",
                    CurrentBalance = 10000
                };

                BankAccount aliceBankAccount = new BankAccount()
                {
                    AccountNumber = 102,
                    AccountHolderName = "Alice",
                    CurrentBalance = 5000
                };

                BankAccount khalidBankAccount = null;

                FundsTransfer fundsTransfer = new FundsTransfer();

                fundsTransfer.Transfer(bobBankAccount, khalidBankAccount, 1000);

                Console.WriteLine("Funds Transfered");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }

            Console.ReadKey();
        }
    }
}
