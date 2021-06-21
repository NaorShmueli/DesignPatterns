using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Implementations
{
    class Context
    {
        private string _uniqueState;
        private Flyweight _flyweight;

        public Context(string reapitingState, string uniqueState)
        {
            _uniqueState = uniqueState;
            _flyweight = FlyweightFactory.GetFlyweight(reapitingState);
        }

        public void SomeOperation()
        {
            Console.WriteLine($"Context with Flyweight uniqueState {_uniqueState} and Flyweight reapitingState {_flyweight._reapitingState} is working");
        }
    }
}
