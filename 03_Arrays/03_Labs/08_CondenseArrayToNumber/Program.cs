﻿string input = Console.ReadLine();

int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);

while (numbers.Length > 1)
{
    int[] condensed = new int[numbers.Length - 1];

    for (int i = 0; i < condensed.Length; i++)
    {
        condensed[i] = numbers[i] + numbers[i + 1];
    }

    numbers = condensed;
}

Console.WriteLine(numbers[0]);
