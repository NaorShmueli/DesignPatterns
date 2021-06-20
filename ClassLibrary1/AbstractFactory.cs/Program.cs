using AbstractFactory.Structure;
using System;

namespace AbstractFactory.cs
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
