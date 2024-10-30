int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());
int resultFirstTwoNumbers = Sum(firstNumber, secondNumber);
int resultThirdNumberSubtractedFromResultFirstTwoNumbers = Subtract(
    thirdNumber,
    resultFirstTwoNumbers
);
Console.WriteLine(resultThirdNumberSubtractedFromResultFirstTwoNumbers);

int Subtract(int thirdNumber, int resultFirstTwoNumbers)
{
    return resultFirstTwoNumbers - thirdNumber;
}

int Sum(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}
