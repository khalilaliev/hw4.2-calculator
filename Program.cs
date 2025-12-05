Console.Write("Enter first number: ");
int firstMultiplier = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondMultiplier = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter an operator (+, -, *, /): ");
string? operation = Console.ReadLine();

int result = 0;
bool success = true;

if (operation == "+")
{
    result = firstMultiplier + secondMultiplier;
}
else if (operation == "-")
{
    result = firstMultiplier - secondMultiplier;
}
else if (operation == "*")
{
    result = firstMultiplier * secondMultiplier;
}
else if (operation == "/")
{
    if (secondMultiplier == 0)
    {
        Console.WriteLine("You can't divide by 0.");
        success = false;
    }
    else
    {
        result = firstMultiplier / secondMultiplier;
    }
}
else
{
    Console.WriteLine("Unknown operator.");
    success = false;
}

if (success)
{
    Console.WriteLine($"Your result is {result}");
}
