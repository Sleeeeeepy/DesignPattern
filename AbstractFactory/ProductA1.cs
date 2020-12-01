using System;

namespace AbstractFactory
{
    public class ProductA1 : AbstractProductA
    {
        public ProductA1()
        {
            Console.WriteLine("ProductA1 has been created.");
        }

        public override void PrintA()
        {
            Console.WriteLine("ProductA1");
        }
    }
}
