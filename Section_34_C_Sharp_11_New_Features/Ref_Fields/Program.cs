////Example 1

//public struct RefStruct
//{
//    public int myField;
//}



//class Program
//{
//    static void Main()
//    {
//        int value = 42;
//        RefStruct refStruct = new RefStruct();
//        refStruct.myField = value;  

//        Console.WriteLine(refStruct.myField); //42
//        Console.WriteLine(value); //42

//        value = 100;
//        Console.WriteLine(refStruct.myField); //42

//        Console.ReadKey();
//    }
//}

//Example 2

public ref struct RefStruct
{
    public ref int myField; //ref field can only exist in ref structure

    public RefStruct(ref int refField)
    {
        myField = ref refField;
    }
}


class Program
{
    static void Main()
    {
        int value = 42;
        RefStruct refStruct = new RefStruct(ref value);
        //refStruct.myField = value; // reference copy (this will give error because all the reference field should be initialized through a constructor)

        Console.WriteLine(refStruct.myField); //42
        Console.WriteLine(value); //42

        value = 100;
        Console.WriteLine(refStruct.myField); //100

        //RefStruct[] x = new RefStruct(); (not allowed, A ref structu can't be the element type of an array)

        Console.ReadKey();
    }
}