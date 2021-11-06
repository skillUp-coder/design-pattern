using System.Collections.Generic;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Services
{
    public class ExampleStrategyService : IStrategyService
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list?.Sort();

            return list;
        }
    }
}