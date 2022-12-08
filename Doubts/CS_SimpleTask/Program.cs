// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Task !!");

Task task = Task.Factory.StartNew(() => {
    Print1();
});

Task task1 = Task.Factory.StartNew(() => {
    Print2();
});
Task task2 = Task.Factory.StartNew(() => {
    Print3();
});



Task.WaitAll(task2,task);
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


