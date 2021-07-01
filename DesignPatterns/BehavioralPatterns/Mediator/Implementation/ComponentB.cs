using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Implementation
{
    class ComponentB
    {
        private readonly IMediator _mediator;
        public ComponentB(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void ComponentBOperationRelatedToA()
        {
            _mediator.Notify(this);
        }
        public void ComponentBOperation()
        {
            Console.WriteLine("Component******B****** do his job");
        }
        public void Reset()
        {
            Console.WriteLine("Component *****B***** Reset if component A triggerd");
        }
    }
}
