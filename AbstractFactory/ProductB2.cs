using System;

namespace AbstractFactory
{
    public class ProductB2 : AbstractProductB
    {
        public ProductB2()
        {
            Console.WriteLine("ProductB2 has been created.");
        }

        public override void PrintB()
        {
            Console.WriteLine("ProductB2");
        }
    }
}
