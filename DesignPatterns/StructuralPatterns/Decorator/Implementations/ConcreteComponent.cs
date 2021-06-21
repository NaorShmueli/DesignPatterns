using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Implementations
{
    /// <summary>
    /// This object will bee wrapped by decorator
    /// </summary>
    class ConcreteComponent : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteComponent working");
        }
    }
}
