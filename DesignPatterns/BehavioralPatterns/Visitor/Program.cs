using System;
using Visitor.Implementation;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can create more then 1 visitor
            var visitor = new ConcreteVisitor();
            var element1 = new ElementA();
            var element2 = new ElementB();
            var element3 = new ElementC();
            element1.Accept(visitor);
            element2.Accept(visitor);
            element3.Accept(visitor);
        }
    }
}
