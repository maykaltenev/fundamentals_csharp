int startingYield = int.Parse(Console.ReadLine());
int totalSpiceExtracted = 0;

int days = 0;
while (startingYield > 100)
{
    days++;
    totalSpiceExtracted += startingYield;
    startingYield -= 10;
    totalSpiceExtracted -= 26;
}
if (totalSpiceExtracted > 0)
{
    totalSpiceExtracted -= 26;
}
Console.WriteLine(days);
Console.WriteLine(totalSpiceExtracted);
