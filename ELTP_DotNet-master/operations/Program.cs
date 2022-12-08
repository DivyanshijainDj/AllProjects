// See https://aka.ms/new-console-template for more information
Console.WriteLine("Assignment no 1");
int firstNumber, secondNumber;
double result;

Console.WriteLine("Enter value of First Number");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value of Second Number");
secondNumber = Convert.ToInt32(Console.ReadLine());

result = firstNumber + secondNumber;
Console.WriteLine("Addition is " + result);

result = firstNumber - secondNumber;

Console.WriteLine($"Substraction is {result}");

result = firstNumber * secondNumber;
Console.WriteLine($"Multiplication is {result}");

result = firstNumber / secondNumber;
Console.WriteLine($"Division is {result}");

result = firstNumber * firstNumber;
Console.WriteLine($"Square of First Number is {result}");

result = secondNumber * secondNumber;
Console.WriteLine($"Square of Second Number is {result}");

result = 0;
int start = 0, end = firstNumber, mid;
while (start <= end)
{
    mid = (start + end) / 2;
    if (mid * mid == firstNumber)
    {
        result = mid;
        break;


    }
    if (mid * mid < firstNumber)
    {
        start = mid + 1;
        result = mid;
    }
    else
    {
        end = mid - 1;
    }
}
double inc = 0.001;
while (result * result <= firstNumber)
{
    result = result + inc;
}
result = result - inc;

Console.WriteLine($"Squareroot of First Number is {(float)result}");

result = 1;
while (result * result <= secondNumber)
    result++;
Console.WriteLine($"Squareroot of Second Number is {result - 1}");

result = 1;
for (int i = 0; i < secondNumber; i++)
{
    result = result * firstNumber;

}
Console.WriteLine($"Power of {firstNumber} on {secondNumber} is {result}");

result = 1;
for (int i = 0; i < firstNumber; i++)
{
    result = result * secondNumber;

}
if (firstNumber < 0)
{
    Console.WriteLine($"Power of {secondNumber} on {firstNumber} is {1 / result}");
}
else
    Console.WriteLine($"Power of {secondNumber} on {firstNumber} is {result}");
