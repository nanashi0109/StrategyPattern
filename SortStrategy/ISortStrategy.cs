using System.Collections.Generic;

namespace StrategyPattern.Sort
{
    public interface ISortStrategy 
    {
        void Sort(List<int> numbers);
    }
}
