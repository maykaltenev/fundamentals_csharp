int n = int.Parse(Console.ReadLine());
int sum = 0;
int currentOddNumber = 1;

for (int i = 0; i < n; i++)
{
    Console.WriteLine(currentOddNumber);
    sum += currentOddNumber;
    currentOddNumber += 2;
}

Console.WriteLine($"Sum: {sum}");
