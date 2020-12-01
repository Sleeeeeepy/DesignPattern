using System;

namespace FactoryMethod
{
    public class ConcreteProduct3 : Product
    {
        public ConcreteProduct3()
        {
            Console.WriteLine("ConcreteProduct3 has been created.");
        }

        public override void print()
        {
            Console.WriteLine("ConcreteProduct3 print()");
        }
    }
}
