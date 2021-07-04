using Observer.Implementation;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var sub1 = new ConcreteSubscriber();
            var publisher = new Publisher();
            //No subscribers
            publisher.Logic();
            publisher.Subscribe(sub1);

            publisher.Logic();
        }
    }
}
