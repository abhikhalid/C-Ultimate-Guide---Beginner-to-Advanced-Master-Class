using System;
using System.IO;

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
                    throw new ArgumentException($"The value of 'CurrentBalance' should be a positive number. You have supplied {value}", nameof(CurrentBalance));
                }

                _currentBalance = value;
            }
        }
    }

    //Custom Exception
    class InsufficientFundsException : InvalidOperationException
    {
        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string message) : base(message)
        {
        }

        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class ExceptionLogger
    {
        public static void AddException(Exception ex)
        {
            string filePath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_28_Exception_Handling\Custom_Exceptions\ErrorLog.txt";
            StreamWriter streamWriter = File.AppendText(filePath);

            streamWriter.WriteLine("Exception on "+DateTime.Now);
            streamWriter.WriteLine(ex.GetType().ToString()); //Exception Name
           
            streamWriter.WriteLine("\nStack Trace:");
            streamWriter.WriteLine(ex.StackTrace);
            streamWriter.WriteLine("\nMessage:");
            streamWriter.WriteLine(ex.Message);
            streamWriter.Close();
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

                if (amount > sourceAccount.CurrentBalance)
                {
                    throw new InsufficientFundsException($"Insufficient balance in the source account. The current balance is {sourceAccount.CurrentBalance}. But the amount to trasfet is ${amount}");
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
                    CurrentBalance = 7000
                };

                BankAccount aliceBankAccount = new BankAccount()
                {
                    AccountNumber = 102,
                    AccountHolderName = "Alice",
                    CurrentBalance = 5000
                };

                BankAccount khalidBankAccount = null;

                FundsTransfer fundsTransfer = new FundsTransfer();

                fundsTransfer.Transfer(bobBankAccount, aliceBankAccount, 9000);

                Console.WriteLine("Funds Transfered");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
                ExceptionLogger.AddException(ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ActualValue);
                Console.WriteLine(ex.ParamName);
                ExceptionLogger.AddException(ex);
            }
            catch (ArgumentException ex) // it catches the object of ArgumentException which was thrown in 'Transfer' method.
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }
            //catch (InvalidOperationException ex) // it catches the object of InvalidOperationException which was thrown in 'Transfer' method.
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (InsufficientFundsException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                ExceptionLogger.AddException(ex);
            }
            catch (InvalidOperationException ex) // it catches the object of InvalidOperationException which was thrown in 'Transfer' method.
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }

            Console.ReadKey();
        }
    }
}
