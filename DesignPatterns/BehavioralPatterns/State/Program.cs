using State.Implementation;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            var state1 = new ConcreteState(context);
            context.Job1();
            context.Job1();
            context.Job1();
        }
    }
}
