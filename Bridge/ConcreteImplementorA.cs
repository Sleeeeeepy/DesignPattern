using System;

namespace Bridge
{
    public class ConcreteImplementorA : IImplementor
    {
        public void OperationImpl()
        {
            Console.WriteLine("ConcreteImplementorA.OperationImpl()");
        }
    }
}
