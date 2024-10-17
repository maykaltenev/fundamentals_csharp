string input = Console.ReadLine();

string[] numbers = input.Split(' ');

foreach (string num in numbers)
{
    double number = double.Parse(num);
    int roundedNumber = (int)Math.Round(number);

    Console.WriteLine($"{number} => {roundedNumber}");
}
