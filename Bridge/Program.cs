namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //구현과 추상을 분리함으로써 서브클래싱으로 확장하기 편합니다.
            //Bridge 패턴을 이용하면 구현을 확장하기에 좋고 추상을 확장하기에도 좋습니다.
            //AbstractFactory와 협력하여 복합하는 것이 좋습니다.
            var abstraction1 = new Abstraction(new ConcreteImplementorA());
            var abstraction2 = new RefinedAbstraction(new ConcreteImplementorB());

            abstraction1.Operation();
            abstraction2.Operation2();
        }
    }
}
