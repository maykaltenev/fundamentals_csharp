int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int hoursToMinutes = hours * 60;
int sumTimed = hoursToMinutes + minutes + 30;

int hoursAfter30 = sumTimed / 60;
int minutesAfter30 = sumTimed % 60;

if (hoursAfter30 >= 24)
{
    hoursAfter30 -= 24;
}
if (minutesAfter30 < 10)
{
    Console.WriteLine($"{hoursAfter30}:0{minutesAfter30}");
}
else
{
    Console.WriteLine($"{hoursAfter30}:{minutesAfter30}");
}
