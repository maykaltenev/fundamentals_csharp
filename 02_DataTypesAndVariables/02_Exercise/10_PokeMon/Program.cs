int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int factor = int.Parse(Console.ReadLine());

int originalPowerValue = power;
int counter = 0;

while (power >= distance)
{
    power -= distance;
    counter++;

    if ((power == originalPowerValue * 0.50) && factor != 0)
    {
        power /= factor;
    }
}
Console.WriteLine(power);
Console.WriteLine(counter);
