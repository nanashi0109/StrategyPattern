using StrategyPattern.Sort;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Context
    {
        private ISortStrategy _strategy;

        public void SetStrategy(ISortStrategy strategy) 
            => _strategy = strategy;

        public void ExecuteStrategy(List<int> numbers)
        {
            try
            {
                _strategy.Sort(numbers);
            }
            catch (NullReferenceException) 
            {
                Console.WriteLine(ErrorConstants.SORTING_NOT_SET);    
            }
        }
    }
}
