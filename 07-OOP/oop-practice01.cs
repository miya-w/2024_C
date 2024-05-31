// use--class, constructor, property--
class People{
    string firstName;
    string lastName; 
    string job;
    int age;
    int income;
    int sideHustle;

    // Constructor
    public People(string FirstName, string LastName, string Job, int Age, int Income, int SideHustle)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
        this.age = Age;
        this.job = Job;
        this.income = Income;
        this.sideHustle = SideHustle;
    }

     // Properties
    public string FirstName { get { return firstName; } private set { firstName = value; } }
    public string LastName { get { return lastName; } private set { lastName = value; } }
    public string Job { get { return job; } private set { job = value; } }
    public int Income { get { return income; } private set { income = value; } }
    public int Age { get { return age; } private set { age = value; } }

    // method return a double
     public double PayingTax()
    {
        double totalIncome = Income + sideHustle;
        double tax = totalIncome * 0.20;
        return tax;
     }
    // method (void -> not return anything)
    public void introduction()
    {
        Console.WriteLine($"Hi! I am {FirstName}, I am {Age} years old, my job is {job},I make {Income} per year, and paing tax: {PayingTax()}");
    }

}


// class
  class person{
        static void Main() {
            People Sara = new People("Sara", "Smith","baby sitting", 31, 60000, 2000);
            Sara.introduction();
            People Mike = new People("Mike", "Anderson","tradie", 26, 75000, 1500);
            Mike.introduction();
        }

    }

// ex. tectangle OOP 

var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 100);

Console.WriteLine(
    "Count of Rectangle objects is " + Rectangle.CountOfInstances);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());


class Rectangle
{
    //const fields are implicitly static
    public const int NumberOfSides = 4;

    //a static property, belonging to the class as a whole
    public static int CountOfInstances { get; private set; }

    // //a static field
    // private static DateTime _firstUsed;

    // //a static constructor
    // static Rectangle()
    // {
    //     _firstUsed = DateTime.Now;
    // }

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
        ++CountOfInstances;
    }

    //readonly property - can only be set in the constructor
    public int Width { get;}

    //achieving a similar behavior as properties give with using methods
    private int _height;
    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }

    //expression-bodied methods
    //could not be made static as they use the state of an instance (width and height)
    // example : 
    // **expression-bodied methods**: public int CalculateCircumference() => 2 * Width + 2 * _height;
    // **normal way** : public int CalculateCircumference(){ return 2 * Width + 2 * _height;}


    public int CalculateCircumference() => 2 * Width + 2 * _height;

    public int CalculateArea() => Width * _height;

    //a get-only, expression-bodied property
    public string Description => $"A rectangle with width {Width} " +
        $"and height {_height}";

    //a static method, not using any state of an instance
    public static string DescribeGenerally() =>
        $"A plane figure with four straight sides and four right angles.";

    //can be made static
    public string NotUsingAnyState() => "abc";
}

