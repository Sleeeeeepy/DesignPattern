using System;

namespace AbstractFactory
{
    public class ProductB1 : AbstractProductB
    {
        public ProductB1()
        {
            Console.WriteLine("ProductB1 has been created.");
        }

        public override void PrintB()
        {
            Console.WriteLine("ProductB1");
        }
    }
}
