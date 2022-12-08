Console.WriteLine("Enter a Number to convert to words");
Int64 number = Convert.ToInt64(Console.ReadLine());
var s = Output(number);
Console.WriteLine(s);
static String Output(Int64 number)
{
    String[]? units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
    String[]? tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    if (number < 20)
    {
        return units[number];
    }
    if (number < 100)
    {
        return tens[number / 10] + ((number % 10 > 0) ? " " + Output(number % 10) : "");
    }
    if (number < 1000)
    {
        return units[number / 100] + " Hundred"
                + ((number % 100 > 0) ? " And " + Output(number % 100) : "");
    }
    if (number < 100000)
    {
        return Output(number / 1000) + " Thousand "
                + ((number % 1000 > 0) ? " " + Output(number % 1000) : "");
    }
    if (number < 10000000)
    {
        return Output(number / 100000) + " Lakh "
                + ((number % 100000 > 0) ? " " + Output(number % 100000) : "");
    }
    if (number < 1000000000)
    {
        return Output(number / 10000000) + " Crore "
                + ((number % 10000000 > 0) ? " " + Output(number % 10000000) : "");
    }
    else
    {
        return Output(number / 1000000000) + " Arab "
                + ((number % 1000000000 > 0) ? " " + Output(number % 1000000000) : "");
    }
}