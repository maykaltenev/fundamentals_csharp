string input = Console.ReadLine();
GetTwoMiddleCharacters(input);

void GetTwoMiddleCharacters(string input)
{
    int length = input.Length;

    if (length % 2 == 0)
    {
        char first = input[length / 2 - 1];
        char second = input[length / 2];
        Console.WriteLine($"{first}{second}");
    }
    else
    {
        char middle = input[length / 2];
        Console.WriteLine(middle);
    }
}
