﻿int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int sum = 0;
    int digits = i;

    while (digits > 0)
    {
        sum += digits % 10;
        digits /= 10;
    }
    bool isSpecial = (sum == 5 || sum == 7 || sum == 11);
    Console.WriteLine($"{i} -> {isSpecial}");
}
