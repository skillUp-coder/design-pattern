using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Services
{
    public class CommandService : ICommandService
    {
        private readonly string _payload;

        public CommandService()
        {
            _payload = string.Empty;
        }

        public void Execute()
        {
            const string messageTemplate = "{0}: See, I can do simple things like printing ({1})";
            Console.WriteLine(messageTemplate, nameof(Execute), _payload);
        }
    }
}