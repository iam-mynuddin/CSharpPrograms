using System;
namespace OopsConcept.Abstraction
{
    
abstract class Shape
{
    public abstract double CalculateArea();
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

class Abstraction
{
    //static void Main()
    //{
    //    Shape rectangle = new Rectangle(5, 4);
    //    Shape circle = new Circle(3);

    //    Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
    //    Console.WriteLine("Area of circle: " + circle.CalculateArea());
    //}
}

}