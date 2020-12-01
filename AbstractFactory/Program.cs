using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = new ConcreteFactory1();
            var factory2 = new ConcreteFactory2();

            factory1.CreateProductA();
            factory1.CreateProductB();

            factory2.CreateProductA();
            factory2.CreateProductB();

            //factory만 교체하면 생성하는 제품군을 변경할 수 있습니다.
        }
    }
}
