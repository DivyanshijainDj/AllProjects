using System.Threading;



object ex = new object();
example eg = new example();


Thread t3 = new Thread(eg.bgthread);
t3.IsBackground = true;
t3.Start();
//ParameterizedThreadStart p = new ParameterizedThreadStart(eg.print);


//Thread t3 = new Thread(() => eg.print(5));



Console.WriteLine("Main thread");



