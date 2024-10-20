using System;

int n = int.Parse(Console.ReadLine());
int[] array1 = new int[n];
int[] array2 = new int[n];

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    int firstNum = int.Parse(input[0]);
    int secondNum = int.Parse(input[1]);

    if (i % 2 == 0)
    {
        array1[i] = firstNum;
        array2[i] = secondNum;
    }
    else
    {
        array1[i] = secondNum;
        array2[i] = firstNum;
    }
}

Console.WriteLine(string.Join(" ", array1));
Console.WriteLine(string.Join(" ", array2));
