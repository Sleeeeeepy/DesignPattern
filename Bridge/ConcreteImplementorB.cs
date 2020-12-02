using System;

namespace Bridge
{
    public class ConcreteImplementorB : IImplementor
    {
        public void OperationImpl()
        {
            Console.WriteLine("ConcreteImplementorB.OperationImpl()");
        }
    }

}
