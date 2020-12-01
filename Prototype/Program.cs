using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //.Net에서는 ICloneable interface를 이용해서 Prototype 패턴을 구현합니다.
            var prototype = new ConcretePrototype();
            var prototype2 = new ConcretePrototype(prototype);
            var clone = prototype.Clone();

            prototype.print();
            prototype2.print();

            //가장 상위의 Prototype class에는 print() 메소드가 없습니다.
            Console.WriteLine($"Clone Value: {clone.Value}");


            //Composite 패턴과 Decorator 패턴을 결합해서 사용하면 좋습니다.
        }
    }
}
