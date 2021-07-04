using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Implementation
{
    class Context
    {
        private IState _state;

        public string Data { get; set; }
        public Context()
        {
            //Init state
            _state = new ConcreteState(this);
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }
        
        public void Job1()
        {
            _state.Job1();
        }
        public void Job2()
        {
            _state.Job2();
        }
    }
}
