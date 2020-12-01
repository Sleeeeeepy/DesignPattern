using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            //builder에 메소드를 추가하여 Product의 속성의 값을 조작함으로써 복잡한 객체 생성을 간단하게 할 수 있습니다.
            //또한 builder 패턴은 이와 다른 여러 구현방법이 존재합니다.
            var builder1 = new ConcreteBuilder1();
            var builder2 = new ConcreteBuilder2();
            var direct1 = new Director(builder1);
            var direct2 = new Director(builder2);

            Console.WriteLine($"direct1 Product.str: {direct1.Construct().str}");
            Console.WriteLine($"direct2 Product.str: {direct2.Construct().str}");
        }
    }
}
