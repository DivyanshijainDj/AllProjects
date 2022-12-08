// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercise 2");
Console.WriteLine();

//int count = 0;
//for (int number = 0; number <= 100; number++)
//{
//    if (number % 3 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("Total Count is : {0}", count);


//Console.WriteLine("enter a number or enter 'ok' to exit");

//int SumNUmber = 0;
//while (true)
//{
//    string take = Console.ReadLine();

//    if (take == "ok"){
//        break;
//    }

//    SumNUmber += Convert.ToInt32(take);
//}
//Console.WriteLine("Sum " + SumNUmber);



//Console.WriteLine("enter number to find factorial");
//int number = Convert.ToInt32(Console.ReadLine());

//int fact = 1;
//for(int i = number; i >0; i--)
//{
//    fact = fact * i;
//}
//Console.WriteLine(fact);



//Random random = new Random();
//int num= random.Next(1,10);

//int chance = 4;
//int input;
//Console.WriteLine("sceret numer is {0}", num);
//while (chance != 0)
//{
//    input = Convert.ToInt32(Console.ReadLine());
//    if(input == num)
//    {
//        Console.WriteLine("you won");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("loose");
//    }
//    chance--;
//}

Console.WriteLine("enter a series of numbers separated by comma");
String Numberarray = Console.ReadLine();

String[] number = Numberarray.Split(',');

int maxnumber= Convert.ToInt32(number[0]);
for(int i = 0; i < number.Length; i++)
{
    if(Convert.ToInt32(number[i]) > maxnumber)
    {
        maxnumber= Convert.ToInt32(number[i]);
    }
}

Console.WriteLine("max number is: {0}", maxnumber);
