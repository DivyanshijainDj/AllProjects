// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercise-3");
Console.WriteLine();

List<string> names = new List<string>();
while (true)
{
    string input = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(input))
    {
        break;
    }
   else
        names.Add(input);
}

if(names.Count == 1)
{
    Console.WriteLine("{0} likes your post", names[0]);
}
if (names.Count == 2)
{
    Console.WriteLine("{0} , {1} likes your post", names[0], names[1]);
}
if (names.Count >2)
{
    Console.WriteLine("{0}, {1}, {2} others likes your post", names[0], names[1], names.Count-2);
}


//Write a program and ask the user to enter their name. Use an array to
//    reverse the name and then store the result in a new string.Display 
//    the reversed name on the console.

//Console.WriteLine("enter your name");
//string name = Console.ReadLine();

//char[] namearray = name.ToCharArray();

// Array.Reverse(namearray);
//Console.WriteLine(namearray);



//Write a program and ask the user to enter 5 numbers. 
//    If a number has been previously entered, display an error message and ask the user to re-try. 
//    Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

//Console.WriteLine("enter 5 numbers");

//List<int> numbers = new List<int>();
//int count = 5;
//while (count < 5)
//{

//    int number = Convert.ToInt32(Console.ReadLine());

//    if (numbers.Contains(number))
//    {
//        Console.WriteLine("emtered no. " + number);
//        continue;
//    }

//    numbers.Add(number);
//}

//numbers.Sort();

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}


//4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
//    The list of numbers may include duplicates. Display the unique numbers that the user has entered.


//Console.WriteLine("enter numbers");

//List<int> numbers = new List<int>();

//while (true)
//{
//    String number = Console.ReadLine();

//    if (number == "quit")
//        break;

//    numbers.Add(Convert.ToInt32(number));
//}

////// ??
//List<int> result = (List<int>)numbers.Distinct();


//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}


//Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
//    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
//otherwise, display the 3 smallest numbers in the list.


//Console.WriteLine("enter a series of numbers separated by comma");
//String Numberarray = Console.ReadLine();


//String[] number = Numberarray.Split(',');
//if (number.Length < 5)
//{
//    Console.WriteLine("Invalid, try again!");
//}
//else
//{
//    var numbers = new List<int>();
//    foreach (var item in number)
//        numbers.Add(Convert.ToInt32(item));

//    numbers.Sort();

//    for (int i = 0; i < 3; i++)
//    {
//        Console.WriteLine(numbers[i]);
//    }

//}