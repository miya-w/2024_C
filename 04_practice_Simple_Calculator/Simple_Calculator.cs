// Simple calculator
Console.WriteLine("Hello, welcome to simple calculator");
Console.WriteLine( "Type the first Number");
string number_input_1 = Console.ReadLine();
int Number_1 = int.Parse(number_input_1);

Console.WriteLine( "Type the second Number");
string number_input_2 = Console.ReadLine();
int Number_2 = int.Parse(number_input_2);


Console.WriteLine("[A] Add ");
Console.WriteLine("[S] Substract!");
Console.WriteLine("[M] Multiply");
Console.WriteLine("[D] Devide");

var Calculator_Choice = Console.ReadLine();


// void Calculation(string Calculation)
// {
//     Console.WriteLine("selected optiion : " + Calculation);
// }

if (Calculator_Choice == "a" || Calculator_Choice == "A")
{
    int Answer1 = Number_1 + Number_2;
    Console.Write("Add the two number is " + Answer1);

}
else if (Calculator_Choice == "s" || Calculator_Choice == "S")
{
     int Answer2 = Number_1 - Number_2;
    Console.Write("Substract the two number is " + Answer2);
}
else if(Calculator_Choice == "m" || Calculator_Choice == "M")
{
  int Answer3 = Number_1 * Number_2;
    Console.Write("Mutiple the two number is " + Answer3);  
}
else if(Calculator_Choice == "d" || Calculator_Choice == "D")
{
  int Answer4 = Number_1 / Number_2;
    Console.Write("Mutiple the two number is " + Answer4);  
}
else
{
    Console.WriteLine("Invalid Number");
}
Console.WriteLine("Press anyKey to close");
Console.ReadKey();


// Refractor 

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number:");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var choice = Console.ReadLine();

if(EqualsCaseInsensitive(choice, "A"))
{
    var sum = number1 + number2;
    PrintFinalEquation(number1, number2, sum, "+");
}
else if (EqualsCaseInsensitive(choice, "S"))
{
    var difference = number1 - number2;
    PrintFinalEquation(number1, number2, difference, "-");
}
else if (EqualsCaseInsensitive(choice, "M"))
{
    var multiplied = number1 * number2;
    PrintFinalEquation(number1, number2, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

void PrintFinalEquation(
    int number1, int number2, int result, string @operator)
{
    Console.WriteLine(
        number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}