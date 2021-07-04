using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Implementation
{
    class FinishState : IState
    {
        private Context _context;

        public FinishState(Context context)
        {
            _context = context;
        }
        public void Job1()
        {
            Console.WriteLine("Prepare FinishState");
            Job2();
        }

        public void Job2()
        {
            Console.WriteLine($"Finish for context data = {_context.Data}");
        }
    }
}
