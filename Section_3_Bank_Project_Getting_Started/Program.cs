using System.Security.Principal;

class Program
{
    //Application execution starts here
    static void Main()
    {
        System.Console.WriteLine("***City Bank***");
        System.Console.WriteLine("Login Page");

        //declare variables to store username and password
        string userName = null, password = null;

        //read userName from keyboard
        System.Console.WriteLine("Username:");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            //read password from keyboard
            System.Console.WriteLine("Password:");
            password = System.Console.ReadLine();
        }

        //Check username and password
        if (userName == "system" && password == "manager")
        {
            //declare variable to store main menu choice
            int mainMenuChoice = -1;

            do
            {
                System.Console.WriteLine("\n:::Main menu:::");
                System.Console.WriteLine("1.Customers");
                System.Console.WriteLine("2.Accounts");
                System.Console.WriteLine("3.Funds Transfer");
                System.Console.WriteLine("4.Funds Transfer Statement");
                System.Console.WriteLine("5.Account Statement");
                System.Console.WriteLine("0.Exit");

                System.Console.WriteLine("Enter choice:");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: // TO DO: Display Customers menu
                        CustomersMenu();
                        break;
                    case 2: // TO DO: Display Accounts menu
                        AccountsMenu();
                        break;
                    case 3: // TO DO: Display Fund Transfer menu
                        break;
                    case 4: // TO DO: Display Fund Transfer Statment menu
                        break;
                    case 5: // TO DO: Display Account Statement menu
                        break;
                }
            } while (mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }
        //about to exit
        System.Console.WriteLine("Thank you! Visit again.");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;
        do
        {
            //print customers menu
            System.Console.WriteLine("\n:::Customers menu:::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept customers menu choice
            System.Console.Write("Enter choice:");
            customerMenuChoice = int.Parse(System.Console.ReadLine());
            
        }while (customerMenuChoice != 0);
 
    }

    static void AccountsMenu()
    {
        //variable to store accounts menu choice
        int accountsMenuChoice = -1;
        do
        {
            //print customers menu
            System.Console.WriteLine("\n:::Accounts menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Account");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept accounts menu choice
            System.Console.Write("Enter choice:");
            accountsMenuChoice = int.Parse(System.Console.ReadLine());

        } while (accountsMenuChoice != 0);
    }
}