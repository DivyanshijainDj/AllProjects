using System.Diagnostics;


var nonParallelTimer = Stopwatch.StartNew();
var empList = new EmployeeList();

var taskTimer = Stopwatch.StartNew();


Asynctax tax = new Asynctax();

foreach (var item in empList.list)
{
    Task t = tax.CalculateTaxAsync(item);
    Task t1 = Task.Factory.StartNew(() => {
        Asynctax.WriteFile(item);
    });


    Task t2 = Task.Factory.StartNew(() => {
        Asynctax.WriteAllFile(item);
    });

    
    Task.WaitAll(t1, t2);
};

Console.WriteLine("Task completed Sucessfully!!");


Console.WriteLine($"total time taken {taskTimer.Elapsed.TotalMilliseconds}");
Console.ReadLine();
