class BankAccount
{
    private readonly int _accountNumber;
    private readonly double _currentBalance;

    public BankAccount(int accountNumber, double currentBalance)
    {
        _accountNumber = accountNumber;
        _currentBalance = currentBalance;
    }

    //public properties
    //public int AccountNumber { get { return _accountNumber; } }
    //or
    public int AccountNumber { get =>  _accountNumber; }
    public double CurrentBalance { get => _currentBalance; }
}

class DataStorage
{
    // Developer 1 (YOU)
    public static List<BankAccount> GetBankAccounts()
    {
        return new List<BankAccount>()
        {
            new BankAccount(1,1000),
            new BankAccount(2,2000)
        };
    }
    
    //Deverloper 2
    public static double GetCurrentBalance(BankAccount bankAccount)
    {
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