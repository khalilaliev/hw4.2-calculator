Console.Write("Enter first number: ");
double firstMultiplier = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
double secondMultiplier = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter an operator (+, -, *, /): ");
string? operation = Console.ReadLine();

double result = 0;
bool success = true;

switch (operation)
{
    case "+":
        result = firstMultiplier + secondMultiplier;
        break;
    case "-":
        result = firstMultiplier - secondMultiplier;
        break;
    case "*":
        result = firstMultiplier * secondMultiplier;
        break;
    case "/":
        if (secondMultiplier == 0)
        {
            Console.WriteLine("Cant devide by 0");
        }
        result = firstMultiplier / secondMultiplier;
        break;
    default:
        Console.WriteLine("Unknown operator");
        success = false;
        break;
}

if (success)
{

    Console.WriteLine($"Your result is {result}");
}

