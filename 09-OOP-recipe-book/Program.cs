// See https://aka.ms/new-console-template for more information


// Cookie cookbook
//1. shows all the ingredients
//2.user select the id
    //- string convert to number
    //- put this int id into a new array
//3. store the selected id to new create json file
//4. 





// -> can't get the console.writeline(you choose the ID)
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

        // Convert the selected_ingredients list to a string in the format [1, 2, 3, 4]
        string selectedIngredientsString = "[" + string.Join(", ", selected_ingredients) + "]";
        // Create a text file and write the selected ingredients to it
        string filePath = "SelectedIngredients.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Selected Ingredients:");
            
        }
    }
      
}


      

// add the the ingredient ID into the list 
    
        // // array 
        // string[] ingredient = {"wheat flour","Coconut Flour","butter","Choclate", "sugar", "Cardamon", "Cocoa powdwer"};
        // List<int> selected_ingredients = new List<int>();
        // Console.WriteLine("Create a new cookie recipe! Available ingredients are:  ");

        // for (int i = 0; i < ingredient.Length; i++)
        // {
        //     Console.WriteLine((i + 1) + ". " + ingredient[i]);
        // }

        // // User selects the id
        // Console.WriteLine("Please type the ingredient Id: ");
        // var user_choice = Console.ReadLine();

        // int ingredientId;
        // if (int.TryParse(user_choice, out ingredientId))
        // {
        //     // Ensure the ID is within the valid range
        //     if (ingredientId >= 1 && ingredientId <= ingredient.Length)
        //     {
        //         // Add the selected ingredient ID to the list
        //         selected_ingredients.Add(ingredientId);
        //         Console.WriteLine("You selected ingredient ID: " + ingredientId);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid input. Please enter a number between 1 and " + ingredient.Length + ".");
        //     }
        // }
        // else
        // {
        //     // Failed to parse the input to an integer
        //     Console.WriteLine("Invalid input. Please enter a valid number.");
        // }

        // // Optionally convert the list to an array if needed
        // int[] selected_ingredients_array = selected_ingredients.ToArray();

        // // Output the selected ingredients
        // Console.WriteLine("Selected ingredients IDs are: ");
        // foreach (int id in selected_ingredients_array)
        // {
        //     Console.WriteLine(id + ". " + ingredient[id - 1]);
        // }


//3. add the function id -> to store array else -> leave the loop



// namespace CookieRecipe
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] ingredients = { "Wheat Flour", "Coconut Flour", "Butter", "Chocolate", "Sugar", "Cardamom", "Cocoa Powder" };
//             List<int> selectedIngredients = new List<int>();

//             Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");

//             for (int i = 0; i < ingredients.Length; i++)
//             {
//                 Console.WriteLine((i + 1) + ". " + ingredients[i]);
//             }

//             while (true)
//             {
//                 Console.WriteLine("Please type the ingredient ID or type 'else' to select the remaining ingredients:");
//                 var userChoice = Console.ReadLine();

//                 if (userChoice.ToLower() == "else")
//                 {
//                     // Add all remaining ingredients
//                     for (int i = 1; i <= ingredients.Length; i++)
//                     {
//                         if (!selectedIngredients.Contains(i))
//                         {
//                             selectedIngredients.Add(i);
//                         }
//                     }
//                     break;
//                 }

//                 int ingredientId;
//                 if (int.TryParse(userChoice, out ingredientId))
//                 {
//                     // Ensure the ID is within the valid range
//                     if (ingredientId >= 1 && ingredientId <= ingredients.Length)
//                     {
//                         if (!selectedIngredients.Contains(ingredientId))
//                         {
//                             // Add the selected ingredient ID to the list
//                             selectedIngredients.Add(ingredientId);
//                             Console.WriteLine("You selected ingredient ID: " + ingredientId);
//                         }
//                         else
//                         {
//                             Console.WriteLine("Ingredient ID " + ingredientId + " is already selected.");
//                         }
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid input. Please enter a number between 1 and " + ingredients.Length + ".");
//                     }
//                 }
//                 else
//                 {
//                     // Failed to parse the input to an integer
//                     Console.WriteLine("Invalid input. Please enter a valid number.");
//                 }
//             }

//             // Output the selected ingredients
//             Console.WriteLine("Selected ingredient IDs are: ");
//             foreach (int id in selectedIngredients)
//             {
//                 Console.WriteLine(id + ". " + selectedIngredients[id - 1]);
//             }
//         }
//     }
// }




      
        