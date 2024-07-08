using System;

class Sample
{
    static void Main()
    {
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b;
        decimal d = a - b;
        decimal e = a * b;
        decimal f = a / b;
        decimal g = a % b;

        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);

        //Assignment Operators
        a += 20M;
        System.Console.WriteLine(a);
        a -= 20M;
        System.Console.WriteLine(a);
        a *= 3M;
        System.Console.WriteLine(a);
        a /= 3M;
        System.Console.WriteLine(a);
        a %= 3M;
        System.Console.WriteLine(a);

        // Increment/Decremnt Operator
        a = 10M;
        System.Console.WriteLine();
        System.Console.WriteLine(++a); // 11
        System.Console.WriteLine(a++); // 11
        System.Console.WriteLine(a); // 12
        System.Console.WriteLine(--a); // 11
        System.Console.WriteLine(a--); // 11

        // Comaparison Operators
        bool b1 = a == 10;
        System.Console.WriteLine(b1); // true
        bool b2 = a != 10;
        System.Console.WriteLine(b2); // false
        bool b3 = a < 10;
        System.Console.WriteLine(b3);
        bool b4 = a > 10;
        System.Console.WriteLine(b4);
        bool b5 = a <= 10;
        System.Console.WriteLine(b5);
        bool b6 = a >= 10;
        System.Console.WriteLine(b6);

        // Logical Operator
        System.Console.WriteLine();
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7);

        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8);

        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9);

        bool b10 = a == 10 || b == 10;
        System.Console.WriteLine(b10);

        bool b11 = !(a == 10);
        System.Console.WriteLine(b11);

        bool  b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12);

        // Concatenation Operator
        string name = "Khalid";
        int age = 20;
        string message = "Hey," + name + ",your age is " + age+".";
        System.Console.WriteLine(message);

        // Ternary Operator
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Tennager" : "Adult";

        //Operator Precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z);

        System.Console.ReadKey();
    }
}