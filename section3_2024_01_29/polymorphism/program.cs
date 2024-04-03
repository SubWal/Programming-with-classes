using System;

// Superclass
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

// Subclass 1
class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

// Subclass 2
class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    }

    public override double CalculateArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = { new Circle(5), new Rectangle(4, 6) };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
        }
    }
}
