using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    class Composite : IComponent
    {
        private readonly IList<IComponent> _children;
        public Composite(IList<IComponent> components)
        {
            _children = components;
        }
        public int Execute()
        {
            int sum = 0;
            foreach (IComponent child in _children)
            {
                sum += child.Execute();
            }
            return sum;
        }

        public void Add(IComponent component)
        {
            _children.Add(component);
        }
        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public IList<IComponent> GetChildren()
        {
            return _children;
        }
    }
}
