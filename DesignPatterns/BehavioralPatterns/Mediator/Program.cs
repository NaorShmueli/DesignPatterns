using Mediator.Implementation;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var componentA = new ComponentA(mediator);
            var componentB = new ComponentB(mediator);
            componentA.ComponentAOperationDependentToRelated();
            componentB.ComponentBOperationRelatedToA();
        }
    }
}
