using System;

namespace CommandPattern.Services
{
    public class ReceiverService
    {
        public void DoSomething(string content)
        {
            Console.WriteLine($"Receiver: Working on ({content}.)");
        }

        public void DoSomethingElse(string content)
        {
            Console.WriteLine($"Receiver: Also working on ({content}.)");
        }
    }
}