int n = int.Parse(Console.ReadLine());
List<string> items = new List<string>(n);
for (int i = 0; i < n; i++)
{
    string product = Console.ReadLine();
    items.Add(product);
}
items.Sort();
for (int i = 0; i < items.Count; i++)
{
    Console.WriteLine($"{i + 1}.{items[i]}");
}
