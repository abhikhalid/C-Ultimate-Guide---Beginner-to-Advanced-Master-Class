string[] myFriends = new string[]
{
    "Khalid","Nabil","Tausif","Tauhid","Mahmud","Sajib"
};

//Console.WriteLine(myFriends[myFriends.Count-1]);
//Console.WriteLine(myFriends[^1]);
//Console.WriteLine(myFriends[^5]);

//Range-LINQ
//IEnumerable<string> shortListedFriends = myFriends.Skip(1).Take(3);
IEnumerable<string> shortListedFriends = myFriends[1..4]; //currently it only works with array

Console.WriteLine("Short lsited friends");

foreach (var friend in shortListedFriends)
{
    Console.WriteLine(friend);
}

Console.WriteLine();

Console.ReadKey();