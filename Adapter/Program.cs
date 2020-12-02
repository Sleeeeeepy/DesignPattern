using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adaptee = new Adaptee();

            //Delegation을 이용한 Adapter
            var adapter = new Adapter(adaptee);
            adapter.Request();

            //Inheritance를 이용한 Adapter
            //SpecificRequest()를 호출하지 않도록 주의합니다.
            var classAdapter = new ClassAdapter();
            classAdapter.Request();
        }
    }
}
