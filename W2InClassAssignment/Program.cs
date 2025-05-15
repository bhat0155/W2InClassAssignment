// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, Ekam!");

class MyClass
{
    static void Main()
    {
        Console.WriteLine("Hello Ekam!");
        var p1 = new Point(10, 20);
        
        Console.WriteLine(p1.X);
    }
    
}

class Point
{
    public double X;
    public double Y;

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}