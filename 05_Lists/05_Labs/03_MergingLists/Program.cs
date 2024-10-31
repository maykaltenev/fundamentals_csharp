List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> result = new List<int>();

for (var i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
{
    result.Add(firstList[i]);
    result.Add(secondList[i]);
}
result.AddRange(firstList.Skip(result.Count / 2));
result.AddRange(secondList.Skip(result.Count / 2));
Console.WriteLine(string.Join(" ", result));
