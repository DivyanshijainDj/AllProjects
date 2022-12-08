// See https://aka.ms/new-console-template for more information
public class Customer
{
    public int ID;
    public string Name;
    public List<Order> Orders = new List<Order>();

    public Customer(int id)
    {
        this.ID = id;
    }

    public Customer(int id, string name)
        :this(id)
    {
        this.Name = name;
    }


    public void Promote()
    {

    }
}
