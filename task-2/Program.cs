using System;

class Circle
{
    public const double PI = 3.14;

    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
      
        double radius = 5;

        Console.WriteLine("Area: " + Circle.CalculateArea(radius));
        Console.WriteLine("Perimeter: " + Circle.CalculatePerimeter(radius));
    }
}