List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

while (true)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        break;
    }
    string[] tokens = input.Split(' ');
    switch (tokens[0])
    {
        case "Add":
            items.Add(int.Parse(tokens[1]));
            break;
        case "Remove":
            items.Remove(int.Parse(tokens[1]));
            break;
        case "RemoveAt":
            items.RemoveAt(int.Parse(tokens[1]));
            break;
        case "Insert":
            items.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
            break;
    }
}
Console.WriteLine(string.Join(" ", items));
