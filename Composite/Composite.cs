using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> children;

        public Composite()
        {
            children = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            children.Add(component);
        }

        public IComponent GetChild(int index)
        {
            return children.ElementAt(index);
        }

        public void Operation()
        {
            foreach (var child in children)
            {
                child.Operation();
            }
        }

        public void Remove(IComponent component)
        {
            children.Remove(component);
        }
    }
}
