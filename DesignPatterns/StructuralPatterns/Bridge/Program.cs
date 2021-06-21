using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.ToggleTv();
            client.ChannelUp();
            client.VolumeUp();
            Console.WriteLine(client.ToString());
            client.SwitchToRadio();
            client.ToggleTv();
            client.ChannelDown();
            client.VolumeDown();
            Console.WriteLine(client.ToString());
            //Not work
            client.Mute();
            client.UpgradeRemoteControl();
            client.ToggleTv();
            client.ChannelUp();
            client.VolumeUp();
            //work
            client.Mute();


        }
    }
}
