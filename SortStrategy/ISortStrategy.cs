using System.Collections.Generic;

namespace StrategyPattern.Sort
{
    public interface ISortStrategy 
    {
        List<int> Sort(List<int> numbers);
    }
}
