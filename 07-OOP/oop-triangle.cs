var triangle1 = new Triangle(2, 3);
//var calculator = new ShapesMeasurementCalculator();
Console.WriteLine($" base is {triangle1.@base}");
Console.WriteLine($" height is {triangle1.height}");
// Console.WriteLine($" The area for Triangle1 is { new ShapesMeasurementCalculator().CalculateTriangleArea(triangle1)}");
var calculator = new ShapesMeasurementCalculator();
Console.WriteLine($" The CircumFerence for Retangle1 is {calculator.CalculateTriangleArea(triangle1)}");

public class Triangle
{
    public int @base;
    public int height;

// constructor
public Triangle(int @base, int height)
{
    this.@base = @base;
    this.height = height;
}
}

// encaplutation
class ShapesMeasurementCalculator
{
    public double CalculateTriangleArea(Triangle triangle)
    {
        return 0.5 * triangle.@base * triangle.height;
    } 
}
