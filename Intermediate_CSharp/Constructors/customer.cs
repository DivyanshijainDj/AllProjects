// See https://aka.ms/new-console-template for more information
public class customer
{
    public int ID;
    public string name;
    public List<order> Orders;

    public customer()
    {

    }

    public customer(int id)
    {
        this.ID = id;
        Console.WriteLine("1 parameter");
        Console.WriteLine(id);
    }

    public customer(int id, string name)
    {
        this.ID=id;
        this.name = name;
        Console.WriteLine("two parameter");
        Console.WriteLine(id);
        Console.WriteLine(name);
    }
}
