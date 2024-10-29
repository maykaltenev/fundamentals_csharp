using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        PrintTriangle(number);
        PrintReverseTriangle(number);
    }

    static void PrintTriangle(int maxNumber)
    {
        for (int row = 1; row <= maxNumber; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintReverseTriangle(int maxNumber)
    {
        for (int row = maxNumber - 1; row > 0; row--)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}
