# C#

## Setting Up the Development Environment

### 1. Down load .NET
- [Download .NET for mac](https://dotnet.microsoft.com/en-us/download) 
 
 ### 2. terminal
 ```bash
 # test dotnet installed
    dotnet --version
# Create new project
    dotnet new --list
    dotnet new console

    dotnet build
    
    # run the app 
    dotnet run
    # output: Hello World!
 ```
---
# Table of contents
#### Basic Syntax 
1. **Introduction to C#**
   - Overview of C#
   - Setting Up the Development Environment

2. **Basic Syntax**
   - Basic Structure of a C# Program
   - Main Method 
   - Namespaces 
   - Comments -> //

3. **Data Types and Variables**
   - Primitive Data Types
   - Variables
   - Constants
   - Type Casting

4. **Operators**
   - Arithmetic Operators
   - Comparison Operators
   - Logical Operators
   - Assignment Operators
   - Bitwise Operators

5. **Control Flow**
   - Conditional Statements
     - if
     - if-else
     - switch
   - Loops
     - for Loop
     - while Loop
     - do-while Loop
     - foreach Loop
   - Jump Statements
     - break
     - continue
     - return

6. **Methods**
   - Defining Methods
   - Method Parameters
   - Return Values
   - Method Overloading

7. **Classes and Objects**
   - Defining Classes
   - Creating Objects
   - Fields and Properties
   - Methods in Classes
   - Constructors
   - Destructors
8. **Collections**
   - Arrays
   - Lists
   - Dictionaries
   - Other Collection Types

 **Other**
   - ToString and int.Parse 
   - Out keyword
### OOP
- [OOP]() :Encapsulation,Inheritance, Abstraction, Polymorphism:
   **Object-Oriented Programming (OOP)**
   - Encapsulation
     - Access Modifiers
     - Properties
        - Interfaces
   - [Encapusolation Practice]()
   - Inheritance
     - Base and Derived Classes
     - Method Overriding
   - Polymorphism
     - Virtual and Override Keywords
     - Abstract Classes
  

## Start C#

```cs
using System;                           // 引用 System 函式庫

public class Hello                      // 宣告類別 Hello
{
   public static void Main()            // 類別 Hello 的主程式
   {
      Console.WriteLine("Hello !");     // 印出 Hello !
   }
}
```
 ---
 ### Resources
 - [Youtube - Setup C# in Mac](https://www.youtube.com/watch?v=SQim2adwVJI)
 - [Udemy C# - Repository](https://github.com/KrystynaSlusarczykLearning/UltimateCSharpMasterclass/tree/main)
 - [C#與ASP.Net入門-我要成為工程師](https://ithelp.ithome.com.tw/users/20120055/ironman/2275)
 - [W3C-C# ](https://www.w3schools.com/cs/index.php)
 - [Microsoft - Common C# code conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
 - [Learn .net - Modern Web Application Development With Asp.Net](https://medium.com/@evincedevelop/modern-web-application-development-with-asp-net-1e7fc7b07cce)
 - [OOP-Object Oriented物件導向-4:抽象類別(Abstract)與介面(Interface)](https://sunnyday0932.github.io/2020/object-oriented%E7%89%A9%E4%BB%B6%E5%B0%8E%E5%90%91-4_%E6%8A%BD%E8%B1%A1%E9%A1%9E%E5%88%A5abstract%E8%88%87%E4%BB%8B%E9%9D%A2interface/)
- [OOP- (Encapsulation- [程式設計] 10分鐘搞懂物件導向 Object-oriented programming]((https://medium.com/@p81122g/%E6%B7%BA%E8%AB%87%E7%89%A9%E4%BB%B6%E5%B0%8E%E5%90%91%E7%A8%8B%E5%BC%8F%E8%A8%AD%E8%A8%88-object-oriented-programming-81355c85484b))
- [免費電子書：C# 程式設計 by陳鍾誠](http://cs0.wikidot.com/)
