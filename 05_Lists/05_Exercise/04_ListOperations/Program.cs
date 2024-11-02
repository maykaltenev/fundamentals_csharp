List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split(' ');
    if (tokens[0] == "Add")
    {
        int count = int.Parse(tokens[1]);
        list.Add(count);
    }
    else if (tokens[0] == "Remove")
    {
        int index = int.Parse(tokens[1]);
        if (index >= 0 && index < list.Count)
        {
            list.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index!");
        }
    }
    else if (tokens[0] == "Insert")
    {
        int number = int.Parse(tokens[1]);
        int index = int.Parse(tokens[2]);
        if (index >= 0 && index < list.Count)
        {
            list.Insert(index, number);
        }
        else
        {
            Console.WriteLine("Invalid index!");
        }
    }
    else if (tokens[0] == "Shift")
    {
        string direction = tokens[1];
        int rotations = int.Parse(tokens[2]) % list.Count;
        if (direction == "left")
        {
            for (int i = 0; i < rotations; i++)
            {
                int firstElement = list[0];
                list.RemoveAt(0);
                list.Add(firstElement);
            }
        }
        else if (direction == "right")
        {
            for (int i = 0; i < rotations; i++)
            {
                int lastElement = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, lastElement);
            }
        }
    }
}
Console.WriteLine(string.Join(" ", list));
