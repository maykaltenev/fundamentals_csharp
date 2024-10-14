﻿int number = int.Parse(Console.ReadLine());
int originalNumber = number;
int sumOfFactorials = 0;

while (number > 0)
{
    int digit = number % 10;
    int factorial = 1;

    for (int i = 1; i <= digit; i++)
    {
        factorial *= i; // Calculate factorial
    }

    sumOfFactorials += factorial;
    number /= 10;
}

if (sumOfFactorials == originalNumber)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
