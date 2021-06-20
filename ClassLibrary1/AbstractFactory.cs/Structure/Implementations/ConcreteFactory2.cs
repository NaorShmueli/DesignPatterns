using AbstractFactory.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Structure
{
    class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateA()
        {
            return new ConcreteProductA2();
        }

        public IProductB CreateB()
        {
            return new ConcreteProductB2();
        }
    }
}
