using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Services
{
    public class HandlerService
    {
        private ICommandService _commandService;

        private ICommandService _commandServiceSecond;
        
        public void SetOnStart(ICommandService command)
        {
            _commandService = command;
        }

        public void SetOnFinish(ICommandService command)
        {
            _commandServiceSecond = command;
        }
        
        public void DoSomethingImportant()
        {
            Console.WriteLine(nameof(DoSomethingImportant));
            if (_commandService is ICommandService)
            {
                _commandService.Execute();
            }
            
            if (_commandServiceSecond is ICommandService)
            {
                _commandServiceSecond.Execute();
            }
        }
    }
}