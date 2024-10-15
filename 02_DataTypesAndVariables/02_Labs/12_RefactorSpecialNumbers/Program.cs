int amountNumbers = int.Parse(Console.ReadLine());

for (int num = 1; num <= amountNumbers; num++)
{
    int currentNumber = num;
    int sumNumbers = 0;

    while (currentNumber > 0)
    {
        sumNumbers += currentNumber % 10;
        currentNumber /= 10;
    }

    bool isSpecialNumber = (sumNumbers == 5) || (sumNumbers == 7) || (sumNumbers == 11);

    Console.WriteLine("{0} -> {1}", num, isSpecialNumber);
}
