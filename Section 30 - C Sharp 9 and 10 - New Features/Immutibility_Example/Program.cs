readonly struct BankAccount
{
    private readonly int _accountNumber;
    private readonly double _currentBalance;

    public BankAccount(int accountNumber, double currentBalance)
    {
        _accountNumber = accountNumber;
        _currentBalance = currentBalance;
    }

    //you must initialize all the fields
    public BankAccount()
    {
        _accountNumber = 0;
        _currentBalance = 0;
    }

    //public properties
    //public int AccountNumber { get { return _accountNumber; } }
    //or
    public int AccountNumber { get =>  _accountNumber; init => _accountNumber = value;}
   
    public double CurrentBalance
    {
        get => _currentBalance; init
        {
            if (value >= 0)
            {
                _currentBalance = value;
            }
        }
    }
}

class DataStorage
{
    // Developer 1 (YOU)
    public static List<BankAccount> GetBankAccounts()
    {
        return new List<BankAccount>()
        {
            new BankAccount(){AccountNumber = 1},
            new BankAccount(2,2000)
        };
    }
    
    //Deverloper 2
    public static double GetCurrentBalance(BankAccount bankAccount)
    {
        //still, you will get errror 
        //bankAccount.AccountNumber = 100; // you can not set any value as it is the read only property.
        return bankAccount.CurrentBalance;
    }
}

class Program
{
    static void Main()
    {
       List<BankAccount> bankAccounts =  DataStorage.GetBankAccounts();
       BankAccount firstBankAccount = bankAccounts[0];

       double bal = DataStorage.GetCurrentBalance(firstBankAccount);
       Console.WriteLine(firstBankAccount.AccountNumber + "," + bal);
       Console.ReadKey();
    }
}