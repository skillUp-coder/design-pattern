using System;

namespace TemplateMethod.Services
{
    public abstract class AbstractService
    {
        public void TemplateMethod()
        {
            OperationF();
            OperationS();
        }

        protected void OperationF()
        {
            Console.WriteLine(nameof(OperationF));
        }

        protected void OperationS()
        {
            Console.WriteLine(nameof(OperationS));
        }
        
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();
    }
}