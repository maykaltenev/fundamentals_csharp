string day = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int price = 0;

if (age < 0 || age > 112)
{
    Console.WriteLine("Error!");
    return;
}

if (day == "Weekday")
{
    if (age >= 0 && age <= 18)
    {
        price = 12;
    }
    else if (age > 18 && age <= 64)
    {
        price = 18;
    }
    else if (age > 64 && age <= 112)
    {
        price = 12;
    }
}
else if (day == "Weekend")
{
    Console.WriteLine("Weekend");
    if (age >= 0 && age <= 18)
    {
        price = 15;
    }
    else if (age > 18 && age <= 64)
    {
        price = 20;
    }
    else if (age > 64 && age <= 112)
    {
        Console.WriteLine("age");
        price = 15;
    }
}
else if (day == "Holiday")
{
    if (age >= 0 && age <= 18)
    {
        price = 5;
    }
    else if (age > 18 && age <= 64)
    {
        price = 12;
    }
    else if (age > 64 && age <= 112)
    {
        price = 10;
    }
}

Console.WriteLine($"{price}$");
