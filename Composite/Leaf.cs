using System;

namespace Composite
{
    public class Leaf : IComponent
    {
        private string message;

        public Leaf(string message)
        {
            this.message = message;
        }

        public void Operation()
        {
            Console.WriteLine(message);
        }
    }

}
