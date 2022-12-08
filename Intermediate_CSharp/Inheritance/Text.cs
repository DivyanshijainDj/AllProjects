// See https://aka.ms/new-console-template for more information

public class Text : PresentationObject
{
    public int FontSize { get; set; }
    public string FontName { get; set; }

    public void AddHyperlink(string url)
    {
        Console.WriteLine("Url added " + url);
    }

}
