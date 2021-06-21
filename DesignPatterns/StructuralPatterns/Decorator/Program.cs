using Decorator.Implementations;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceComponent = new ConcreteComponent();
            Console.WriteLine("working with component directly");
            var client = new Client(serviceComponent);
            client.Execute();
            Console.WriteLine("add decorator with more logic");
            client = new Client(new BaseDecorator(serviceComponent));
            client.Execute();

            Console.WriteLine("add decorator with extra advanced logic");
            client = new Client(new AdvancedDecorator(serviceComponent));
            client.Execute();

        }
    }
}
