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
                        break;
                    case 2: // TO DO: Display Accounts menu
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
}