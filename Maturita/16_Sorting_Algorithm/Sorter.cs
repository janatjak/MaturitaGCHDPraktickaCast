using System;

namespace Maturita._16_Sorting_Algorithm
{
    public class Sorter<T> where T : IComparable<T>
    {
        public delegate T[] SortingAlgorithm(T[] array);

        private Sorter()
        {
        }

        public static void SwapVariables(ref T first, ref T second)
        {
            var helper = first;
            first = second;
            second = helper;
        }

        public static T[] Sort(SortingAlgorithm sortingAlgorithm, T[] array)
        {
            return sortingAlgorithm(array);
        }

        public static T[] InsertionSort(T[] array)
        {
            for (var i = 1 ; i <= array.Length - 1; i++)
            {
                var value = array[i];
                var j = i - 1;

                while(j >= 0 && array[j].CompareTo(value) == 1)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = value;
            }

            return array;
        }

        public static T[] SelectionSort(T[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var min = array[i];
                var minIndex = i;

                for (var j = i; j < array.Length; j++)
                {
                    if (array[j].CompareTo(min) != -1)
                        continue;

                    minIndex = j;
                    min = array[j];
                }

                SwapVariables(ref array[i], ref array[minIndex]);
            }

            return array;
        }
    }
}