using System;

namespace TemplateMethod.Services
{
    public class ExampleService : AbstractService
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine($"{nameof(ExampleService)} {nameof(RequiredOperations1)}");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine($"{nameof(ExampleService)} {nameof(RequiredOperation2)}");
        }
    }
}