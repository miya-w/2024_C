// Encapusolation Practice
// The new method CalculateCircumFerence(int width, int height)
// allows the calculation of circumference without creating a Rectangle object. 

```cs
public class Rectangle
{
    public int width;
    public int height;
    // Constructor
    public Rectangle(int width, int height) 
    { 
        this.width = width; 
        this.height = height;
    }
    // Method to calculate area
    public int CalculateArea()
    {
        return width * height;
    }
}

class ShapesMeasurementCalculator
{
    // Method to calculate circumference taking a Rectangle object
    public int CalculateCircumFerence(Rectangle rectangle)
    {
        return 2 * rectangle.width + 2 * rectangle.height;
    }

    // Overloaded method to calculate circumference using two integers for width and height
    public int CalculateCircumFerence(int width, int height)
    {
        return 2 * width + 2 * height;
    }
}

class Program
{
    static void Main()
    {
        var rectangle1 = new Rectangle(2, 3);
        Console.WriteLine($"Width is {rectangle1.width}");
        Console.WriteLine($"Height is {rectangle1.height}");
        Console.WriteLine($"The area for Rectangle1 is {rectangle1.CalculateArea()}");

        // Using an instance of ShapesMeasurementCalculator to calculate circumference
        Console.WriteLine($"The Circumference for Rectangle1 is {new ShapesMeasurementCalculator().CalculateCircumFerence(rectangle1)}");

        // *****Using the overloaded method directly with width and height*****
        Console.WriteLine($"The Circumference directly calculated is {new ShapesMeasurementCalculator().CalculateCircumFerence(2, 3)}");

        var rectangle2 = new Rectangle(5, 10);
        Console.WriteLine($"Width is {rectangle2.width}");
        Console.WriteLine($"Height is {rectangle2.height}");

        Console.ReadKey();
    }
}


// Encapusation practice 2
// compare the different member, in this case we set quotient and reminder in the Divid class, 
// so ->  new Calculate_Quotient(divide_1);
// when to Display results
//       Console.WriteLine("Quotient: " + divide_1.Quotient);

using System;

class Divid
{
    private int dividend;
    private int divisor;
    private int quotient;
    private int remainder;

    // Constructor
    public Divid(int dividend, int divisor)
    {
        this.dividend = dividend;
        this.divisor = divisor;
    }

    // Properties
    public int Dividend
    {
        get { return dividend; }
        set { dividend = value; }
    }

    public int Divisor
    {
        get { return divisor; }
        set { divisor = value; }
    }

    public int Quotient
    {
        get { return quotient; }
        set { quotient = value; }
    }

    public int Remainder
    {
        get { return remainder; }
        set { remainder = value; }
    }
}

// Encapsulation for calculating quotient
class Calculate_Quotient
{
    public Calculate_Quotient(Divid divide)
    {
        divide.Quotient = divide.Dividend / divide.Divisor;
    }
}

// Encapsulation for calculating remainder
class Calculate_Remainder
{
    public Calculate_Remainder(Divid divide)
    {
        divide.Remainder = divide.Dividend % divide.Divisor;
    }
}

class Program
{
    static void Main()
    {
        var divide_1 = new Divid(10, 3);

        //Calculate quotient and remainder
        new Calculate_Quotient(divide_1);
        new Calculate_Remainder(divide_1);

        //Display results
        Console.WriteLine("Quotient: " + divide_1.Quotient);
        Console.WriteLine("Remainder: " + divide_1.Remainder);
     
    }
}