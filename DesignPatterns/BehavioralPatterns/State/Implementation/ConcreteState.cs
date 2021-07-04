using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Implementation
{
    internal class ConcreteState : IState
    {
        private Context _context;

        public ConcreteState(Context context)
        {
            _context = context;
        }
        public void Job1()
        {
            Console.WriteLine("Job1 working");
            Console.WriteLine($"ConcreteState working job 1 on context Data = {_context.Data}");
            _context.Data = "Date from DB after job";
            Job2();
        }

        public void Job2()
        {
            if (!string.IsNullOrEmpty(_context.Data))
            {
                Console.WriteLine("Job2 working");
                Console.WriteLine("Changing state to AdminState");
                _context.ChangeState(new AdminState(_context));
            }
            else
            {
                Console.WriteLine($"No Data");
            }

        }

        public void SetContext(Context context)
        {
            _context = context;
        }
    }
}
