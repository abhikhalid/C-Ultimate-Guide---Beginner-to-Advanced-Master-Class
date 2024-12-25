Person person = new Person() { Name = "Khalid" };

Console.WriteLine($"Name: {person.Name}");

//Person person2 = new Person();// though we have a default constructor, we are still getting the same error.
//to avoid this error, use '[SetsRequiredMembers]' this attribute before the constructor method.


Console.ReadKey();