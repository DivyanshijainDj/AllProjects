// See https://aka.ms/new-console-template for more information
public class Post 
{ 
    public String Title { get; set; }
    public String Description { get; set; }
    public DateTime Created { get; set; }

    int UpCount = 0;
    int DownCount = 0;
    public void VoteUp()
    {
        UpCount++;
    }

    public void VoteDown()
    {
        DownCount++;
    }

    public int TotalCount()
    {
        return UpCount - DownCount;
    }

    public void print()
    {
        Console.WriteLine(Title);
        Console.WriteLine(Description);
        Console.WriteLine(UpCount);
        Console.WriteLine(DownCount);

    }
}
