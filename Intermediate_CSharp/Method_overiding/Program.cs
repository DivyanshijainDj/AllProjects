// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 

var shapes = new List<Shape>();
shapes.Add(new Shape { Width = 100, Height = 200, });
shapes.Add(new Shape { Width = 10, Height = 50 });


   void DrawShape(List<Shape> shapes)
{
    foreach (var shape in shapes)
    {
        shape.Draw();
    }
}

DrawShape(shapes);
public class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual void Draw()
    {

    }
}

 public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine( "circle draw");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("draw rectangle");
    }
}




 




