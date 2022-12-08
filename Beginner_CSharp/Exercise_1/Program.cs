// See https://aka.ms/new-console-template for more information

Console.WriteLine("Exercise-1");
Console.WriteLine();


//int EnteredNumber = Convert.ToInt32(Console.ReadLine());
//if(EnteredNumber>1 && EnteredNumber < 10)
//{
//    Console.WriteLine("Valid");
//}
//else
//{
//    Console.WriteLine("Invalid");
//}


//Console.WriteLine("enter first number: ");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("enter second number: ");
//int number2= Convert.ToInt32(Console.ReadLine());

//if (number1 > number2)
//{
//    Console.WriteLine("number 1 is greater {0}", number1);
//}
//if (number1 < number2)
//{
//    Console.WriteLine("number 2 is greater {0}", number2);
//}



//Console.WriteLine("enter Height: ");
//int Height = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("enter Width: ");
//int Width = Convert.ToInt32(Console.ReadLine());

//if (Width > Height)
//{
//    Console.WriteLine("Image is Landscape");
//}
//if (Width < Height)
//{
//    Console.WriteLine("image is potrait");
//}
//if (Width == Height)
//{
//    Console.WriteLine("image is square");
//}



//4 - Your job is to write a program for a speed camera. For simplicity, 
//    ignore the details such as camera, sensors, etc and focus purely on the logic. 
//    Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
//    If the user enters a value less than the speed limit, program should display Ok on the console. 
//    If the value is above the speed limit, the program should calculate the number of demerit points. 
//    For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
//    If the number of demerit points is above 12, the program should display License Suspended.


Console.WriteLine("enter speed limit");
int SpeedLimit= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter speed of car");
int CarSpeed= Convert.ToInt32(Console.ReadLine());

if (CarSpeed < SpeedLimit)
{
    Console.WriteLine("OK");
}



int DemeritPoints;

 DemeritPoints = (CarSpeed-SpeedLimit )/ 5;

if (DemeritPoints > 12)
    Console.WriteLine("License Suspended");
else
    Console.WriteLine("Demerit Points are: " + DemeritPoints);
