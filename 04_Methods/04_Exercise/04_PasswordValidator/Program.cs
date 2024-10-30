internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        bool passLength = GetPasswordValidationLength(input);
        bool passSymbol = GetPasswordValidationLettersAndDigits(input);
        bool passDigit = GetPasswordValidationToDigits(input);
        GetAllValidationInfo(passLength, passSymbol, passDigit);
    }

    private static bool GetPasswordValidationLength(string input)
    {
        if (input.Length < 6 || input.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
        }
        return true;
    }

    private static bool GetPasswordValidationLettersAndDigits(string input)
    {
        string[] specialCharacters =
        {
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",
            "(",
            ")",
            "-",
            "=",
            "{",
            "}",
            "[",
            "]",
            "|",
            "\\",
            ":",
            ";",
            "\"",
            "'",
            "<",
            ">",
            ",",
            ".",
            "?",
            "/",
            "~",
            "`"
        };
        for (int i = 0; i < input.Length; i++)
        {
            if (specialCharacters.Contains(input[i].ToString()))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
        }
        return true;
    }

    private static bool GetPasswordValidationToDigits(string input)
    {
        int count = 0;
        char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        for (int i = 0; i < input.Length; i++)
        {
            if (digits.Contains(input[i]))
            {
                count++;
            }
        }
        if (count < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }
        return true;
    }

    public static void GetAllValidationInfo(bool passLength, bool passSymbol, bool passDigit)
    {
        if (passLength && passSymbol && passDigit)
        {
            Console.WriteLine("Password is valid");
        }
    }
}
