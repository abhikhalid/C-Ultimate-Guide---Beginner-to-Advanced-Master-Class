public interface IPerson
{
    System.DateTime DateOfBirth { get; set; }


    //by default, Interface methods are public
    int GetAge();
}