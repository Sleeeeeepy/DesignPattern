namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Facade 패턴은 사용자와 서브시스템 간의 결합도를 줄입니다.
            //Facade 패턴을 이용하면 어떤 서브시스템 구현이 사용되고 있는 지 알 필요가 없습니다.
            var builder = new Facade("facade.vb");
            builder.Build();

            builder.filename = "facade.cs";
            builder.Build();

            builder.filename = "facade.java";
            builder.Build();
        }
    }
}
