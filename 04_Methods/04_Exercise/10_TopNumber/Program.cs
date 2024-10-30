int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (IsTopNumber(i))
    {
        Console.WriteLine(i);
    }
}

bool IsTopNumber(int i)
{
    int sumOfDigits = 0;
    bool hasOddDigit = false;
    int currentNumber = i;

    while (currentNumber > 0)
    {
        int digit = currentNumber % 10;
        sumOfDigits += digit;

        if (digit % 2 != 0)
        {
            hasOddDigit = true;
        }
        currentNumber /= 10;
    }
    return (sumOfDigits % 8 == 0) && hasOddDigit;
}
