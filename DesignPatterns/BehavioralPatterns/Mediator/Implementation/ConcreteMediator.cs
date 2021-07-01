using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Implementation
{
    internal class ConcreteMediator : IMediator
    {
        private readonly ComponentA _componentA;
        private readonly ComponentB _componentB;

        public ConcreteMediator()
        {
            _componentA = new ComponentA(this);
            _componentB = new ComponentB(this);
        }

        public void Notify(object sender)
        {
            if (sender is ComponentA)
            {
                _componentB.Reset();
                (sender as ComponentA).ComponentAOperation();
            }
            else if (sender is ComponentB)
            {
                _componentA.Hidden();
                (sender as ComponentB).ComponentBOperation();
            }
        }
    }
}
