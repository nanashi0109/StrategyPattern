using StrategyPattern.Sort;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class App
    {
        private Context _context;
        private Dictionary<Strategies, ISortStrategy> _strategies;

        public App()
        {
            _context = new Context();

            _strategies = new Dictionary<Strategies, ISortStrategy>() 
            { 
                { Strategies.Bubble, new BubbleSortStrategy()},
                { Strategies.Insert, new InsertSortStrategy()},
                { Strategies.Quick, new QuickSortStrategy()},
            };
        }

        public void Start()
        {
            Console.WriteLine(ConsoleTextConstants.CHOICE_STRATEGY_TEXT);
            ChoiceStrategy();

            Console.WriteLine(ConsoleTextConstants.INPUT_NUMBERS_TEXT);
            List<int> numbers = ReadNumbers();

            _context.ExecuteStrategy(numbers);

            PrintArray(numbers);
        }

        private static void PrintArray(List<int> numbers) 
            => numbers.ForEach(x => Console.Write($"{x} "));

        private List<int> ReadNumbers()
        {
            var numbers_str = Console.ReadLine();
            List<int> numbers = new List<int>();

            try
            {
                numbers = numbers_str.Split(' ').Select(x => int.Parse(x)).ToList();
            }
            catch
            {
                Console.WriteLine(ErrorConstants.NOT_INT_IN_ARRAY);
            }

            return numbers;
        }

        private void ChoiceStrategy()
        {
            string str = Console.ReadLine();

            int.TryParse(str, out int strategyIndex);

            try
            {
                _context.SetStrategy(_strategies[(Strategies)strategyIndex]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine(ErrorConstants.INCORRECT_SORTING_INDEX);
            }
        }
    }
}
