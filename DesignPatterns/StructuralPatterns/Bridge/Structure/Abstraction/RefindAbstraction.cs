using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Structure.Abstraction
{
    class RefindAbstraction : Abstraction
    {
        public RefindAbstraction():base()
        {

        }
        public void FeatureN()
        {
            Console.WriteLine("Some extra feature");
            Console.WriteLine("Do some work and then call Implementation");
            _implementation.Method3();
        }
    }
}
