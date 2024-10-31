List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
items.RemoveAll(n => n < 0);
if (items.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", items));
}
