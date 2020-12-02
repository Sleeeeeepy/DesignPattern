using System;

namespace Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor) { }

        public void Operation2()
        {
            Operation();
            Console.WriteLine("RefinedAbstraction.Operation2()");
        }
    }
}
