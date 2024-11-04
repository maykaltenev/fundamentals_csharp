List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> specialNumberAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int specialNumber = specialNumberAndPower[0];
int power = specialNumberAndPower[1];
List<int> indexes = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == specialNumber)
    {
        int startIndex = Math.Max(0, i - power);
        int endIndex = Math.Min(numbers.Count - 1, i + power);

        for (int j = endIndex; j >= startIndex; j--)
        {
            numbers.RemoveAt(j);
        }
    }
}
int sum = 0;
for (int i = 0; i < numbers.Count; i++)
{
    sum += numbers[i];
}
Console.WriteLine("" + sum);
