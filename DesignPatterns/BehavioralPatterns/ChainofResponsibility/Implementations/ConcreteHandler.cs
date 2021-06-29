using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Implementations
{
    class ConcreteHandler : BaseHandler
    {
        public ConcreteHandler(bool canHandleRequest)
        {
            CanHandleRequest = canHandleRequest;
        }
        public override void Handle(string request)
        {
            if (CanHandleRequest)
            {
                Console.WriteLine("ConcreteHandler can perform job and he actual working");
            }
            else
            {
                Console.WriteLine("ConcreteHandler cannot perform job and he forward the job to base class");
                base.Handle(request);
            }
        }

        private bool CanHandleRequest { get; set; }
    }
}
