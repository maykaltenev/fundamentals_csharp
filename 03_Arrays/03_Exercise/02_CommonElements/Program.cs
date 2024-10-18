string[] first = Console.ReadLine().Split(" ");
string[] second = Console.ReadLine().Split(" ");
string[] common = new string[second.Length];
int commonIndex = 0;
for (int i = 0; i < first.Length; i++)
{
    for (int j = 0; j < second.Length; j++)
    {
        if (first[i] == second[j])
        {
            bool alreadyExists = false;
            for (int k = 0; k < commonIndex; k++)
            {
                if (common[k] == first[i])
                {
                    alreadyExists = true;
                    break;
                }
            }
            if (!alreadyExists)
            {
                common[commonIndex] = first[i];
                commonIndex++;
            }
        }
    }
}
if (commonIndex > 0)
{
    for (int i = 0; i < commonIndex; i++)
    {
        Console.Write(common[i] + " ");
    }
    Console.WriteLine();
}
