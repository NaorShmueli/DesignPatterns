using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementation
{
    class Context
    {
        private IStrategy _strategy;
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Job(object data)
        {
            Console.WriteLine("Context working");
            _strategy.Execute(data);
        }

    }
}
