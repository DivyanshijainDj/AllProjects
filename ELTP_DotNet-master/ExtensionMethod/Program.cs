using System.Te;
Console.WriteLine("Assignment Extension methods");

string str = "the James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny. The character—also known by the code number 007 (pronounced \"double-O-seven\")—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale(a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
int wordCount = 1, statementCount = 0;

for (int i = 0; i < str.Length; i++)
{
    if (str[i] == ' ')
    {
        wordCount++;
    }
    if (Char.IsDigit(str[i]))
    {
        Console.WriteLine($"index: {i} value {str[i]}");
        if (str[i + 1] == '.')
        {
            statementCount--;
        }
    }
    if (str[i] == '.')
    {
        statementCount++;
    }
}
var splittedText = str.Split();
for (int i = 0; i < splittedText.Length; i++)
{
    if (splittedText[i].Contains(".com") || splittedText[i].Contains(".edu") || splittedText[i].Contains(".in") || splittedText[i].Contains(".org") || splittedText[i].Contains(".co"))
    {
        statementCount--;
    }
}

Console.WriteLine($"Total Numbers of words are {wordCount}");
Console.WriteLine($"Total Numbers of Sentence are {statementCount}");


string specialChar = "\"@|!#$%&/()=?»«@£§€{}.-;~`'<>_,";
foreach (char item in specialChar)
{
    if (str.Contains(item))
    {
        Console.WriteLine($"{item}");
    }

}
var str2 = str.Split();
//for (int i = 0; i < str2.Length; i++)
//{
//    Console.WriteLine($"{str2[i]}");
//}
var temp = String.Empty;
foreach (var tempword in str2)
{
    temp += char.ToUpper(tempword[0]) + tempword.Substring(1) + ' ';
}
Console.WriteLine($"{temp}");