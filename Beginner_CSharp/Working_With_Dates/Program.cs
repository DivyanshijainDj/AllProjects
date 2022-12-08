// See https://aka.ms/new-console-template for more information
Console.WriteLine("Date time and timeSpan");
Console.WriteLine();

var timespan = new TimeSpan(1, 2, 3);

var timespan1 = TimeSpan.FromMinutes(5);


var today = DateTime.Now;
var end = today.AddMinutes(5);

var difference = today - end;


Console.WriteLine("string: " + today.ToString());
Console.WriteLine(difference);

