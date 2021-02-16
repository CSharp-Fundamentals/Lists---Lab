using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManupulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int index;
            while (input != "end")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Add")
                {
                    numbers.Add(index = int.Parse(tokens[1]));
                }
                else if (command=="Remove")
                {
                    numbers.Remove(index = int.Parse(tokens[1]));
                }
                else if (command=="RemoveAt")
                {
                    numbers.RemoveAt(index = int.Parse(tokens[1]));
                }
                else if (command=="Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
               input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
