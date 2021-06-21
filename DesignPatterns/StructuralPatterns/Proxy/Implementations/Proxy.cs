using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Implementations
{
    class Proxy : IServiceInterface
    {
        private readonly Service _realService;
        private bool isAuth;
        public Proxy(Service service)
        {
            _realService = service;
        }
        /// <summary>
        /// We add some extra logic for checking auth and ip above the Service (befor calling him)
        /// we no need to change Service logic.
        /// </summary>
        /// <param name="user"></param>
        public void Operation(string user)
        {
            if (isAuth)
            {
                var userIp = Helper.GetUserIp(user);
                if (userIp == "127.0.0.1")
                {
                    _realService.Operation(user);
                }
                else
                {
                    Console.WriteLine("Ip not allowed");
                }
            }
            else
            {
                Console.WriteLine($"User {user} not Auth");
            }
        }

        public void Auth()
        {
            isAuth = true;
        }

        public void AuthExpired()
        {
            isAuth = false;
        }

    }
}
