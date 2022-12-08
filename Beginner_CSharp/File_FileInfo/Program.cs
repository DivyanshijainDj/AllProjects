// See https://aka.ms/new-console-template for more information
Console.WriteLine("working with file and fileinfo");
Console.WriteLine();


string path= @"c:\temp\myfile.jpg";
string path1 = @"d:\temp\myfile.jpg";
File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg");

File.Delete(path);


FileInfo file = new FileInfo(path);

file.CopyTo(path1);
file.Delete();

if (file.Exists)
{
    //do somethinf
}
