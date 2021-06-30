using Iterator.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Structure.Implementation
{
    class ConcreteIterator : IIterator
    {
        private readonly ConcreteCollection _collection;

        public ConcreteIterator(ConcreteCollection collection)
        {
            _collection = collection;
        }
        private int iterationState;

        public string GetNext()
        {
            return _collection.Items[iterationState++];
        }

        public bool HasMore()
        {
            return _collection.Items.Count() - 1 >= iterationState;
        }
    }
}
