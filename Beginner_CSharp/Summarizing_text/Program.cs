// See https://aka.ms/new-console-template for more information
Console.WriteLine("Summarizing texts");
Console.WriteLine();


var statement = "What is C# used for? C# (pronounced) is a modern, object-oriented, and type-safe programming language. C# enables developers to build many types of secure and robust applications that run in . NET. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
const int maxlength = 20;

if(statement.Length< maxlength)
{
    Console.WriteLine(statement);
}
else
{
    var words = statement.Split(' ');
    var summarywords = new List<string>();
    var total = 0;

    foreach(var word in words)
    {
        summarywords.Add(word);
        total += word.Length + 1;

        if (total > maxlength)
        {
            break;
        }
    }


    var summary = String.Join(" ", summarywords) + "...";
    Console.WriteLine(summary);

}

