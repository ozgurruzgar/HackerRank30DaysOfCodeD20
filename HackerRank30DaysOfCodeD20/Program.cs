using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank30DaysOfCodeD20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // Write your code here -- Kodunu buraya yaz.
            BubbleSort(a);
        }

        public static void BubbleSort(List<int> list)
        {
            var numberOfSwaps = 0;

            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        numberOfSwaps++;
                    }
                }

                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {list[0]}");
            Console.WriteLine($"Last Element: {list[list.Count - 1]}");
        }
    }
}
