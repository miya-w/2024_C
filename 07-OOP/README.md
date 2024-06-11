# OOP Syntax
# C# Programming Guide

## Table of Contents

1. [Create the Class and Object](#create-the-class-and-object)
2. [Constructors](#constructors)
   - [Class Members](#class-members)
   - [Method Overloading](#method-overloading)
   - [Optional Parameters](#Optional-Parameters)
   - [Validate the Constructor Parameter](#validate-the-constructor-parameter)
   - [Readonly and Const](#readonly-and-const)
3. [Name Of](#name-of)
4. [Property](#property)
5. [Readonly and Const](#readonly-and-const)
6. [Static Class and Static Method](#static-class-and-static-method)


# create-the-class-and-object 
### Class is like "blueprint" for creating objects.


```cs
class Car 
{
  string color = "red";// field
  string brand = "Toyota";// field
  int maxSpeed = 200;
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
  // Create an Object, An object is created from a class.
  //To create an object of Car, use the keyword new:
  // Note that we use the dot syntax (.) to access variables/fields inside a class (myObj.color)
  static void Main()
  {
    Car myObj = new Car();
    Car myObj2 = new Car();
    Console.WriteLine("my car's color is "+myObj.color);
    Console.WriteLine("my car's brand is "+myObj.brand);
    Console.WriteLine("my second car's color is "+myObj2.color);
  }
}
//Output 
// my car's color is red
// my car's brand is Toyota
// my second car's color is red
```
```cs
// second way to create a class
// You can also leave the fields blank, and modify them when creating the object:
class Car 
  {
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }

```
[Back to Top](#table-of-contents)

# class-members
### Class Members
Fields and methods inside classes are often referred to as "Class Members":

```cs
  class Car
  {
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
      Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
      Car myObj = new Car();
       myObj.color = "red";
       myObj.maxSpeed = 200;
    Console.WriteLine(myObj.maxSpeed);
    Console.WriteLine(myObj.color);
      myObj.fullThrottle();  // Call the method
    }
  }
  // Output : The car is going as fast as it can!

```
[Back to Top](#table-of-contents)

# Constructors
// A constructor is a special method that is used to initialize objects.
//  can be used to set initial values for fields
// Note that the constructor name must match the class name, and it cannot have a return type (like void or int).

```cs
class Car
{
  public string model;  // Create a field

  // Create a class constructor for the Car class
  public Car()
  {
    model = "Mustang"; // Set the initial value for model
  }

  static void Main(string[] args)
  {
    Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
    Console.WriteLine(Ford.model);  // Print the value of model
  }
}

// Outputs-> "Mustang"
```

### Constructor Parameters
```cs
// Constructor Parameters
class Car
{
  public string model;
  public string color;
  public int year;

  // Create a class constructor with multiple parameters
  public Car(string modelName, string modelColor, int modelYear)
  {
    model = modelName;
    color = modelColor;
    year = modelYear;
  }

  static void Main(string[] args)
  {
    Car Ford = new Car("Mustang", "Red", 1969);
    Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
  }
}

// Outputs Red 1969 Mustang
```
[Back to Top](#table-of-contents)

# method-overloading-and-optional-parameters
***method overloading***

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
```
[Back to Top](#table-of-contents)

# #Optional-Parameters
*** Optional parameter ***
The Rectangle constructor now has default values of 1 for both width and height, so it can be instantiated without providing any parameters.

```cs
public class Rectangle
{
    // Fields
    public int width;
    public int height;

    // ****Constructor with optional parameters (default to 1)****
    public Rectangle(int width = 1, int height = 1)
    {
        this.width = width;
        this.height = height;
    }

    // Method to calculate the area
    public int CalculateArea()
    {
        return this.width * this.height;
    }
}

class ShapesMeasurementCalculator
{
    // Method to calculate circumference using a Rectangle object
    public int CalculateCircumFerence(Rectangle rectangle)
    {
        return 2 * rectangle.width + 2 * rectangle.height;
    }

    // Overloaded method with ****optional parameters**** for width and height (default to 1)
    public int CalculateCircumFerence(int width = 1, int height = 1)
    {
        return 2 * width + 2 * height;
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the Rectangle constructor with defaults
        var defaultRectangle = new Rectangle();
        Console.WriteLine($"Default Rectangle - Width: {defaultRectangle.width}, Height: {defaultRectangle.height}");
        Console.WriteLine($"Area of Default Rectangle: {defaultRectangle.CalculateArea()}");
        // Output - Default Rectangle - Width: 1, Height: 1
        // Area of Default Rectangle: 1

        // Using the Rectangle constructor with one parameter to specify width only
        var customWidthRectangle = new Rectangle(4);
        Console.WriteLine($"Custom Width Rectangle - Width: {customWidthRectangle.width}, Height: {customWidthRectangle.height}");
        Console.WriteLine($"Area of Custom Width Rectangle: {customWidthRectangle.CalculateArea()}");
        // Output - Custom Width Rectangle - Width: 4, Height: 1
        // Area of Custom Width Rectangle: 4


        // Using both parameters in the constructor
        var rectangle1 = new Rectangle(2, 3);
        Console.WriteLine($"Rectangle1 - Width: {rectangle1.width}, Height: {rectangle1.height}");
        Console.WriteLine($"Area of Rectangle1: {rectangle1.CalculateArea()}");

        // Using an instance of ShapesMeasurementCalculator to calculate circumference
        Console.WriteLine($"Circumference of Rectangle1: {new ShapesMeasurementCalculator().CalculateCircumFerence(rectangle1)}");

        // Calling the overloaded method directly with optional parameters
        Console.WriteLine($"Circumference directly calculated with default values: {new ShapesMeasurementCalculator().CalculateCircumFerence()}");
        Console.WriteLine($"Circumference with specified width (4) and default height (1): {new ShapesMeasurementCalculator().CalculateCircumFerence(4)}");
        Console.WriteLine($"Circumference with specified width (5) and height (10): {new ShapesMeasurementCalculator().CalculateCircumFerence(5, 10)}");
        // Circumference of Rectangle1: 10
        // Circumference directly calculated with default values: 4
        // Circumference with specified width (4) and default height (1): 10
        // Circumference with specified width (5) and height (10): 30
        Console.ReadKey();
    }
}

```

# validate-the-constructor-parameter
add the validate the constructor parameter (the width and height can't small the 1)
1. Parameter Validation in Constructor:
2.  Exception Handling:
The main method includes try-catch blocks to handle these exceptions when an invalid rectangle is created.

```cs
public class Rectangle
{
    // Fields
    public int width;
    public int height;

    // Constructor with parameter validation
    public Rectangle(int width = 1, int height = 1)
    {
        // Validate that width and height are greater than or equal to 1
        if (width < 1)
        {
            throw new ArgumentException("Width cannot be less than 1", nameof(width));
        }

        if (height < 1)
        {
            throw new ArgumentException("Height cannot be less than 1", nameof(height));
        }

        this.width = width;
        this.height = height;
    }

    // Method to calculate the area
    public int CalculateArea()
    {
        return this.width * this.height;
    }
}

class ShapesMeasurementCalculator
{
    // Method to calculate circumference using a Rectangle object
    public int CalculateCircumFerence(Rectangle rectangle)
    {
        return 2 * rectangle.width + 2 * rectangle.height;
    }

    // Overloaded method with optional parameters for width and height (default to 1)
    public int CalculateCircumFerence(int width = 1, int height = 1)
    {
        return 2 * width + 2 * height;
    }
}

class Program
{
    static void Main()
    {
        // Valid example usage of Rectangle
        try
        {
            var validRectangle = new Rectangle(2, 3);
            Console.WriteLine($"Valid Rectangle - Width: {validRectangle.width}, Height: {validRectangle.height}");
            Console.WriteLine($"Area of Valid Rectangle: {validRectangle.CalculateArea()}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        // Example with invalid width
        try
        {
            var invalidWidthRectangle = new Rectangle(0, 3);  // This will throw an ArgumentException
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        // Example with invalid height
        try
        {
            var invalidHeightRectangle = new Rectangle(2, 0);  // This will throw an ArgumentException
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }

        // Using the ShapesMeasurementCalculator
        var calculator = new ShapesMeasurementCalculator();
        Console.WriteLine($"Circumference with default width and height: {calculator.CalculateCircumFerence()}");

        Console.ReadKey();
    }
}

// Valid Rectangle - Width: 2, Height: 3
// Area of Valid Rectangle: 6
// Error: Width cannot be less than 1 (Parameter 'width')
// Error: Height cannot be less than 1 (Parameter 'height')
// Circumference with default width and height: 4

```
[Back to Top](#table-of-contents)

# name-of
```cs
// *******  nameof( ) method ********

public class SampleClass
{
    public int Property { get; set; }

    public void PrintPropertyName()
    {
        // Using nameof to get the name of the Property
        Console.WriteLine(nameof(Property));
    }
}

// Usage
var sample = new SampleClass();
sample.PrintPropertyName();  // Outputs: "Property"

```
[Back to Top](#table-of-contents)

# readonly-and-const

*** readonly and const: ****
1. readonly: Fields declared with the readonly keyword can only be assigned once at the time of object initialization(in a constructor) or at the point of declaration if set inline. readonly fields are not inherently static, meaning they can hold different values for different instances of a class.
2. const: immutable and must be defined with a value at the point of declaration.

```cs
public class Rectangle
{
    // Fields
    // The width and height fields are marked readonly to prevent modifications after object construction.
    public readonly int width;
    public readonly int height;

    // A constant field to represent a default dimension
    public const int MinDimension = 1;

    // Constructor using `this` to refer to the current instance fields
    public Rectangle(int width = MinDimension, int height = MinDimension)
    {
        // Ensure the width and height are not less than the minimum dimension
        this.width = Math.Max(width, MinDimension);
        this.height = Math.Max(height, MinDimension);
    }

    // Method to calculate area using the instance fields via `this`
    public int CalculateArea()
    {
        return this.width * this.height;
    }
}

class ShapesMeasurementCalculator
{
    // Method to calculate circumference using a Rectangle object
    public int CalculateCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.width + 2 * rectangle.height;
    }

    // Overloaded method to calculate circumference using integers
    public int CalculateCircumference(int width, int height)
    {
        return 2 * width + 2 * height;
    }
}

class Program
{
    static void Main()
    {
        // Creating Rectangle objects using different dimensions
        var rectangle1 = new Rectangle(0, 3);
        var rectangle2 = new Rectangle(5, 10);

        // Using Rectangle's method to calculate area
        Console.WriteLine($"Rectangle1 - Width: {rectangle1.width}, Height: {rectangle1.height}, Area: {rectangle1.CalculateArea()}");
        Console.WriteLine($"Rectangle2 - Width: {rectangle2.width}, Height: {rectangle2.height}, Area: {rectangle2.CalculateArea()}");

        // Using an instance of ShapesMeasurementCalculator to calculate circumference
        var calculator = new ShapesMeasurementCalculator();
        Console.WriteLine($"Circumference of Rectangle1: {calculator.CalculateCircumference(rectangle1)}");
        Console.WriteLine($"Circumference of Rectangle2: {calculator.CalculateCircumference(rectangle2)}");

        // Demonstrating the use of the constant MinDimension
        Console.WriteLine($"Minimum Dimension allowed for any rectangle: {Rectangle.MinDimension}");

        Console.ReadKey();
    }
}
// Rectangle1 - Width: 1, Height: 3, Area: 3
// Rectangle2 - Width: 5, Height: 10, Area: 50
// Circumference of Rectangle1: 8
// Circumference of Rectangle2: 30
// Minimum Dimension allowed for any rectangle: 1
```


# property
******* add the property *******
// Properties Width and Height have been added to encapsulate the fields _width and _height.
// Properties provide getter (get) and setter (set) methods, which allow additional logic, such as validation.
```cs
using System;

public class Rectangle
{
    // Properties to replace public fields
    private int _width;
    private int _height;

    public int Width
    {
        get => _width;  // Getter returns the value of the private field
        set => _width = value >= 1 ? value : throw new ArgumentException("Width must be greater than or equal to 1.");
    }

    public int Height
    {
        get => _height;  // Getter returns the value of the private field
        set => _height = value >= 1 ? value : throw new ArgumentException("Height must be greater than or equal to 1.");
    }

    // Constructor
    public Rectangle(int width, int height)
    {
        Width = width;  // Uses property setters to ensure valid values
        Height = height;
    }

    // Method to calculate area
    public int CalculateArea()
    {
        return Width * Height;
    }
}

class ShapesMeasurementCalculator
{
    // Method to calculate circumference taking a Rectangle object
    public int CalculateCircumference(Rectangle rectangle)
    {
        return 2 * rectangle.Width + 2 * rectangle.Height;
    }

    // Overloaded method to calculate circumference using two integers for width and height
    public int CalculateCircumference(int width, int height)
    {
        return 2 * width + 2 * height;
    }
}

class Program
{
    static void Main()
    {
        var rectangle1 = new Rectangle(2, 3);
        Console.WriteLine($"Width is {rectangle1.Width}");
        Console.WriteLine($"Height is {rectangle1.Height}");
        Console.WriteLine($"The area for Rectangle1 is {rectangle1.CalculateArea()}");

        // Using an instance of ShapesMeasurementCalculator to calculate circumference
        Console.WriteLine($"The Circumference for Rectangle1 is {new ShapesMeasurementCalculator().CalculateCircumference(rectangle1)}");

        // Using the overloaded method directly with width and height
        Console.WriteLine($"The Circumference directly calculated is {new ShapesMeasurementCalculator().CalculateCircumference(2, 3)}");

        var rectangle2 = new Rectangle(5, 10);
        Console.WriteLine($"Width is {rectangle2.Width}");
        Console.WriteLine($"Height is {rectangle2.Height}");

        Console.ReadKey();
    }
}
```
// ********  static class and static method  ******



