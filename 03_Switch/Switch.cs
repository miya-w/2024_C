int day = 4;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)

Console.WriteLine("Type your Points");
var points = Console.ReadLine();
int int_points = int.Parse(points);
Console.WriteLine("Your grade is : "+ ConvertPointsToGrades(int_points));

char ConvertPointsToGrades(int int_points)
{

    switch (int_points) 
    {
    case 10:
    case 9:
        return 'A';

    case 8:
    case 7:
        return 'B';
    
    case 6:
    case 5:
        return 'C';
    case 4:
    case 3:
    case 2:
    case 1:
    case 0:
        return 'F';

    default:
        return '?';

    }

}

