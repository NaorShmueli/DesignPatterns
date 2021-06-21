using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementations
{
    class BaseDecorator : IComponent
    {
        private readonly IComponent _wrapee;
        public BaseDecorator(IComponent component)
        {
            _wrapee = component;
        }

        public virtual void Execute()
        {
            Console.WriteLine("BaseDecorator call his _wrapee.Execute()");
            _wrapee.Execute();
            Console.WriteLine("Can add here some logic");
        }
    }
}
