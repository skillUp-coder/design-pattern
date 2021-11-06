using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Services
{
    public class ExampleService : ICommandService
    {
        private readonly ReceiverService _receiverService;

        private readonly string _exampleFirst;

        private readonly string _exampleSecond;

        public ExampleService(ReceiverService receiverService, string exampleF, string exampleS)
        {
            _receiverService = receiverService;
            _exampleFirst = exampleF;
            _exampleSecond = exampleS;
        }

        public void Execute()
        {
            Console.WriteLine(nameof(ExampleService));
            _receiverService.DoSomething(_exampleFirst);
            _receiverService.DoSomethingElse(_exampleSecond);
        }
    }
}