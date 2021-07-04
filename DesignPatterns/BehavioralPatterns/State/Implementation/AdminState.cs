using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Implementation
{
    class AdminState : IState
    {
        private Context _context;
        public AdminState(Context context)
        {
            _context = context;
        }
        public void Job1()
        {
            Console.WriteLine("Job1 working");
            Job2();
        }

        public void Job2()
        {
            Console.WriteLine("Job2 working");
            Console.WriteLine("Changing state to FinishState");
            _context.ChangeState(new FinishState(_context));

        }
    }
}
