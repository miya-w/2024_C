// non void method - bool

Console.WriteLine("type anything");
var userInput = Console.ReadLine();

bool checkisLong = IsLong(userInput);
Console.WriteLine(checkisLong);

bool method 1
bool IsLong( string input_word)
{
  if(userInput.Length > 10)
  {
    return true;
  }
  return false;
 
}

// bool method 2

bool IsLong( string input_word)
{
  return input_word.Length > 10;
}


// return int
int Add(int a, int b){
  return a + b;
}

var sum = Add(11, 4);
Console.WriteLine("the sum is "+sum);
Console.WriteLine(" Press anyKey to close");
Console.ReadKey();

// void method -> not promise return anything
// void PrintSelectedOption(string PrintSelectedOption)
// {
//   Console.WriteLine("selection " + PrintSelectedOption);
// }