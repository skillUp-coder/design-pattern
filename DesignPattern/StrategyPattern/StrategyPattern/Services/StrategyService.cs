using System;
using System.Collections.Generic;
using System.Linq;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Services
{
    public class StrategyService
    {
        private IStrategyService _strategyService;

        public StrategyService()
        {
        }
        
        public StrategyService(IStrategyService strategyService)
        {
            _strategyService = strategyService;
        }
        
        public void SetStrategy(IStrategyService strategyService)
        {
            _strategyService = strategyService;
        }
        
        public void DoSomeBusinessLogic()
        {
            const string message = "Context: Sorting data using the strategy (not sure how it'll do it)";
            
            Console.WriteLine(message);

            var objectList = new List<string> {"a", "b", "c", "d", "e"};
            var doAlgorithm = this._strategyService.DoAlgorithm(objectList);

            var resultStr = ((List<string>) doAlgorithm)
                .Aggregate(string.Empty, (current, element) => current + (element + ","));

            Console.WriteLine(resultStr);
        }
    }
}