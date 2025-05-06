using System;
using System.Collections.Generic;

namespace StrategyPattern.Sort
{
    public class InsertSortStrategy : ISortStrategy
    {
        public void Sort(List<int> array)
        {
            for (int i = 1; i < array.Count; i++)
            {
                int current = array[i];  
                int j = i - 1;         

                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }
        }
    }
}
