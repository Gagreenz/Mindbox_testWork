using AwesomeShapeLibrary.Interfaces;
using AwesomeShapeLibrary.Shapes;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangle triangle = new Triangle(2.72f, 3.93f, 4.77f);
        Console.WriteLine(triangle.CalculateArea());

        if (triangle.IsRightTriangle())
        {
            Console.WriteLine("Triangle is right");
        }

        Circle circle = new Circle(3f);
        Console.WriteLine(circle.CalculateArea());


        Console.WriteLine("Result for universal circle:" + UniversalCalculate(circle));
        Console.WriteLine("Result for universal triangle:" + UniversalCalculate(triangle));
    }

    private static double UniversalCalculate(IShape shape)
    {
         return shape.CalculateArea();
    }
}

