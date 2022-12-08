// See https://aka.ms/new-console-template for more information
using System.Text;
Console.WriteLine("String Builder");


StringBuilder sb = new StringBuilder("divyanshi");
sb.Append(", sanidhya");
sb.Append(", princee");
sb.AppendLine();

Console.WriteLine(sb);

StringBuilder sb1 = new StringBuilder("Welcome World");
sb1.Insert(8, "its C# ");


Console.WriteLine("Insert String: " + sb1);

StringBuilder sb2 = new StringBuilder("hello world");
sb2.Remove(8, 3);
Console.WriteLine(sb2);

StringBuilder sb3 = new StringBuilder("Welcome to c# World");
sb3.Replace("world", "C#");
Console.WriteLine(sb3);
Console.ReadLine();
