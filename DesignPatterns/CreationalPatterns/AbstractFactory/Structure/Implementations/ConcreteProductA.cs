using AbstractFactory.Structure;
using AbstractFactory.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Structure.Implementations
{
    class ConcreteProductA : IProductA
    {
        public void WriteType()
        {
            Console.WriteLine(nameof(ConcreteProductA));
        }
    }
}
