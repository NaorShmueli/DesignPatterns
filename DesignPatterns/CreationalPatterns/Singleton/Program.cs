using Singleton.Implementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var arrayTask = new List<Task>();
            for(int i = 0; i < 1000; i++)
            {
                arrayTask.Add(Task.Factory.StartNew(() => SingletonObject.GetInstance()));
            }

            Task.WaitAll(arrayTask.ToArray());
        }
    }
}
