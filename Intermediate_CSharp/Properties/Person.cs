 // See https://aka.ms/new-console-template for more information
public class Person
{
    public string Name { get; set; }
    public int id { get; set; }
    public int number { get; set; }
    public DateTime Age
    {
        get
        {
            DateTime years = DateTime.Now;
            return years;
        } 
    }
}
