int number = int.Parse(Console.ReadLine());

int years = number * 100;
long days = (long)Math.Floor(years * 365.2422);
long hours = days * 24;
long minutes = hours * 60;

Console.WriteLine(
    $"{number} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes"
);
