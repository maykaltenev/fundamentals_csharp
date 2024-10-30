int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int smallest = GetSmallestNumber(firstNumber, secondNumber, thirdNumber);
Console.WriteLine(smallest);
int GetSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
{
    int smallest = int.MaxValue;
    int[] allNumbers = { firstNumber, secondNumber, thirdNumber };
    for (int i = 0; i < allNumbers.Length; i++)
    {
        if (allNumbers[i] < smallest)
        {
            smallest = allNumbers[i];
        }
    }
    return smallest;
}
