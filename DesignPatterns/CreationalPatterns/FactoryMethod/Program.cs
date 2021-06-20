using FactoryMethod.Implementations;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ConcreteCreatorA());
            client.Deliver();
            client = new Client(new ConcreteCreatorB());
            client.Deliver();

        }
    }
}
