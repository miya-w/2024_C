// The basic of stuucture

// **Main**: The **Main** method is the entry point of the program where execution starts
// **Static**: The static keyword means that the method belongs to the class itself 
//             rather than to any specific instance of the class.

// **Void**: The **void** keyword means that the method does not return any value. 

 This is important because the Main method is called by the runtime without creating an instance of the class.

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
// Differences Between static void Main() and static int Main()
// Use static void Main() when you do not need to return an exit code to the operating system.
// Use static int Main() when you want to return an exit code to indicate the program's status (e.g., success or error).

// --- Without Return Value: ---
static void Main(string[] args)
{
    Console.WriteLine("Number of arguments: " + args.Length);
    foreach (string arg in args)
    {
        Console.WriteLine(arg);
    }
}


// --- With Return Value:---
static int Main(string[] args)
{
    Console.WriteLine("Number of arguments: " + args.Length);
    foreach (string arg in args)
    {
        Console.WriteLine(arg);
    }
    return 0; // Return 0 to indicate successful execution
}


