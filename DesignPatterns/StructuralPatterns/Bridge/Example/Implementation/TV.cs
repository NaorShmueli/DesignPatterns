using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example.Implementation
{
    class TV : IDevice
    {
        private bool _isEnable;
        private int _currentChannel;
        private int _currentVolume;
        private string _tvScreenSize;

        public TV(string tvScreenSize)
        {
            _tvScreenSize = tvScreenSize;
        }

        public void Disable()
        {
            _isEnable = false;
        }

        public void Enable()
        {
            _isEnable = true;
        }

        public int GetChannel()
        {
            return _currentChannel;
        }

        public int GetVolume()
        {
            return _currentVolume;
        }

        public bool IsEnable()
        {
            return _isEnable;
        }

        public void SetChannel(int channel)
        {
            _currentChannel = channel;
        }

        public void SetVolume(int vol)
        {
            _currentVolume = vol;
        }
        
        public string GetTvScreenSize()
        {
            return _tvScreenSize;
        }

        public override string ToString()
        {
            return $"Im TV";
        }
    }
}
