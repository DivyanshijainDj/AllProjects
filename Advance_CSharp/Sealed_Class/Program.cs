// See https://aka.ms/new-console-template for more information
Console.WriteLine("sealed class");


shape c = new circle();
c.draw();
public  class shape
{
    public virtual void draw()
    {
        Console.WriteLine("draw a shape..");
    }
}

public class circle : shape
{
    public sealed override void draw()
    {
        Console.WriteLine("draw a circle..");
    }
}