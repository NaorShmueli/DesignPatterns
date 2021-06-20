using AbstractFactory.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Structure
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
