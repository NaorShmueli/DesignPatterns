using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementation
{
    class ConcreteStrategy : IStrategy
    {
        public void Execute(object data)
        {
            Console.WriteLine($"Check if {data} is valid");
            Console.WriteLine($"ConcreteStrategy working on Data = {data}");
        }
    }
}
