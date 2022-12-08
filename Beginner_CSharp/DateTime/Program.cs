// See https://aka.ms/new-console-template for more information
Console.WriteLine("Date and time");

var today = DateTime.Now;

Console.WriteLine(today);
Console.WriteLine();


Console.WriteLine("hour: " +today.Hour);
Console.WriteLine("minutes: " +today.Minute);

Console.WriteLine(today.ToLongDateString());
Console.WriteLine(today.ToShortDateString());
Console.WriteLine(today.ToLongTimeString());
Console.WriteLine(today.ToShortTimeString());
