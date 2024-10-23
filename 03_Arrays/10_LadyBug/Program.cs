int fieldSize = int.Parse(Console.ReadLine());
int[] field = new int[fieldSize];
int[] ladybugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

foreach (int index in ladybugsIndexes)
{
    if (index >= 0 && index < fieldSize)
    {
        field[index] = 1;
    }
}
string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] commandParts = command.Split();
    int ladybugIndex = int.Parse(commandParts[0]);
    string direction = commandParts[1];
    int flyLength = int.Parse(commandParts[2]);

    if (ladybugIndex < 0 || ladybugIndex >= fieldSize || field[ladybugIndex] == 0)
    {
        continue;
    }
    field[ladybugIndex] = 0;
    int movement = direction == "right" ? 1 : -1;
    int newPosition = ladybugIndex + (movement * flyLength);

    while (newPosition >= 0 && newPosition < fieldSize && field[newPosition] == 1)
    {
        newPosition += (movement * flyLength);
    }

    if (newPosition >= 0 && newPosition < fieldSize)
    {
        field[newPosition] = 1;
    }
}
Console.WriteLine(string.Join(" ", field));
