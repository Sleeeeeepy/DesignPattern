using System;

namespace FactoryMethod
{
    public class ConcreteProduct2 : Product
    {
        public ConcreteProduct2()
        {
            Console.WriteLine("ConcreteProduct2 has been created.");
        }

        public override void print()
        {
            Console.WriteLine("ConcreteProduct2 print()");
        }
    }
}
