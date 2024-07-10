string name = Console.ReadLine();
string pass = Console.ReadLine();

string vuvejdane = Console.ReadLine();

while (vuvejdane != pass)
{
    vuvejdane = Console.ReadLine();
}
Console.WriteLine($"Welcome {name}!");