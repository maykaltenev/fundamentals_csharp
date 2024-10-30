CheckPalindrome();
void CheckPalindrome()
{
    string input = Console.ReadLine();
    while (input != "END")
    {
        string reversed = new string(input.Reverse().ToArray());
        if (input == reversed)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        input = Console.ReadLine();
    }
}
