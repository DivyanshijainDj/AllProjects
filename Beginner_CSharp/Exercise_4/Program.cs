// See https://aka.ms/new-console-template for more information
Console.WriteLine("EXercise - 4");
Console.WriteLine();

//Write a program and ask the user to enter a few numbers separated by a hyphen. 
//    Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
//    display a message: "Consecutive"; otherwise, display "Not Consecutive".

//Console.WriteLine("enter number seperated by hyphen");
//String Numberarray = Console.ReadLine();

//String[] number = Numberarray.Split('-');

//List<int> num = new List<int>();
//foreach(var item in number)
//{
//    num.Add(Convert.ToInt32(item));
//}

//int count = 0;
//for(int i=0;i< num.Count-1; i++)
//{
//    if (num[i] + 1 == num[i + 1])
//    {
//        count++;
//    }
//    else
//    {
//        Console.WriteLine("non consecutive");
//        break;
//    }
//}

//if (count > 0)
//{
//    Console.WriteLine("consecutive");
//}




//2 - Write a program and ask the user to enter a few numbers separated by a hyphen. 
//    If the user simply presses Enter, without supplying an input, exit immediately; otherwise, 
//    check to see if there are duplicates. If so, display "Duplicate" on the console.

//Console.WriteLine("enter number seperated by hyphen");


//String Numberarray = Console.ReadLine();
//if (String.IsNullOrWhiteSpace(Numberarray))
//{
//    return;
//}

//String[] number = Numberarray.Split('-');

//List<int> num = new List<int>();
//foreach (var item in number)
//{
//    num.Add(Convert.ToInt32(item));
//}

//for(int i=0;i< num.Count; i++)
//{
//    for(int j = 0; j < i; j++)
//    {
//        if(num[i] == num[j])
//        {
//            Console.WriteLine("duplicate");
//            break;
//        }

//    }
//}


//3 - Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
//    A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, 
//    display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.

//Console.Write("please enter time ");
//String input = Console.ReadLine();

//if (String.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Invalid ");
//    return;
//}

//String[] components = input.Split(':');

//if (components.Length != 2)
//{
//    Console.WriteLine("Invalid ");

//    return;
//}

//    int hour = Convert.ToInt32(components[0]);
//    int minute = Convert.ToInt32(components[1]);

//    if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
//{


//    Console.WriteLine("Ok");
//}

//else
//    Console.WriteLine("Invalid ");




//4 - Write a program and ask the user to enter a few words separated by a space. 
//    Use the words to create a variable name with PascalCase. For example, 
//    if the user types: "number of students", display "NumberOfStudents".Make sure that the program 
//    is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still 
//    display "NumberOfStudents".


//Console.Write("Enter a few words: ");
//String value = Console.ReadLine();



//String variableName = "";

//foreach (String word in value.Split(' '))
//{
//    String result = char.ToUpper(word[0]) + word.ToLower().Substring(1);

//    variableName += result;
//}

//Console.WriteLine(variableName);




//5 - Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
//    So, if the user enters "inadequate", the program should display 6 on the console.

Console.Write("Enter word ");

String word = Console.ReadLine();


char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };

int count = 0;
foreach (var item in word)
{
    if (vowels.Contains(item))
        count++;
}

Console.WriteLine("count is : {0}", count);


