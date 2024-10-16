int number = int.Parse(Console.ReadLine());

int sum = 0;
string numberToString = number.ToString();
for (int i = 0; i < numberToString.Length; i++)
{
    int current = int.Parse(numberToString[i].ToString());
    sum += current;
}
Console.WriteLine(sum);
