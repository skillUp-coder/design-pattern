using System;
using System.Collections.Generic;

namespace BuilderPattern.Services
{
    public class ExampleService
    {
        private readonly IList<object> _parts;

        public ExampleService()
        {
            _parts = new List<object>();
        }
        
        public void Add(string part)
        {
            _parts.Add(part);
        }
        
        public string ListParts()
        {
            const string messageTemplate = "Product parts: {0}{1}";
            var message = string.Empty;

            for (var i = 0; i < _parts.Count; i++)
            {
                message += _parts[i] + ", ";
            }

            message = message.Remove(message.Length - 2);

            return string.Format(messageTemplate, message, Environment.NewLine);
        }
    }
}