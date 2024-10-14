double money = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double priceLightSabers = double.Parse(Console.ReadLine());
double priceRobes = double.Parse(Console.ReadLine());
double priceBelts = double.Parse(Console.ReadLine());

double extraSabers = Math.Ceiling(students * 0.10);
double lightSabers = (students + extraSabers) * priceLightSabers;
double neededBelts = students - (students / 6);

double robes = students * priceRobes;
double belts = neededBelts * priceBelts;

double total = lightSabers + robes + belts;
Console.WriteLine(total);
if (money >= total)
{
    Console.WriteLine($"The money is enough - it would cost {(total):f2}lv.");
}
else
{
    Console.WriteLine($"Ivan Cho will need {(Math.Abs(total - money)):f2}lv more.");
}
