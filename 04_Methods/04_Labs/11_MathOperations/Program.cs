internal class Program
{
    private static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        string action = Console.ReadLine();
        int second = int.Parse(Console.ReadLine());
        double result = Calculate(first, action, second);
        Console.WriteLine(result);
    }

    public static double Calculate(int first, string action, int second)
    {
        double result = 0;

        switch (action)
        {
            case "/":
                result = first / second;
                break;
            case "+":
                result = first + second;
                break;
            case "*":
                result = first * second;
                break;
            case "-":
                result = first - second;
                break;
        }
        return result;
    }
}
