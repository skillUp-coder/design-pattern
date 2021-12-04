using TemplateMethod.Services;

namespace TemplateMethod
{
    internal static class Program
    {
        private static void Main()
        {
            ClientService.Client(new ExampleService());
        }
    }
}