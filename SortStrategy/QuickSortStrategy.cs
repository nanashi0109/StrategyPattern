using System;
using System.Collections.Generic;

namespace StrategyPattern.Sort
{
    public class QuickSortStrategy : ISortStrategy
    {
        public void Sort(List<int> array)
        {
            QuickSortAlgorithm(array, 0, array.Count - 1);
        }

        private static void QuickSortAlgorithm(List<int> array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                QuickSortAlgorithm(array, left, pivotIndex - 1);
                QuickSortAlgorithm(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(List<int> array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }

        private static void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
