using Bridge.Example.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Abstraction
{
    class RemoteControl
    {
        protected readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }
        
        public void Toggle()
        {
            if (_device.IsEnable())
            {
                Console.WriteLine("Close");
                _device.Disable();
            }
            else
            {
                Console.WriteLine("Open");
                _device.Enable();
            }
        }

        public void VolumeDown()
        {
            Console.WriteLine("VolumeDown");
            var currVolume = _device.GetVolume();
            _device.SetVolume(currVolume--);
        }
        public void VolumeUp()
        {
            Console.WriteLine("VolumeUp");
            var currVolume = _device.GetVolume();
            _device.SetVolume(currVolume++);
        }

        public void ChannelDown()
        {
            Console.WriteLine("ChannelDown");
            var currChannel = _device.GetChannel();
            _device.SetChannel(currChannel--);
        }

        public void ChannelUp()
        {
            Console.WriteLine("ChannelUp");
            var currChannel = _device.GetChannel();
            _device.SetChannel(currChannel++);
        }

        public override string ToString()
        {
            return _device.ToString();
        }
    }
}
