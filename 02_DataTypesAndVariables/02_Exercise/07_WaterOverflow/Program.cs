int n = int.Parse(Console.ReadLine());
int totalLiters = 0;

for (int i = 0; i < n; i++)
{
    int litersToAdd = int.Parse(Console.ReadLine());

    if (totalLiters + litersToAdd > 255)
    {
        Console.WriteLine("Insufficient capacity!");
    }
    else
    {
        totalLiters += litersToAdd;
    }
}
Console.WriteLine(totalLiters);
