// See https://aka.ms/new-console-template for more information
Console.WriteLine("Strings");
Console.WriteLine();

string fname = "divyanshi jain";
Console.WriteLine(fname[0]);

Console.WriteLine(fname.Trim());

var name = fname.Substring(0, 4);
Console.WriteLine(name);

var names= fname.Split(' ');

Console.WriteLine("index 0: "+ names[0]);
Console.WriteLine("index 1: " + names[1]);

Console.WriteLine(fname.Replace("jain", "sanidhya"));

