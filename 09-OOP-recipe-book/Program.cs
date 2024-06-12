// See https://aka.ms/new-console-template for more information


// Cookie cookbook
//1. shows all the ingredients
//2.user select the id
    //- string convert to number
    //- put this int id into a new array
//3. store the selected id to new create json file
//4. 

class Program
{
    static void Main()
    {
        string[] ingredients = { "wheat flour", "Coconut Flour", "butter", "Chocolate", "sugar", "Cardamom", "Cocoa powder" };
        var selected_ingredients = new List<int>(); // Corrected List<int>
        bool end_of_choose = false;
        

        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
        for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + ingredients[i]);
            }

        do
        {
            

            // User selects the ID
            Console.WriteLine("Please type the ingredients Id or type 'done' to finish: ");
            var user_choice = Console.ReadLine();

            if (user_choice.ToLower() == "done")
            {
                end_of_choose = true;
            }
            else
            {
                int ingredientId = int.Parse(user_choice);
                if (ingredientId > 0 && ingredientId <= ingredients.Length)
                {
                    selected_ingredients.Add(ingredientId); // Add the selected ingredient ID to the list
                     Console.WriteLine("You selected ingredient ID: " + ingredientId);
                   
                
                }
                else
                {
                    // Failed to parse the input to an integer or out of range
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                
            }
        } while (!end_of_choose);
        // Display selected ingredients
        Console.WriteLine("Selected ingredient IDs:");
        foreach (var id in selected_ingredients)
        {
            Console.WriteLine(id + ". " + ingredients[id - 1]);
        }

        // --- Convert the selected_ingredients list to a string in the format [1, 2, 3, 4] ---
        string selectedIngredientsString = "[" + string.Join(", ", selected_ingredients) + "]";
        // Create a text file and write the selected ingredients to it
        string filePath = "SelectedIngredients.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Selected Ingredients:" + selectedIngredientsString );
            
        }
         Console.WriteLine("Selected ingredients have been saved to " + filePath);
    }
      
}


    


      
        