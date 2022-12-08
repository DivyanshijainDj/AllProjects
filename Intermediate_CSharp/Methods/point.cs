// See https://aka.ms/new-console-template for more information


public class point
{
    int X;
    int Y;

    public point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(point newLocation)
    {
        this.X = newLocation.X;
        this.Y = newLocation.Y;
    }
}





