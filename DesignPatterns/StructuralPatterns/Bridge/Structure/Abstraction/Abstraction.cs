using Bridge.Structure.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Structure.Abstraction
{
    /// <summary>
    /// Client work only with this
    /// Or with Refind abstraction for updates features
    /// </summary>
    class Abstraction
    {
        protected readonly IImplementation _implementation;

        public Abstraction()
        {
            _implementation = new ConcreteImplementation();
        }

        public void Feature1()
        {
            Console.WriteLine("Do some work and then call Implementation");
            _implementation.Method1();
            _implementation.Method3();

        }

        public void Feature2()
        {
            Console.WriteLine("Do some work and then call Implementation");
            _implementation.Method2();

        }
    }
}
