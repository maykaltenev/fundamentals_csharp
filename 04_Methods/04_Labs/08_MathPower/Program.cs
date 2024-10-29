internal class Program
{
    private static void Main(string[] args)
    {
        double numberOne = double.Parse(Console.ReadLine());
        double numberTwo = double.Parse(Console.ReadLine());
        double result = RaiseToPower(numberOne, numberTwo);
        Console.WriteLine(result);
    }

    private static double RaiseToPower(double first, double second)
    {
        return Math.Pow(first, second);
    }
}
