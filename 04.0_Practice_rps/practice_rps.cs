
// Rock Paper Scissors game
//what you learned : random choose, conditional (if, else if, else) 

Console.WriteLine("Type R, P, C to chhose your choice");
string your_choice = Console.ReadLine();

string[] choices = { "R", "P", "C",};
string computer_choice = choices[new Random().Next(0,choices.Length)].ToLower();

Console.WriteLine("computer choose : "+ computer_choice );
Console.WriteLine("Your choices is : "+ your_choice);


if ((computer_choice == "R" && your_choice == "S") ||
            (computer_choice == "S" && your_choice == "P") ||
            (computer_choice == "P" && your_choice == "R"))
        {
            Console.WriteLine("Computer wins");
        }
        else if ((your_choice == "R" && computer_choice == "S") ||
                 (your_choice == "S" && computer_choice == "P") ||
                 (your_choice == "P" && computer_choice == "R"))
        {
            Console.WriteLine("You win");
        }
        else if (your_choice == computer_choice)
        {
            Console.WriteLine("It's a tie");
        }