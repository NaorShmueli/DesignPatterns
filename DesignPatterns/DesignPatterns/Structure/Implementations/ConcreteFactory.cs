using AbstractFactory.Structure;
using AbstractFactory.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Structure.Implementations
{
    class ConcreteFactory : IAbstractFactory
    {
        public IProductA CreateA()
        {
            return new ConcreteProductA();
        }

        public IProductB CreateB()
        {
            return new ConcreteProductB();
        }
    }
}
