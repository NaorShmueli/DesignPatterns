using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Client
    {
        private readonly IComponent _component;
        public Client(IComponent component)
        {
            _component = component;
        }

        public void Execute()
        {
            _component.Execute();
        }
    }
}
