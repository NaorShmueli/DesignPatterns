using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Implementations
{
    class ConcreteHandler2 : BaseHandler
    {
        public ConcreteHandler2(bool canHandleRequest)
        {
            CanHandleRequest = canHandleRequest;
        }
        public override void Handle(string request)
        {
            if (CanHandleRequest)
            {
                Console.WriteLine("ConcreteHandler2 can perform job and he actual working");
            }
            else
            {
                Console.WriteLine("ConcreteHandler2 cannot perform job and he forward the job to base class");
                base.Handle(request);
            }
        }

        private bool CanHandleRequest { get; set; }
    }
}
