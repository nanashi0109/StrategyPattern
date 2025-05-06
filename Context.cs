using StrategyPattern.Sort;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Context
    {
        private ISortStrategy _strategy;

        public Context(ISortStrategy strategy) 
            => _strategy = strategy;

        public void SetStrategy(ISortStrategy strategy) 
            => _strategy = strategy;

        public void ExecuteStrategy(List<int> numbers) 
            => _strategy.Sort(numbers);
    }
}
