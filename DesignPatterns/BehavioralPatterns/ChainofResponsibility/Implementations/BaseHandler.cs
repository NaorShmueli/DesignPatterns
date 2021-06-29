using ChainofResponsibility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility.Implementations
{
    abstract class BaseHandler : IHandler
    {
        private IHandler _next;
        public virtual void Handle(string request)
        {
            if (_next != null)
            {
                _next.Handle(request);
            }
            else
            {
                Console.WriteLine($"No have next");
            }
        }

        public void SetNext(IHandler handler)
        {
            _next = handler;
        }
    }
}
