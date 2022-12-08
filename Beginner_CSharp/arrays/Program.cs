// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays");
Console.WriteLine();
Console.WriteLine();

int[] numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;


Console.WriteLine(numbers[0]);


string[] strings = new string[3] { "divyanshi", "jain", "sanidhya" };

Console.WriteLine(strings[0]);
Console.WriteLine(strings[1]);
Console.WriteLine(strings[2]);

var a = 10;
var b = a;

b++;

Console.WriteLine($"{ a},{ b}");