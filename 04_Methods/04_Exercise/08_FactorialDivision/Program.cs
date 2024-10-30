int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

long factorialFirst = GetFactorialFirst(first);
long factorialSecond = GetFactorialSecond(second);
double result = GetDivisionBetweenFirstAndSecond(factorialFirst, factorialSecond);
Console.WriteLine($"{result:f2}");

long GetFactorialFirst(int first)
{
    long factorial = 1;
    for (int i = 1; i <= first; i++)
    {
        factorial *= i;
    }
    return factorial;
}

long GetFactorialSecond(int second)
{
    long factorial = 1;
    for (int i = 1; i <= second; i++)
    {
        factorial *= i;
    }
    return factorial;
}

double GetDivisionBetweenFirstAndSecond(double first, double second)
{
    return first / second;
}
