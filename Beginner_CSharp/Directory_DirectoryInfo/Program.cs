// See https://aka.ms/new-console-template for more information
Console.WriteLine("working with directory and directoryInfo");
Console.WriteLine();
Console.WriteLine();

string path = @"d:\temp\myfile.jpg";
string path2 = @"c:\temp\myfile.jpg";

Directory.CreateDirectory(path);

Directory.GetFiles(path, "*.sln",SearchOption.AllDirectories);

DirectoryInfo di = new DirectoryInfo(path);
if (di.Exists)
{
    Console.WriteLine("Directory Already Exists");
}
else
{
    // Create directory
    di.Create();
    Console.WriteLine("Directory Created Successfully");
}
