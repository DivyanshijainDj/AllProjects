

person p = new person();
Thread t1 = new Thread(p.print);
Thread t2 = new Thread(p.print);
Thread t3 = new Thread(p.print);
t1.Start();
t2.Start();
t3.Start();

public class person
{

    public string? name { get; set; }

    public int MyProperty { get; set; }


    public void print()
    {
        lock (this)
        {
            Console.WriteLine("hello!");
            Thread.Sleep(5000);
            Console.WriteLine("I woke up!!");
        }
    }
}


