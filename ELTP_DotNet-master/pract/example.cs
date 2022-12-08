
//example ex = new example();
//ex.print();
//Console.WriteLine("==================");
//ex.printnew();

public class example
{


    public void threadone()
    {
        //int k = Convert.ToInt32(j);
        //for (int i = 0; i < k; i++)
        //{
        //    Console.WriteLine($"one: {i}");
        //}
        Thread.Sleep(4000);

        Console.WriteLine("Thread1");

    }

    public void threadtwo()
    {
        Thread.Sleep(4000);
        Console.WriteLine("Thread2");
    }

    public void bgthread()
    {
        Thread.Sleep(2000);

        Console.WriteLine("bg thread");

    }
}