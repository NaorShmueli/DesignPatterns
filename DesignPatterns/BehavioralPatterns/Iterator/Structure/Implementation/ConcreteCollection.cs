using Iterator.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Structure.Implementation
{
    internal class ConcreteCollection : IIterableCollection
    {
        internal ConcreteCollection(string [] items)
        {
            Items = items;
        }
        public string [] Items { get; private set; }
        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
