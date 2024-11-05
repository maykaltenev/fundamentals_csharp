string input = Console.ReadLine();
var arrays = input.Split('|').Select(arr => arr.Trim()).Reverse().ToArray();
var result = new List<string>();

foreach (var array in arrays)
{
    var numbers = array.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    result.AddRange(numbers);
}
Console.WriteLine(string.Join(" ", result));
