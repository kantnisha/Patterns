using System;

namespace Command.Code
{
    public class CeilingFan
    {
        public const int CHigh = 3;
        public const int CMedium = 2;
        public const int CLow = 1;
        public const int COff = 0;
        private string _location;
        private int _speed;

        public CeilingFan(String location)
        {
            _location = location;
        }

        public void High()
        {
            _speed = CHigh;
            Console.WriteLine("CeilingFun high speed in {0}",_location);
        }
        public void Medium()
        {
            _speed = CMedium;
            Console.WriteLine("CeilingFun medium speed in {0}", _location);
        }
        public void Low()
        {
            _speed = CLow;
            Console.WriteLine("CeilingFun low speed in {0}", _location);
        }
        public void Off()
        {
            _speed = COff;
            Console.WriteLine("CeilingFun off speed in {0}", _location);
        }

        public int GetSpeed()
        {
            return _speed;
        }
    }

    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light on");
        }
        public void Off()
        {
            Console.WriteLine("Light off");
        }
    }

    public class Stereo
    {
        private int _volume;
        public void On()
        {
            Console.WriteLine("Stereo on");
        }
        public void Off()
        {
            Console.WriteLine("Stereo off");
        }
        public void SetCD()
        {
            Console.WriteLine("CD");
        }
        public void SetDVD()
        {
            Console.WriteLine("DVD");
        }
        public void SetRadio()
        {
            Console.WriteLine("Radio on");
        }
        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine("Volume: {0}", _volume);
        }
    }
}