int number = int.Parse(Console.ReadLine());
List<string> names = new List<string>();
for (int i = 0; i < number; i++)
{
    string input = Console.ReadLine();
    string[] tokens = input.Split(" ");

    if (tokens.Length == 3)
    {
        if (!names.Contains(tokens[0]))
        {
            names.Add(tokens[0]);
        }
        else
        {
            Console.WriteLine($"{tokens[0]} is already in the list!");
        }
    }
    else if (tokens.Length == 4)
    {
        if (!names.Contains(tokens[0]))
        {
            Console.WriteLine($"{tokens[0]} is not in the list!");
        }
        else
        {
            names.RemoveAll(x => x.Equals(tokens[0]));
        }
    }
}

Console.WriteLine(string.Join("\n", names));
