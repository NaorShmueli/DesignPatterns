using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Client
    {
        private readonly IComponent _component;
        public Client(IComponent component)
        {
            _component = component;
        }

        public int GetPrice()
        {
           return  _component.Execute();
        }
    }
}
