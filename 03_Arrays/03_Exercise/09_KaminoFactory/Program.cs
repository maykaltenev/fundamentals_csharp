// Read the length of the DNA sequence
int dnaLength = int.Parse(Console.ReadLine());

string input;
int bestSequenceIndex = 0;
int bestSequenceSum = 0;
int bestSubsequenceLength = 0;
int bestSubsequenceStartIndex = int.MaxValue;
int[] bestDnaSequence = new int[dnaLength];

int sequenceIndex = 0;

// Process each sequence until "Clone them!" is received
while ((input = Console.ReadLine()) != "Clone them!")
{
    // Split the sequence by "!" and parse it into an integer array
    int[] currentSequence = input
        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    sequenceIndex++;

    int currentSequenceSum = currentSequence.Sum();
    int currentSubsequenceLength = 0;
    int currentSubsequenceStartIndex = 0;

    int tempSubsequenceLength = 0;
    int tempSubsequenceStartIndex = 0;

    for (int i = 0; i < dnaLength; i++)
    {
        if (currentSequence[i] == 1)
        {
            tempSubsequenceLength++;
            if (tempSubsequenceLength == 1)
            {
                tempSubsequenceStartIndex = i;
            }

            if (tempSubsequenceLength > currentSubsequenceLength)
            {
                currentSubsequenceLength = tempSubsequenceLength;
                currentSubsequenceStartIndex = tempSubsequenceStartIndex;
            }
        }
        else
        {
            tempSubsequenceLength = 0;
        }
    }

    bool isBetterSequence = false;

    if (currentSubsequenceLength > bestSubsequenceLength)
    {
        isBetterSequence = true;
    }
    else if (currentSubsequenceLength == bestSubsequenceLength)
    {
        if (currentSubsequenceStartIndex < bestSubsequenceStartIndex)
        {
            isBetterSequence = true;
        }
        else if (currentSubsequenceStartIndex == bestSubsequenceStartIndex)
        {
            if (currentSequenceSum > bestSequenceSum)
            {
                isBetterSequence = true;
            }
        }
    }

    if (isBetterSequence)
    {
        bestSequenceIndex = sequenceIndex;
        bestSequenceSum = currentSequenceSum;
        bestSubsequenceLength = currentSubsequenceLength;
        bestSubsequenceStartIndex = currentSubsequenceStartIndex;
        bestDnaSequence = currentSequence;
    }
}

Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
Console.WriteLine(string.Join(" ", bestDnaSequence));
