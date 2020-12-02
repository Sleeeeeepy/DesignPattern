using System;

namespace Adapter
{
    public class Adapter : ITarget
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
            Console.Write("\n\\n using Adapter.Request()\n");
        }
    }
}
