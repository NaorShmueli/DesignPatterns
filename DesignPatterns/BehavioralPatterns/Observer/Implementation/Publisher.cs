using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementation
{
    class Publisher
    {
        private IList<ISubscriber> _subscribers;
        // If state change publish.!
        // Not required you can choose publish with your logic
        private string _state;
        public Publisher()
        {
            _subscribers = new List<ISubscriber>();
            _state = "Init";
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }
        public void UnSubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        void NotifyAll(object context)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(context);
            }
        }

        public void Logic()
        {
            if (true)
            {
                NotifyAll(new { Data = "Data" });
            }
        }
    }
}
