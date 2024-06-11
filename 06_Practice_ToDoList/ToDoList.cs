using System.Runtime.CompilerServices;

// // Simple calculator

List<string> TodoList = new List<string>();
bool endOfToDo = false;
do
{
    Console.WriteLine("Hello, welcome to todo list in C#");
    Console.WriteLine("[A] Add a new todo");
    Console.WriteLine("[S] See all todos ");
    Console.WriteLine("[D] Delete todos ");
    Console.WriteLine("[E] End todos ");
    var user_Choice = Console.ReadLine();
    if (user_Choice == "a" || user_Choice == "A")
    {

        Console.Write("You choose adding todos, what do you what to add? ");
        String NewToDo = Console.ReadLine();
        TodoList.Add(NewToDo);
        Console.WriteLine("The new todo list are");
        foreach (var todo in TodoList)
        {
            Console.WriteLine(todo);
        };

    }
    else if (user_Choice == "s" || user_Choice == "S")
    {
        Console.WriteLine("You are going to see all todos : ");
        if (TodoList.Count == 0)
        {
            Console.WriteLine("The Todo list is empty");
        }
        else
        {
            int index = 1;
            foreach (var todo in TodoList)
            {
                Console.WriteLine(index + "." + todo);
                index++;
            };

        };

    }
    else if (user_Choice == "e" || user_Choice == "E")
    {
        Console.WriteLine("You are going to leave");
        endOfToDo = true;
    }
    else if (user_Choice == "d" || user_Choice == "D")
    {
        Console.WriteLine("type the index number you want to delete ");
        int todo_delete = int.Parse(Console.ReadLine());
        if (todo_delete > TodoList.Count)
        {
            Console.WriteLine("Invalid index number, ttype again!");
        }
        else
        {
            TodoList.RemoveAt(todo_delete - 1);
        };
    }
    else
    {
        Console.WriteLine("Invalid option, please choose again.");
    }
}
while (!endOfToDo);