char start = Console.ReadLine()[0];
char end = Console.ReadLine()[0];
GetCharactersInRange(start, end);

void GetCharactersInRange(char start, char end)
{
    for (char i = (char)(start + 1); i < end; i++)
    {
        Console.Write(i + " ");
    }
}
