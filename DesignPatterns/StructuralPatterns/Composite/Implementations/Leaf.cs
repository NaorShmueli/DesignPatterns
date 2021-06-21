using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementations
{
    class Leaf : IComponent
    {
        private int _price;
        public Leaf(int price)
        {
            _price = price;
        }
        public int Execute()
        {
            return _price;
        }
    }
}
