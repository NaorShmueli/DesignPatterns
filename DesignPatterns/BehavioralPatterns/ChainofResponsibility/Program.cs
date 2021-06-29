using ChainofResponsibility.Implementations;
using System;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Chain 1************");
            var handler1 = new ConcreteHandler(false);
            var handler2 = new ConcreteHandler2(true);
            var handler3 = new ConcreteHandler3(false);
            handler1.SetNext(handler2);
            handler2.SetNext(handler3);
            handler1.Handle("Request");

            Console.WriteLine("************Chain 2************");
            handler1 = new ConcreteHandler(false);
            handler2 = new ConcreteHandler2(false);
            handler3 = new ConcreteHandler3(true);
            handler1.SetNext(handler2);
            handler2.SetNext(handler3);
            handler1.Handle("Request");

            Console.WriteLine("************Chain 3************");
            handler1 = new ConcreteHandler(true);
            handler2 = new ConcreteHandler2(false);
            handler3 = new ConcreteHandler3(false);
            handler1.SetNext(handler2);
            handler2.SetNext(handler3);
            handler1.Handle("Request");

            Console.WriteLine("************Chain 4************");
            handler1 = new ConcreteHandler(false);
            handler2 = new ConcreteHandler2(false);
            handler3 = new ConcreteHandler3(false);
            handler1.SetNext(handler2);
            handler2.SetNext(handler3);
            handler1.Handle("Request");
        }
    }
}
