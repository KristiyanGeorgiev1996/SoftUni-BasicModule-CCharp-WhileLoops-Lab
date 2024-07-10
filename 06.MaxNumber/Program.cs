
string chislo = Console.ReadLine();
int maxNumber = int.MinValue;

while (chislo != "Stop")
{
    int sum = int.Parse(chislo);
    if (maxNumber < sum)
    {
        maxNumber = sum;
    }


    chislo = Console.ReadLine();
}

Console.WriteLine(maxNumber);