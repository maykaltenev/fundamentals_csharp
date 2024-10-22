using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        
        int rotations = int.Parse(Console.ReadLine());
        rotations %= numbers.Length; 

        for (int i = 0; i < rotations; i++)
        {
            int firstNumber = numbers[0];
            for (int j = 0; j < numbers.Length - 1; j++) // Stop at the second-to-last element
            {
                numbers[j] = numbers[j + 1];
            }
            numbers[numbers.Length - 1] = firstNumber; // Move the first element to the end
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
