using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Implementations
{
    class ConcreteCreatorB : ICreator
    {
        public IProduct CreateDeliver()
        {
            return new ConcreteProductB();
        }
    }
}
