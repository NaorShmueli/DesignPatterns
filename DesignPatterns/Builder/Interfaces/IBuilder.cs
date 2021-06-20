using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    /// <summary>
    /// Define full instructions for building something
    /// can have multiple builders for different implementations like wooden house builder 
    /// or stone house builder
    /// </summary>
    interface IBuilder
    {
        void Reset();
        void BuildStepA();
        void BuildStepB();
        void BuildStepX();

    }
}
