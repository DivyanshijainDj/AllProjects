// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lists");
Console.WriteLine();

List<int> number = new List<int>() { 1,2,3,4,5};

number.Add(10);
number.AddRange(new int[3] { 11, 22, 33 });

foreach(var numbers in number)
{
    Console.WriteLine(numbers);
}

Console.WriteLine();
Console.WriteLine($"count is: { number.Count}");


number.Remove(22);

foreach (var numbers in number)
{
    Console.WriteLine(numbers);
}