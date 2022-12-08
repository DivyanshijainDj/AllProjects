// See https://aka.ms/new-console-template for more information

public class PresentationObject
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void Copy()
    {
        Console.WriteLine("copied .");
    }

    public void Duplicate()
    {
        Console.WriteLine("duplicated.");
    }
}