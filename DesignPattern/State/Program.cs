using System;
using State.States;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();
        }
    }
    
    class ConcreteStateA : States.State
    {
        public override void Handle1()
        {
            Console.WriteLine($"{nameof(Handle1)}");
            this._context.TransitionTo(new ConcreteStateA());
        }

        public override void Handle2()
        {
            Console.WriteLine($"{nameof(Handle2)}");
        }
    }
}