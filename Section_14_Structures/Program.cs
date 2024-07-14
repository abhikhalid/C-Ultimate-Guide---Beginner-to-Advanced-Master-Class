using System;

class Program
{
    static void Main()
    {
        //create structure instance
        //Category category;

        //initialize fields through properites

        //showing error because of all the fields of the structure are not initialized.
        
        /*
        category.CategoryID = 20;
        category.CategoryName = "General";

        */

        // So it is must to initialize all the fields of the structure by calling the parameter-less consturctor
        
        //we are not creating any objects by using new keyword.
        //Our intention is only to call the parameter-less constructor only to initialize of fields of the structure.
        Category category = new Category();
        category.CategoryID = 20;
        category.CategoryName = "General";

        //access methods
        Console.WriteLine(category.CategoryID);
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(category.GetCategoryNameLength());

        Console.ReadKey();
    }
}