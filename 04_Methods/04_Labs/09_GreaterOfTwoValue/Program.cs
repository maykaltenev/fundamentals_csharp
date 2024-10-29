using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());
            int result = GetMax(firstValue, secondValue);
            Console.WriteLine(result);
        }
        else if (type == "char")
        {
            char firstValue = Console.ReadLine()[0];
            char secondValue = Console.ReadLine()[0];
            char result = GetMax(firstValue, secondValue);
            Console.WriteLine(result);
        }
        else if (type == "string")
        {
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            string result = GetMax(firstValue, secondValue);
            Console.WriteLine(result);
        }
    }

    private static int GetMax(int value, int secondValue)
    {
        return value > secondValue ? value : secondValue;
    }

    private static char GetMax(char value, char secondValue)
    {
        return value > secondValue ? value : secondValue;
    }

    private static string GetMax(string value, string secondValue)
    {
        return string.Compare(value, secondValue) > 0 ? value : secondValue;
    }
}
