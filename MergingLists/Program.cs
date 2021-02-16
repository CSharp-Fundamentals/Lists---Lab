using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> final = new List<int>();

            int limit = Math.Min(first.Count,second.Count);

            for (int i = 0; i < limit; i++)
            {
                final.Add(first[i]);
                final.Add(second[i]);
            }

            if ((first.Count != second.Count))
            {
                if (first.Count > second.Count)
                {
                    final.AddRange(AddRemainedValues(first, second));
                }
                else
                {
                    final.AddRange(AddRemainedValues(second, first));
                }
            }
            Console.WriteLine(string.Join(" ",final));
        }
        private static List<int> AddRemainedValues(List<int> longerList, List<int> shorterList) {
            if (longerList.Count<=shorterList.Count)
            {
                throw new ArgumentException();
            }

            List<int> result = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }

            return result;
        }
    }
}
