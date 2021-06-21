using Bridge.Example.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Abstraction
{
    class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device):base(device)
        {

        }

        public void Mute()
        {
            Console.WriteLine("Mute");
            _device.SetVolume(0);
        }
    }
}
