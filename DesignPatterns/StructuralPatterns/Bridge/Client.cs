using Bridge.Example.Abstraction;
using Bridge.Example.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Remote for TV
    /// For radio need create new client 
    /// but here we switch for illustrate Bridge pattern
    /// </summary>
    class Client
    {
        private RemoteControl _abstraction;
        public Client()
        {
            _abstraction = new RemoteControl(new TV("65'"));
        }

        public void ToggleTv()
        {
            _abstraction.Toggle();
        }

        public void VolumeUp()
        {
            _abstraction.VolumeUp();
        }

        public void VolumeDown()
        {
            _abstraction.VolumeDown();
        }

        public void ChannelDown()
        {
            _abstraction.ChannelDown();
        }
        public void ChannelUp()
        {
            _abstraction.ChannelUp();
        }

        public void UpgradeRemoteControl()
        {
            Console.WriteLine("Upgrade remote control add feature mute");
            _abstraction = new AdvancedRemoteControl(new TV("65'"));
        }

        public void DownGradeRemoteControl()
        {
            Console.WriteLine("Downgrade remote control remove feature mute");
            _abstraction = new RemoteControl(new TV("65'"));
        }

        public void SwitchToRadio()
        {
            Console.WriteLine("Swtich to radio");
            _abstraction = new RemoteControl(new Radio());
        }

        public void Mute()
        {
            if(_abstraction is AdvancedRemoteControl)
            {
                (_abstraction as AdvancedRemoteControl).Mute();
            }
        }

        public override string ToString()
        {
            return _abstraction.ToString();
        }
    }
}
