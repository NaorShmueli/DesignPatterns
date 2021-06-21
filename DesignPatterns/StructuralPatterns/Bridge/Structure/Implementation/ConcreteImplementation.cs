using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Structure.Implementation
{
    class ConcreteImplementation : IImplementation
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Method3");
        }
    }
}
