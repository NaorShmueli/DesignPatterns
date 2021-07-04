using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    interface ISubscriber
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">Some context args</param>
        void Update(object context);
    }
}
