using AbstractFactory.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Structure
{
    class ConcreteProductA2 : IProductA
    {
        public void WriteType()
        {
            Console.WriteLine(nameof(ConcreteProductA2));
            Console.WriteLine("I will do some extre work");
        }
    }
}
