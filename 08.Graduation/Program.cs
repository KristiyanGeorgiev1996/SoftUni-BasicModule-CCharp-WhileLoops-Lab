string name = Console.ReadLine();
int klas = 1;
int baddocenki = 0;
double ocenkiobshto = 0;

while (klas <= 12)
{
    double ocenka = double.Parse(Console.ReadLine());
    if (ocenka <4.00)
    {
        baddocenki++;
        if(baddocenki < 2)
        {
            continue;
        }
        else
        {
            Console.WriteLine($"{name} has been excluded at {klas} grade");
            break;
        }
    }
    klas++;
    ocenkiobshto += ocenka; 
}
if (klas >= 12)
{
    double total = ocenkiobshto / 12;
    Console.WriteLine($"{name} graduated. Average grade: {total:f2}");
}
