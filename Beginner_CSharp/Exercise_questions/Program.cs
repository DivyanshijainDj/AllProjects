// See https://aka.ms/new-console-template for more information



Console.WriteLine("Exercise Questions");
Console.WriteLine();

Console.WriteLine("Q1: Write a program that reads a text file and displays the number of words");

Console.WriteLine();


//String line;
//int count = 0;
//File file = new File(@"C:\Users\coditas\Desktop\data\data.txt");
//String[] words;

//while ((line = file.ReadLine()) != null)
//{
//    words = line.Split(' ');
//    count = count + words.Length;
//}
//Console.WriteLine("Number of words: " + count);
//Console.WriteLine();

//file.Close();

//Console.WriteLine("Q2: Write a program that reads a text file and displays the longest word present in the file.");
//Console.WriteLine();

//string AllData = file.R
//Console.WriteLine(AllData);



string path = @"C:\Users\coditas\Desktop\data\data.txt";

string filedata = File.ReadAllText(path);

int wordCount = 1, statementCount = 0;

for (int i = 0; i < filedata.Length; i++)
{
    if (filedata[i] == ' ')
    {
        wordCount++;
    }
}







