using Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Implementation
{
    class ComponentA
    {
        private readonly IMediator _mediator;
        public ComponentA(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void ComponentAOperationDependentToRelated()
        {
            _mediator.Notify(this);
        }

        public void ComponentAOperation()
        {
            Console.WriteLine("Component******A****** do his job");
        }


        public void Hidden()
        {
            Console.WriteLine("Component *****A***** Hidden if component B triggerd");
        }
    }
}
