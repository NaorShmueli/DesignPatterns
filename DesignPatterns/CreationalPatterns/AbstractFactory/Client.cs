using AbstractFactory.Structure;
using AbstractFactory.Structure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        private readonly IAbstractFactory _factory;
        public Client(IAbstractFactory factory)
        {
            _factory = factory;
        }

        internal void Work()
        {
            var a = _factory.CreateA();
            var b = _factory.CreateB();
            a.WriteType();
            b.WriteType();
        }
    }
}
