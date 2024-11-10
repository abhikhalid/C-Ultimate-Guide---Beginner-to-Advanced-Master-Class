//here we do not need to import any commmon namespace, because we already globally imported those namespace in 'GlobalUsing.cs' file.

List<int> numbers = new List<int> { 1, 2, 3 }; 
List<int> result =  numbers.Where(temp => temp > 0).ToList();

foreach (var item in result)
{
    Console.WriteLine(item);
}