﻿// string n = Console.ReadLine();
// string[] inputStrings = n.Split(" ");

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sumEven = 0;
int sumOdd = 0;

for (int i = 0; i < numbers.Length; i++)
{
    // numbers[i] = int.Parse(inputStrings[i]);

    if (numbers[i] % 2 == 0)
    {
        sumEven += numbers[i];
    }
    else
    {
        sumOdd += numbers[i];
    }
}

Console.WriteLine(sumEven - sumOdd);
