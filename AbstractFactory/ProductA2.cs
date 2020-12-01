using System;

namespace AbstractFactory
{
    public class ProductA2 : AbstractProductA
    {
        public ProductA2()
        {
            Console.WriteLine("ProductA2 has been created.");
        }

        public override void PrintA()
        {
            Console.WriteLine("ProductA2");
        }
    }
}
