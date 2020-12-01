using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //단일 인스턴스를 보장합니다.
            Singleton.GetInstance().SingletonData = 1;
            Singleton.GetInstance().print();
            Singleton.GetInstance().SingletonData = 2;
            Singleton.GetInstance().print();
            Singleton.GetInstance().SingletonData = 3;
            Singleton.GetInstance().print();

            //Thread-safe 하지 않습니다. 이를 위해 생성자에서 늦은 초기화를 하기도 합니다.
        }
    }
}
