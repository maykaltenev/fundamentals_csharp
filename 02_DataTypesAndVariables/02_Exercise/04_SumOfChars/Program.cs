int n = int.Parse(Console.ReadLine());
int totalSum = 0;

for (int i = 0; i < n; i++)
{
    char letter = char.Parse(Console.ReadLine());
    totalSum += letter;
}
Console.WriteLine($"Total sum equals: {totalSum}");
