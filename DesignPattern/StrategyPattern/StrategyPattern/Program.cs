using StrategyPattern.Services;

namespace StrategyPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var context = new StrategyService();
            
            context.SetStrategy(new ExampleStrategyService());
            context.DoSomeBusinessLogic();
        }
    }
}
