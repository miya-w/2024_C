### Object Oriented :抽象類別(Abstract) 封裝(Encapsulation)、繼承(Inheritance)與多型(polymorphism)

#### Table of Contents
- [封裝 (Encapsulation)](#封裝-encapsulation)
- [繼承 (Inheritance)](#繼承-inheritance)
- [抽象類別 (Abstract Classes)](#抽象類別-abstract-classes)
    [介面(Interface)](#介面-Interface)
- [多型 (Polymorphism)](#多型-polymorphism)

### 封裝-encapsulation

### Encapsulation and Properties (W3C C#)   
The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. 
To achieve this, you must:
1. declare fields/variables as private
2. provide public **get and set** methods, through properties, to access and update the value of a private field

- Encapsulation 就像一個銀行，保管你不想被碰觸的資料保險箱(設定為private)，**get & set** 就像銀行的出納櫃臺讓你自由的使用被保護的物件。


```cs
class Person
{
    // Private field
    private string name; 

    // Public property to access and modify the private field
    public string Name   
    {
        // Getter method: allows read access to the 'name' field
        get { return name; }   

        // Setter method: allows write access to the 'name' field
        set { name = value; }  
    }
}

class Program
{
    static void Main(string[] args)
    {   
        // Person-> is the class name that you've defined earlier
        // person -> is the variable name
        Person person = new Person();

        // Using the 'set' method to assign a value to the 'name' field
        person.Name = "Mia";

        // Using the 'get' method to retrieve the value of the 'name' field
        Console.WriteLine(person.Name); // Output: Mia
    }
}


```

```cs
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
int sum = myClass.Sum(); 
// Not reaching data!
```
[Back to Top](#table-of-contents)

## 繼承-inheritance
以下取自大話設計模式：

物件的繼承代表了一種 “is-a” 的關係，如果兩個物件 A 和 B，可以描述為『B是A』，則表明了B可以繼承A。Ex:特斯拉是車子、貓是哺乳類動物。
繼承者可以理解為對被繼承者的特殊化，因為他除了具備繼承者的特性外，還具備自己獨有的個性。Ex：特斯拉消耗能源是靠電能相較於傳統汽車使用汽油、貓擁有爬高爬樹等能力將較於傳統哺乳類動物沒有的技能。
繼承定義了類別如何相互關聯共用特性。
子類別不但繼承父類別所有特性，還可以定義新的特性。
如果子類別繼承於父類別：
- Using **:**
1. 子類別擁有父類別非 private 的屬性和功能。
2. 子類別具有自己的屬性和功能 => 子類別可以擴展父類別的所有特性。
3. 子類別還可以用自己的方式實現父類別 => 方法重寫。



```cs
// 繼承(Inheritance)
//產生一個汽車的類別，有一個方向盤、四個輪子。
public class 汽車
{
    protected int 輪子 = 4;
    protected int 方向盤 = 1;
}
//產生一個特斯拉類別繼承汽車
public class 特斯拉 : 汽車
{
    public string 特斯拉輪子()
    {
        return "特斯拉有" + 輪子 + "個輪子";
    }
    public string 特斯拉方向盤()
    {
        return "特斯拉有" + 方向盤 + "個方向盤";
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        特斯拉 Tesla = new 特斯拉();
        Console.WriteLine(Tesla.特斯拉輪子());
        Console.WriteLine(Tesla.特斯拉方向盤());
    }
}
```
[Back to Top](#table-of-contents)


### 抽象類別-abstract-classes
1. 抽象類別不能實體化。
2. 抽象方法是用來給子類別重寫的方法，如果不重寫的話，抽象方法就沒有存在的意義。
3. 如果類別中包含抽象方法，那麼整個類別就必須定義為抽象類別，不論是否還包含其他一般方法。
4. abstract - override
- example
```cs
abstract class Shape
{
    public abstract double Area(); // Abstract method
}

class Rectangle : Shape
{
    public override double Area()
    {
        // Provide implementation for the Area method
        return Width * Height;
    }
    
    // Other members and fields specific to Rectangle class
    public double Width { get; set; }
    public double Height { get; set; }
}


``` 

```cs

// 首先車子這個類別指定義了車子啟動方式、消耗能源；這是不管哪種車子都會具備的功能，因此我們把定義成一個抽象類別，來讓特斯拉以及汽車繼承後實作，今天如果是機車那我們也可以繼承車子這個抽象類別實作自己的啟動、以及消耗能源方式。


public abstract class Car
{
    public abstract string 消耗能源();
    public abstract string 啟動();
}

// 產生一個特斯拉類別繼承車子
public class ElectricCar : Car
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

// 產生一個汽車類別繼承車子
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

public class Program
{
    private static void Main(string[] args)
    {
        Car Toyota = new PetrolCar();
        Console.WriteLine(Toyota.啟動());
        Console.WriteLine("Toyota : " + Toyota.消耗能源());
        
        ElectricCar Tesla = new ElectricCar();
        Console.WriteLine(Tesla.啟動());
        Console.WriteLine("Tesla: " + Tesla.消耗能源());
    }
}
// 汽車啟動
// Toyota : 消耗汽油
// 特斯拉啟動
// Tesla: 消耗電能

``` 
[Back to Top](#table-of-contents)


### #介面-Interface
1. 介面是把隱式公共方法和屬性組合起來，以封裝特定功能的一個集合。
2. 一旦類別實現了介面，類別就可以支援介面所指定的所有屬性和成員。
3. 宣告介面在語法上與抽象類別完全相同，但不允許提供介面中任何成員的執行方法。

今天我們想替車子加一個開車門的方法，但機車並不需要，這時候介面就可以派上用場了。
接下來讓汽車跟特斯拉實作車門這個介面，程式就變成

```cs
using System;

// Declare an interface for car doors
// Note: Typically interfaces start with 'I', so normally this would be declared as IDoor
public interface ICarDoor
{
    string OpenMethod();
}

// Define an abstract class Car with methods to start and consume energy
public abstract class Car
{
    public abstract string ConsumeEnergy();
    public abstract string Start();
}

// Create a Tesla class that inherits from Car and implements ICarDoor
public class Tesla : Car, ICarDoor
{
    public override string Start()
    {
        return "Tesla starts";
    }
    public override string ConsumeEnergy()
    {
        return "Consumes electric energy";
    }
    public string OpenMethod()
    {
        return "Opens sideways";
    }
}

// Create a PetrolCar class that inherits from Car and implements ICarDoor
public class PetrolCar : Car, ICarDoor
{
    public override string Start()
    {
        return "Petrol car starts";
    }
    public override string ConsumeEnergy()
    {
        return "Consumes gasoline";
    }
    public string OpenMethod()
    {
        return "Opens forward";
    }
}

// Create a Motorcycle class that inherits from Car
public class Motorcycle : Car
{
    public override string Start()
    {
        return "Motorcycle starts";
    }
    public override string ConsumeEnergy()
    {
        return "Consumes gasoline";
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        PetrolCar car = new PetrolCar();
        Console.WriteLine(car.Start());
        Console.WriteLine("Petrol car: " + car.ConsumeEnergy());
        Console.WriteLine("Petrol car door opening method: " + car.OpenMethod());

        Tesla tesla = new Tesla();
        Console.WriteLine(tesla.Start());
        Console.WriteLine("Tesla: " + tesla.ConsumeEnergy());
        Console.WriteLine("Tesla door opening method: " + tesla.OpenMethod());

        Motorcycle motorcycle = new Motorcycle();
        Console.WriteLine(motorcycle.Start());
        Console.WriteLine("Motorcycle: " + motorcycle.ConsumeEnergy());
    }
}


```
[Back to Top](#table-of-contents)




## 多型-polymorphism

大話設計模式：多型表示不同的物件可以執行相同的動作，但要透過他們自己的實現程式碼來執行。
注意事項：

一、子類別以父類別的身分出現。
二、子類別在工作時以自己的方式來實現。
三、子類別以父類別的身分出現時，子類別特有的屬性和方法不能使用。
使用方法： **virtual** and **override**
為了使子類別的實體完全接替來自父類別的類別成員，父雷別必須將該成員宣告為虛擬(virtual)。
子類別可以透過 override 將父類別的實現替換為他自己的實現，這就是方法重寫 Override。

```cs
public class 汽車
{
	public virtual string 啟動方式()
    {
        return "汽油";
    }
	
	public virtual string 時速()
    {
        return "100";
    }
}
//產生一個特斯拉類別繼承汽車並且重寫啟動方式跟時速方法。
public class 特斯拉 : 汽車
{
	
	public override string 啟動方式()
    {
        return "電能";
    }
	
	public override string 時速()
    {
        return "300";
    }
}
public class Program
{
    private static void Main(string[] args)
    {
        汽車 car = new 汽車();
        Console.WriteLine("汽車啟動方式: " + car.啟動方式());
        Console.WriteLine("汽車時速: " + car.時速());
        
        特斯拉 Tesla = new 特斯拉();
        Console.WriteLine("特斯拉啟動方式: " + Tesla.啟動方式());
        Console.WriteLine("特斯拉時速: " + Tesla.時速());
    }
}

// 汽車啟動方式: 汽油
// 汽車時速: 100
// 特斯拉啟動方式: 電能
// 特斯拉時速: 300


```
[Back to Top](#table-of-contents)
---
- [Object Oriented物件導向-4:抽象類別(Abstract)與介面(Interface)](https://sunnyday0932.github.io/2020/object-oriented%E7%89%A9%E4%BB%B6%E5%B0%8E%E5%90%91-4_%E6%8A%BD%E8%B1%A1%E9%A1%9E%E5%88%A5abstract%E8%88%87%E4%BB%8B%E9%9D%A2interface/)
- [Object Oriented物件導向-3:封裝(Encapsulation)、繼承(Inheritance)與多型(polymorphism)](https://sunnyday0932.github.io/2020/object-oriented%E7%89%A9%E4%BB%B6%E5%B0%8E%E5%90%91-3_%E5%B0%81%E8%A3%9Dencapsulation%E7%B9%BC%E6%89%BFinheritance%E8%88%87%E5%A4%9A%E5%9E%8Bpolymorphism/)