using System;
using System.Linq;

namespace Maturita._16_Sorting_Algorithm
{
    public class Tester
    {
        public static bool TestInsertionSort()
        {
            var unsorted = new[] {5, 6, 3, 7, 9, 3, 5, 6, 45, 2, 43, 5, 345, 34};

            var sorted = Sorter<int>.InsertionSort(unsorted);

            Array.Sort(unsorted);

            return sorted.SequenceEqual(unsorted);
        }

        public static bool TestSelectionSort()
        {
            var unsorted = new[] {5, 6, 3, 7, 9, 3, 5, 6, 45, 2, 43, 5, 345, 34};

            var sorted = Sorter<int>.SelectionSort(unsorted);

            Array.Sort(unsorted);

            return sorted.SequenceEqual(unsorted);
        }
    }
}