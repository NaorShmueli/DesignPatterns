using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementation
{
    class NewAlgorithm : IStrategy
    {
        public void Execute(object data)
        {
            Console.WriteLine($"Do something different on Data = {data} with the same meaning like search or processing something in a different way");
        }
    }
}
