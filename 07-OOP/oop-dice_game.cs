// Dice Game - OOP version

using System;

class DiceGame
{
    private int randomNumber;
    private int guessTime;
    private bool endOfGame;

    public DiceGame()
    {
        // !!!  Random random = new Random(); -> creating the new class
        // Randon is a common used **type** in C#
        Random random = new Random();
        randomNumber = random.Next(1, 7);
        guessTime = 0;
        endOfGame = false;
    }

    public void StartGame()
    {
        Console.WriteLine("Random number: " + randomNumber);  // For debugging, remove in production
        do
        {
            Console.WriteLine("Type the guessing number from 1 to 6:");
            string stringUserGuess = Console.ReadLine();
            Console.WriteLine($"Your guessing is {stringUserGuess}");

            if (!int.TryParse(stringUserGuess, out int intUserGuess))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            guessTime++;
            if (guessTime >= 3)
            {
                Console.WriteLine("You lost.");
                break;
            }

            if (intUserGuess == randomNumber)
            {
                Console.WriteLine("You got the right answer!");
                break;
            }
            else
            {
                Console.WriteLine($"You got the wrong answer, your guessing time is: {guessTime}, please try again!");
            }
        } while (!endOfGame);
    }
}

class Program
{
    static void Main()
    {
        DiceGame game = new DiceGame();
        game.StartGame();
    }
}



// --- Dice game - procedeur --- 
generate the random number 
  Random random = new Random();
    int randomNumber = random.Next(1, 7); // Generates a random number between 1 and 6
    Console.WriteLine("Random number: " + randomNumber);
//bool end game
bool end_of_game = false; 
int guess_time = 0; 

 // create a gusiing loop 
do{
// user_numer
Console.WriteLine("type the guessing number from 1 to 6");
string string_user_guess =  Console.ReadLine();
Console.WriteLine($"Your guessing is {string_user_guess }");
int  int_user_guess = int.Parse(string_user_guess);
guess_time +=1;
 if (guess_time > 3){
    Console.WriteLine("you lost");
    end_of_game = true;
 }

if (int_user_guess == randomNumber)
{
    Console.WriteLine("You got the right answer");
    end_of_game = true;
} else{
    Console.WriteLine($"you got the wrong answer, your guessing time is: {guess_time}, please try again!");
}

}while
(
 end_of_game == false
); 
    
