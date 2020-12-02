using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var compo = new ConcreteComponent();
            var decorator1 = new ConcreteDecoratorA(compo);
            var decorator2 = new ConcreteDecoratorB(compo);
            var decorator3 = new ConcreteDecoratorA(new ConcreteDecoratorB(compo));

            compo.Operation();
            decorator1.Operation();
            decorator2.Operation();
            decorator3.Operation();
        }
    }
}
