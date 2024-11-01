// using System.Data;

// List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
// int maxCapacity = int.Parse(Console.ReadLine());

// string input;

// while ((input = Console.ReadLine()) != "end")
// {
//     string[] tokens = input.Split(' ');

//     if (tokens[0] == "Add")
//     {
//         int wagon = int.Parse(tokens[1]);
//         items.Add(wagon);
//     }
//     else
//     {
//         int passengersToAdd = int.Parse(tokens[0]);
//         for (int i = 0; i < items.Count && passengersToAdd > 0; i++)
//         {
//             int availableSpace = maxCapacity - items[i];

//             if (availableSpace > 0)
//             {
//                 int passengersToFit = Math.Min(passengersToAdd, availableSpace);
//                 items[i] += passengersToFit;
//                 passengersToAdd -= passengersToFit;
//             }
//         }
//     }
// }
// Console.WriteLine(string.Join(" ", items));
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> items = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int maxCapacity = int.Parse(Console.ReadLine());

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] tokens = input.Split(' ');

            if (tokens[0] == "Add")
            {
                int wagon = int.Parse(tokens[1]);
                items.Add(wagon);
            }
            else
            {
                int passengersToAdd = int.Parse(tokens[0]);

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] + passengersToAdd <= maxCapacity)
                    {
                        items[i] += passengersToAdd;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", items)); // Output final state
    }
}
