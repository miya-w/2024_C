// 4 pillars in OOP :Encapsulation,  Inheritance, Polymorphism ,Abstract


// --- Access Modifiers ---
// public, private, protected, internal, ex: public string color;
// Note: By default, all members of a class are private if you don't specify an access modifier:


// --- Encapsulation and Properties ---

//The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. 
//To achieve this, you must:

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
//by adding the "virtual" keyword to the method inside the **base class**, 
//and by using the "override" keyword for each **derived class methods

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

