using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //다른 종류의 객체를 생성할 수 있습니다.
            var creator = new ConcreteCreator();
            var product0 = creator.Create(ProductID.Product);
            var product1 = creator.Create(ProductID.Product1);
            var product2 = creator.Create(ProductID.Product2);
            var product3 = creator.Create(ProductID.Product3);

            product0.print();
            product1.print();
            product2.print();
            product3.print();
        }
    }
}
