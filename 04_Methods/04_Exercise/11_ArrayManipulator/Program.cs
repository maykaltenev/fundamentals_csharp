int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
string input = Console.ReadLine();

while (input != "end")
{
    string[] parts = input.Split(' ');
    string command = parts[0];

    if (command == "exchange")
    {
        int index = int.Parse(parts[1]);

        if (index <= numbers.Length)
        {
            numbers = ExchangeArray(numbers, index);
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (command == "max")
    {
        string evenOrOdd = input.Split(' ')[1];
        if (evenOrOdd == "odd")
        {
            MaxOddOrEven(numbers, "odd");
        }
        else
        {
            MaxOddOrEven(numbers, "even");
        }
    }
    else if (command == "min")
    {
        string evenOrOdd = input.Split(' ')[1];
        if (evenOrOdd == "odd")
        {
            MinOddOrEven(numbers, "odd");
        }
        else
        {
            MinOddOrEven(numbers, "even");
        }
    }
    else if (command == "first")
    {
        int count = int.Parse(input.Split(' ')[1]);
        string evenOrOdd = input.Split(' ')[2];
        if (evenOrOdd == "odd")
        {
            FirstOddOrEven(numbers, count, "odd");
        }
        else
        {
            FirstOddOrEven(numbers, count, "even");
        }
    }
    else if (command == "last")
    {
        int count = int.Parse(input.Split(' ')[1]);
        string evenOrOdd = input.Split(' ')[2];
        if (evenOrOdd == "odd")
        {
            LastOddOrEven(numbers, count, "odd");
        }
        else
        {
            LastOddOrEven(numbers, count, "even");
        }
    }
    input = Console.ReadLine();
}

void LastOddOrEven(int[] numbers, int count, string type)
{
    if (count > numbers.Length)
    {
        Console.WriteLine("Invalid count");
    }

    int foundCount = 0;
    int[] lastNumbers = new int[count];

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        if (numbers[i] % 2 != 0 && type == "odd")
        {
            if (foundCount < count)
            {
                lastNumbers[foundCount] = numbers[i];
                foundCount++;
            }
        }
        else if (numbers[i] % 2 == 0 && type == "even")
        {
            if (foundCount < count)
            {
                lastNumbers[foundCount] = numbers[i];
                foundCount++;
            }
        }

        if (foundCount == count)
        {
            break;
        }
    }

    if (foundCount > 0)
    {
        int[] adjustedResult = new int[foundCount];

        for (int j = 0; j < foundCount; j++)
        {
            adjustedResult[j] = lastNumbers[foundCount - 1 - j];
        }

        Console.WriteLine($"[{string.Join(", ", adjustedResult)}]");
    }
    else
    {
        Console.WriteLine("No numbers found.");
    }
}

void FirstOddOrEven(int[] numbers, int count, string type)
{
    if (count > numbers.Length)
    {
        Console.WriteLine("Invalid count");
    }

    int foundCount = 0;
    int[] firstOddNumbers = new int[count];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 != 0 && type == "odd")
        {
            firstOddNumbers[foundCount] = numbers[i];
            foundCount++;

            if (foundCount == count)
            {
                break;
            }
        }
        else if (numbers[i] % 2 == 0 && type == "even")
        {
            firstOddNumbers[foundCount] = numbers[i];
            foundCount++;

            if (foundCount == count)
            {
                break;
            }
        }
    }

    int[] adjustedResult = new int[foundCount];

    for (int j = 0; j < foundCount; j++)
    {
        adjustedResult[j] = firstOddNumbers[j];
    }

    Console.WriteLine($"[{string.Join(", ", adjustedResult)}]");
}
void MinOddOrEven(int[] numbers, string type)
{
    int maxDigit = int.MaxValue;
    int index = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0 && type == "even")
        {
            if (numbers[i] <= maxDigit)
            {
                maxDigit = numbers[i];
                index = i;
            }
        }
        else if (numbers[i] % 2 != 0 && type == "odd")
        {
            if (numbers[i] <= maxDigit)
            {
                maxDigit = numbers[i];
                index = i;
            }
        }
    }
    if (index == -1)
    {
        Console.WriteLine("No matches");
    }
    else
    {
        Console.WriteLine(index);
    }
}

void MaxOddOrEven(int[] numbers, string type)
{
    int maxDigit = int.MinValue;
    int index = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0 && type == "even")
        {
            if (numbers[i] >= maxDigit)
            {
                maxDigit = numbers[i];
                index = i;
            }
        }
        else if (numbers[i] % 2 != 0 && type == "odd")
        {
            if (numbers[i] >= maxDigit)
            {
                maxDigit = numbers[i];
                index = i;
            }
        }
    }
    if (index == -1)
    {
        Console.WriteLine("No matches");
    }
    else
    {
        Console.WriteLine(index);
    }
}

static int[] ExchangeArray(int[] numbers, int index)
{
    int[] firstPart = numbers.Skip(index + 1).ToArray();
    int[] secondPart = numbers.Take(index + 1).ToArray();

    return firstPart.Concat(secondPart).ToArray();
}
