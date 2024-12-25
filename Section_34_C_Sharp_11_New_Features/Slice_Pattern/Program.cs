Console.WriteLine(new List<int> { 10, 20, 50 } is [10, < 25, 50 or 100]); //true
Console.WriteLine(new List<int> { 10,15, 20, 50 } is [10, _ ,< 25, 50 or 100]); //true
Console.WriteLine(new List<int> { 10, 15,18,20,50 } is [10, _ ,< 25, 50 or 100]); //false
Console.WriteLine(new List<int> { 10,15,18,20,50} is [10,_,_,<25, 50 or 100]); //  true
Console.WriteLine(new List<int> { 10,15,18,20,50} is [10,..,<25, 50 or 100]); //  true

Console.WriteLine(new List<int> { 10, 20, 50 } is [10,..,<25,50 or 100]); //true
Console.WriteLine(new List<int> { 10,15,18,20,50} is [.., <25, 50 or 100]); // true
Console.WriteLine(new List<int> { 10, 15, 18, 20, 50 } is [10, 15, ..]); //true

//Console.WriteLine(new List<int> { 10, 15, 18, 20, 50 } is [10,.., <25,..]); //error

//Nested List Pattern along with Slice Pattern
Console.WriteLine(new List<int> { 10, 15, 18, 20, 50 } is [10, < 25, .., [_, >= 30, ..]]);

Console.ReadKey(); 
