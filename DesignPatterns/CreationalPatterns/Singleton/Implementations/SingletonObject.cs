using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Implementations
{
    /// <summary>
    /// All data here shared
    /// </summary>
    sealed class SingletonObject
    {
        private static SingletonObject _instance = null;
        private static readonly object _lockObj = new object();
        private SingletonObject() { }

        internal static SingletonObject GetInstance()
        {
            lock (_lockObj)
            {
                if (_instance == null)
                {
                    _instance = new SingletonObject();
                }
            }
            
            return _instance;
        }
    }
}
