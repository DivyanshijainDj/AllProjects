// See https://aka.ms/new-console-template for more information
Console.WriteLine("Methods");
Console.WriteLine(); 

person p = new person();
p.PrintName("divyanshi", "jain");

weird w = new weird();
int a = 1;
w.DoWeird(ref a);

point points = new point(10,20);


points.Move(new point(40, 50));

Console.WriteLine($"point {points.X} ,{ points.Y}") ;


