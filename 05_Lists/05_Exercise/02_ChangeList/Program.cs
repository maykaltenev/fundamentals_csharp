List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string command;

while ((command = Console.ReadLine()) != "end")
{
    string[] tokens = command.Split(' ');
    if (tokens[0] == "Delete")
    {
        items.RemoveAll(x => x == int.Parse(tokens[1]));
    }
    else if (tokens[0] == "Insert")
    {
        int element = int.Parse(tokens[1]);
        int position = int.Parse(tokens[2]);
        items.Insert(position, element);
    }
}
Console.WriteLine(string.Join(" ", items));
