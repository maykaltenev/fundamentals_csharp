using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        (int[] evens, int[] odds) = GetMultipleOfEvenAndOdds(number);

        int sumOfEvenDigits = GetSumOfEvenDigits(evens);
        int sumOfOddDigits = GetSumOfOddDigits(odds);
        Console.WriteLine(sumOfEvenDigits * sumOfOddDigits);
    }

    private static (int[] evens, int[] odds) GetMultipleOfEvenAndOdds(int number)
    {
        string numberString = Math.Abs(number).ToString();
        int[] evens = new int[numberString.Length];
        int[] odds = new int[numberString.Length];

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < numberString.Length; i++)
        {
            int digit = numberString[i] - '0';
            if (digit % 2 == 0)
            {
                evens[evenCount++] = digit;
            }
            else
            {
                odds[oddCount++] = digit;
            }
        }
        Array.Resize(ref evens, evenCount);
        Array.Resize(ref odds, oddCount);
        return (evens, odds);
    }

    private static int GetSumOfEvenDigits(int[] evens)
    {
        return evens.Sum();
    }

    private static int GetSumOfOddDigits(int[] odds)
    {
        return odds.Sum();
    }
}
