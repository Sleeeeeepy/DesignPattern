using System;

namespace FactoryMethod
{
    public class ConcreteProduct1 : Product
    {
        public ConcreteProduct1()
        {
            Console.WriteLine("ConcreteProduct1 has been created.");
        }

        public override void print()
        {
            Console.WriteLine("ConcreteProduct1 print()");
        }
    }
}
