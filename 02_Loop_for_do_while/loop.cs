// Loop in C#
// while , do...while
// for, foreach

// x = x + 1 ->  x += 1;

// while 
int x = 0;
while (x < 10)
{
    //x += 1;
    //x++;
    ++x;
    Console.WriteLine("the number is " + x);
}

Console.WriteLine("The  while loop is finish");

// --example ---
//-- while
// while(condition)
// {
//    somecode
// }

Console.WriteLine("Enter a word");
var userInput = Console.ReadLine();

while (userInput.Length < 10)
{
    userInput+= 'a';
    Console.WriteLine(userInput);
}



// -- do while --
// do{
    // code
// }
// while (condition);

string input_word;

do 
{
    Console.WriteLine("Enter a word longer tham 10 letters");
    input_word = Console.ReadLine();
}
while (input_word.Length < 10);

Console.WriteLine("The Loop is finished");

//###################
//For loop
//###################
for (int i = 0; i < 5; ++i)
{
    Console.WriteLine("Loop run " + i);
}
for (int i = 10; i >= 5; --i)
{
    Console.WriteLine("Loop run " + i);
}
Console.WriteLine("The loop is finished");



//###################
//Break and continue
//###################
// -- break(stop), continue(like skip)--

int input_number;

do 
{   
    Console.WriteLine("enter a number more than 5");
    var userInput= Console.ReadLine();
    if (userInput == "stop")
    {
        break;
    }
    input_number = int.Parse(userInput);

} while (input_number <= 5);
Console.WriteLine("the do while finish");
Console.ReadKey();

//###################
//Nested loops
//###################
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(
            $"i is {i}, j is {j}");
    }
}

Console.WriteLine("The nested loop is finish");
Console.ReadKey();