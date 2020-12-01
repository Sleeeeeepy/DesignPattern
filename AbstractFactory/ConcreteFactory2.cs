using System;

namespace AbstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public ConcreteFactory2()
        {
            Console.WriteLine("ConcreteFactory2 has been created.");
        }

        public override AbstractProductA CreateProductA()
        {
            Console.WriteLine("AbstractProductA creates ProductA2.");
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            Console.WriteLine("AbstractProductA creates ProductB2.");
            return new ProductB2();
        }
    }
}
