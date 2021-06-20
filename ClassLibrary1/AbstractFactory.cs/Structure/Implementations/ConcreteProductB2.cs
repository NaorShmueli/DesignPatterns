using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Structure
{
    class ConcreteProductB2 : IProductB
    {
        public void WriteType()
        {
            Console.WriteLine(nameof(ConcreteProductB2));
            Console.WriteLine("I will do some extra work");
        }
    }
}
