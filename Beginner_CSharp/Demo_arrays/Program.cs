// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays");
Console.WriteLine();


int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine(number.Length);

//clear

Array.Clear(number, 0, 5);
Console.WriteLine("clear");
foreach(var n in number)
    Console.WriteLine(n);


//reverse
Array.Reverse(number);
Console.WriteLine("reverse");
foreach (var n in number)
    Console.WriteLine(n);

//sort
Array.Sort(number);
Console.WriteLine("sort");
foreach (var n in number)
    Console.WriteLine(n);