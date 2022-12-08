// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conditional statements");
Console.WriteLine();
Console.WriteLine();

int age = 10;
if (age > 5)
{
    Console.WriteLine("greater than 5");

}
else if(age < 10)
{
    Console.WriteLine("less than 10");
}


int price;
bool isgold = true;
if (isgold)
{
    price = 10;
}
else
{
    price = 5;
}

Console.WriteLine(price);




Console.WriteLine("loops");

for(int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine( "even");
    }
    else
    {
        Console.WriteLine($"odd: {i}");
    }
}



var name = "divyanshi jain";

foreach(var item in name)
{
    Console.WriteLine(item);
}



int i = 0;
while (i <= 10)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

//break and continue in while loop