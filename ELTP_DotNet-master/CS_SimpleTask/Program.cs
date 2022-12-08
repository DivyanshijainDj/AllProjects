// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Task !!");

Task task1 = Task.Factory.StartNew(() => {
   
    //Task.Delay(5000);
    Print1();
});

Task task2 = Task.Factory.StartNew(() => {
    
    //Task.Delay(1000);
    Print2();
});
Task task3 = Task.Factory.StartNew(() => {
    Print3();
});

Task.WaitAll(task1);


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Main");
}

Console.ReadLine();

static void Print1()
{
    Console.WriteLine("Print 1");
}


static void Print2()
{
    Console.WriteLine("Print 2");
}

static void Print3()
{
    Console.WriteLine("Print 3");
}


