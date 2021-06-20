using AbstractFactory.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Structure
{
    class ConcreteProductA : IProductA
    {
        public void WriteType()
        {
            Console.WriteLine(nameof(ConcreteProductA));
        }
    }
}
