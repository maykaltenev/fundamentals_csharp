using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] data = Console.ReadLine().Split(' ');

        string command;
        while ((command = Console.ReadLine()) != "3:1")
        {
            var parts = command.Split(' ');

            if (parts[0] == "merge")
            {
                int startIndex = int.Parse(parts[1]);
                int endIndex = int.Parse(parts[2]);

                if (startIndex < 0)
                    startIndex = 0;
                if (endIndex >= data.Length)
                    endIndex = data.Length - 1;

                if (startIndex > endIndex)
                {
                    continue;
                }

                string merged = "";
                for (int i = startIndex; i <= endIndex; i++)
                {
                    merged += data[i];
                }

                List<string> updatedData = new List<string>();

                for (int i = 0; i < startIndex; i++)
                {
                    updatedData.Add(data[i]);
                }

                updatedData.Add(merged);

                for (int i = endIndex + 1; i < data.Length; i++)
                {
                    updatedData.Add(data[i]);
                }

                data = updatedData.ToArray();
            }
            else if (parts[0] == "divide")
            {
                int index = int.Parse(parts[1]);
                int partitions = int.Parse(parts[2]);

                if (index < 0 || index >= data.Length || partitions <= 0)
                {
                    continue;
                }

                string toDivide = data[index];
                List<string> dividedParts = new List<string>();

                int partLength = toDivide.Length / partitions;
                int remainder = toDivide.Length % partitions;

                for (int i = 0; i < partitions; i++)
                {
                    int currentPartLength = partLength + (i < remainder ? 1 : 0);
                    if (i < partitions - 1)
                    {
                        dividedParts.Add(toDivide.Substring(0, currentPartLength));
                        toDivide = toDivide.Substring(currentPartLength);
                    }
                    else
                    {
                        dividedParts.Add(toDivide);
                    }
                }

                List<string> updatedData = new List<string>();

                for (int i = 0; i < data.Length; i++)
                {
                    if (i != index)
                    {
                        updatedData.Add(data[i]);
                    }
                }

                updatedData.InsertRange(index, dividedParts);
                data = updatedData.ToArray();
            }
        }

        Console.WriteLine(string.Join(" ", data));
    }
}
