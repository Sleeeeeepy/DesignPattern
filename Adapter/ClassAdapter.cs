using System;

namespace Adapter
{
    public class ClassAdapter : Adaptee, ITarget
    {
        public void Request()
        {
            this.SpecificRequest();
            Console.Write("\n\\n using ClassAdapter.Request()\n");
        }
    }
}
