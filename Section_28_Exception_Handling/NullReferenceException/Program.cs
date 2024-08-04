using System;

namespace NullReferenceException1
{
    class BankAccount
    {
        public int AccountNumber { get; set; }

        public string AccountHolderName { get; set; }

        public double CurrentBalance { get; set; }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount,double amount)
        {
            try
            {
                sourceAccount.CurrentBalance -= amount;
                destinationAccount.CurrentBalance += amount;
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("The value of 'destinationAccount' is null");
                throw; //added later
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
            catch(NullReferenceException ex)
            {
                Console.WriteLine("The destination account is null");
            }

            Console.ReadKey();
        }
    }
}
