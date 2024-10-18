int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum = 0;
bool notIdentical = false;
for (int i = 0; i < first.Length; i++)
{
    if (first[i] != second[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        notIdentical = true;
        break;
    }
    sum += first[i];
}
if (!notIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
