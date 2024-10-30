string input = Console.ReadLine();
int result = GetVowelsCount(input);
Console.WriteLine("" + result);
int GetVowelsCount(string input)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (vowels.Contains(input[i]))
        {
            count++;
        }
    }
    return count;
}
