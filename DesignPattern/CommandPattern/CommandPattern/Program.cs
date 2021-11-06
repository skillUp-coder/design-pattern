using CommandPattern.Services;

namespace CommandPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var invoker = new HandlerService();
            var receiver = new ReceiverService();
            invoker.SetOnFinish(new ExampleService(receiver, "hello", "Bob"));

            invoker.DoSomethingImportant();
        }
    }
}