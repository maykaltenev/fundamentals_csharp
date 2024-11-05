List<int> playerOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
List<int> playerTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

for (int i = 0; i < playerOne.Count; i++)
{
    if (playerOne[i] > playerTwo[i])
    {
        playerOne.Add(playerOne[i]);
        playerOne.Add(playerTwo[i]);
        playerOne.Remove(playerOne[i]);
        playerTwo.Remove(playerTwo[i]);
        i = -1;
        if (playerTwo.Count <= 0)
        {
            Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            break;
        }
    }
    else if (playerTwo[i] > playerOne[i])
    {
        playerTwo.Add(playerTwo[i]);
        playerTwo.Add(playerOne[i]);
        playerTwo.Remove(playerTwo[i]);
        playerOne.Remove(playerOne[i]);
        i = -1;
        if (playerOne.Count <= 0)
        {
            Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            break;
        }
    }
    else if (playerTwo[i] == playerOne[i])
    {
        playerOne.Remove(playerOne[i]);
        playerTwo.Remove(playerTwo[i]);
        i = -1;
        if (playerOne.Count <= 0 || playerTwo.Count <= 0)
        {
            if (playerOne.Sum() > playerTwo.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
                break;
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
                break;
            }
        }
    }
}
