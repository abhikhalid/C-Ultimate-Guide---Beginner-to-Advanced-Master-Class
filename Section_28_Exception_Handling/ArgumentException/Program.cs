using System;

namespace ArgumentException1
{
    class BankAccount
    {
        public int AccountNumber { get; set; }

        public string AccountHolderName { get; set; }

        private double _currentBalance;

        public double CurrentBalance
        {
            get => _currentBalance;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The value of 'CurrentBalance' should be a positive number. You have supplied {value}",nameof(CurrentBalance));
                }
                
                _currentBalance = value;
            }
        }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount, double amount)
        {
            try
            {
                if (amount < 0 || amount > 100000)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), 10000, "For funds transfer, the value of amount should be between 1 to 1000000");
                }
                sourceAccount.CurrentBalance -= amount;
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("You have supplied null value to " + nameof(sourceAccount) + "parameter", ex);
            }


            try
            {
                destinationAccount.CurrentBalance += amount;
            }
            catch (NullReferenceException ex)
            {
                throw new ArgumentNullException("You have supplied null value to " + nameof(destinationAccount) + "parameter", ex);
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
                    CurrentBalance = -5000
                };

                BankAccount khalidBankAccount = null;

                FundsTransfer fundsTransfer = new FundsTransfer();

                fundsTransfer.Transfer(bobBankAccount, aliceBankAccount, 150000);

                Console.WriteLine("Funds Transfered");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ActualValue);
                Console.WriteLine(ex.ParamName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
