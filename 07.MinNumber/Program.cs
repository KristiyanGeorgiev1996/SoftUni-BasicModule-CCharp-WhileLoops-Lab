string stop = Console.ReadLine();
int min = int.MaxValue;

while (stop != "Stop")
{
    int sum = int.Parse(stop);
    if (sum < min)
    {
        min = sum;
    }



    stop = Console.ReadLine();
}
Console.WriteLine(min);