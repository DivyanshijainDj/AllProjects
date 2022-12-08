// See https://aka.ms/new-console-template for more information
Console.WriteLine("StackOverflow Post");

Post post = new Post();

post.Title = "Divyanshi Post";
post.Description = "welcome to my post, you will find interesting content here!!";
post.Created = DateTime.Now;

string? continueExecution = "y";
do
{
    Console.WriteLine("enter you choice: ");
    Console.WriteLine("1. Vote Up");
    Console.WriteLine("2. VOte Down");
    Console.WriteLine("3. Total Vote");

    int input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        post.VoteUp();
        post.print();

    }
    if (input == 2)
    {
        post.VoteDown();
        post.print();
    }
    if (input == 3)
    {
        post.TotalCount();
        post.print();
    }

    Console.WriteLine("Continue? press y");
    continueExecution = Console.ReadLine();
} while (continueExecution == "y" || continueExecution == "Y");
Console.ReadLine();