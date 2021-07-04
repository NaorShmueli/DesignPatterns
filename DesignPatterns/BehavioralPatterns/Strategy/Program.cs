using Strategy.Implementation;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            var strategy1 = new ConcreteStrategy();
            var data = new { Data = "Data" };
            context.SetStrategy(strategy1);
            context.Job(data);
            var newAlgo = new NewAlgorithm();
            context.SetStrategy(newAlgo);
            context.Job(data);
        }
    }
}
