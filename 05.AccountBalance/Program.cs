string input = Console.ReadLine();
double total = 0;

while (input != "NoMoreMoney")
{
    double sum = double.Parse(input);
    if (sum < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    total += sum;
    Console.WriteLine($"Increase: {sum:F2}");
    input = Console.ReadLine();
}
Console.WriteLine($"Total: {total:f2}");
