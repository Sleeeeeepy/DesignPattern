using System;

namespace AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public ConcreteFactory1()
        {
            Console.WriteLine("ConcreteFactory1 has been created.");
        }

        public override AbstractProductA CreateProductA()
        {
            Console.WriteLine("AbstractProductA creates ProductA1.");
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            Console.WriteLine("AbstractProductA creates ProductB1.");
            return new ProductB2();
        }
    }
}
