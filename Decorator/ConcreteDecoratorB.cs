using System;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("  ConcreteDecoratorB");
        }
    }
}
