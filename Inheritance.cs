using System;
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}
class Rectangle : Shape
{
    private double length;
    private double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public override double CalculateArea()
    {
        return length * width;
    }
}
class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle(5, 4);
        Circle circle = new Circle(3);
        Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
        Console.WriteLine("Area of circle: " + circle.CalculateArea());
    }
}
