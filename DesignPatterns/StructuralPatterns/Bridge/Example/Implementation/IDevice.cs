using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Implementation
{
    interface IDevice
    {
        bool IsEnable();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int vol);
        int GetChannel();
        void SetChannel(int Channel);
    }
}
