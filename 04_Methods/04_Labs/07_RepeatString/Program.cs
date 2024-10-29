internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        string result = RepeatString(input, count);
        Console.WriteLine(result);
    }

    private static string RepeatString(string str, int repeat)
    {
        string result = "";
        for (int i = 0; i < repeat; i++)
        {
            result += str;
        }
        return result;
    }
}
