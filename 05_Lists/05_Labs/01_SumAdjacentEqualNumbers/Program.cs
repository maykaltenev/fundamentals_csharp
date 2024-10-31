List<double> items = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

for (int i = 0; i < items.Count - 1; i++)
{
    if (items[i] == items[i + 1])
    {
        items[i] += items[i + 1];
        items.RemoveAt(i + 1);
        i = -1;
    }
}
Console.WriteLine(string.Join(" ", items));
