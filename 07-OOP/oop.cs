
// // Create the class
// // A Class is like "blueprint" for creating objects.
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


// Class Members
// Fields and methods inside classes are often referred to as "Class Members":

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


// --Constructors--
// A constructor is a special method that is used to initialize objects.
//  can be used to set initial values for fields
// Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
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

// --- Access Modifiers ---
// public, private, protected, internal, ex: public string color;
// Note: By default, all members of a class are private if you don't specify an access modifier:

// 4 pillars in OOP :Encapsulation,  Inheritance, Polymorphism ,Abstract
// --- Properties and Encapsulation ---

//The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

// declare fields/variables as private
// provide public "get and set" methods, through properties, to access and update the value of a private field

class Person
{
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
}
// 在client端會直接接觸到myClass中的data1 & data2，而data1 & data2也因此要將存取修飾詞(Access Modifier)設為public(無限制存取)，
//而在加入封裝 (Encapsulation)概念後，data1 & data2的存取修飾詞(Access Modifier)就可以改為預設的private(不指定即為private)，可提高程式的安全性，也提升了擴展性，
// 因為若需求改變只需要修改method sum()而不需要修改client端的程式。


// Example 1. in MyClass (No capsulation)
class MyClass
{
    public int data1;
    public int data2;
}

// client side code
int computeSum(MyClass myClass)
{
    int sum = 0;
    sum = myClass.data1 + myClass.data2;    // Reaching data!
    return sum;
}

// Example 2. MyClass (Encapsulation)
class MyClass
{
    int data1;
    int data2;

    public int Sum()
    {
        return data1 + data2;
    } 
}
// client side code
int sum = myClass.Sum();      // Not reaching data!

// -- C# Inheritance -- 
//Derived Class (child) - the class that inherits from another class
//Base Class (parent) - the class being inherited from

class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}

class Program
{
  static void Main(string[] args)
  {
    // Create a myCar object
    Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}

//-- C# Polymorphism --
// by adding the "virtual" keyword to the method inside the base class, 
//and by using the "override" keyword for each derived class methods

class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  // Create a Animal object
    Animal myPig = new Pig();  // Create a Pig object
    Animal myDog = new Dog();  // Create a Dog object

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}

// The animal makes a sound
// The pig says: wee wee
// The dog says: bow wow

// --- Abstract ---
//  abstract classes or interfaces 

//產生一個車子的類別，定義了啟動以及消耗能源。。
// Abstract class
        public abstract class Car
        {
            public abstract string 消耗能源();
            public abstract string 啟動();
        }

        //產生一個特斯拉類別繼承車子
        // // Derived class (inherit from Car)
        public class Tesla : Car
        {
            public override string 啟動()
            {
                return "特斯拉啟動";
            }
            public override string 消耗能源()
            {
                return "消耗電能";
            }
        }
        //產生一個汽車類別繼承車子
        public class PetrolCar : Car
        {
            public override string 啟動()
            {
                return "汽車啟動";
            }
            public override string 消耗能源()
            {
                return "消耗汽油";
            }
        }
        //機車類別繼承車子
        public class motocycle : Car
        {
            public override string 啟動()
            {
                return "機車啟動";
            }
            public override string 消耗能源()
            {
                return "消耗汽油";
            }
        }
		
	private static void Main(string[] args)
        {
            PetrolCarCar car = new Car();
            Console.WriteLine(car.啟動());
            Console.WriteLine("汽車:" + Car.消耗能源());
            特斯拉 Tesla = new Tesla();
            Console.WriteLine(Tesla.啟動());
            Console.WriteLine("特斯拉:" + Tesla.消耗能源());
            機車 bike = new motocycle();
            Console.WriteLine(bike.啟動());
            Console.WriteLine("機車:" + bike.消耗能源());
        }