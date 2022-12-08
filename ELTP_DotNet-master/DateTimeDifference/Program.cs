using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a program that counts the number of days between two different dates both inpyt by the user
            Console.WriteLine("Please enter first date in format of: MM/DD/YYYY");
            DateTime dateString = Convert.ToDateTime(Console.ReadLine());

            //DateTime dateString = DateTime.Parse(Console.Readline());
            //or

            //DateTime date1 = DateTime.Parse(dateString);
            Console.WriteLine("Enter second date");
            DateTime dateString2 = Convert.ToDateTime(Console.ReadLine());

            //DateTime date2 = DateTime.Parse(dateString2);
            TimeSpan difference = dateString - dateString2;     
            //or


            //TimeSpan difference = date1.Subtract(date2);
            Console.WriteLine("The two dates are " + Math.Abs(difference.Days) + " days apart.");
            Console.ReadLine();
           



        }
    }
}