int n = int.Parse(Console.ReadLine());
int[] train = new int[n];
for (int i = 0; i < n; i++)
{
    train[i] = int.Parse(Console.ReadLine());
}
int total = 0;
for (int i = 0; i < train.Length; i++)
{
    total += train[i];
    Console.Write($"{train[i]} ");
}
Console.WriteLine();
Console.WriteLine(total);
