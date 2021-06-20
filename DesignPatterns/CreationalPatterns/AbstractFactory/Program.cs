using AbstractFactory.Structure.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ConcreteFactory());
            client.Work();
            client = new Client(new ConcreteFactory2());
            client.Work();
        }
    }
}
