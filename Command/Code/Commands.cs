using System;
using Command.Interface;

namespace Command.Code
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }

    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;
        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }

    public class StereoOffWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;
        public StereoOffWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }
    }

    public class NoComand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No commands");
        }

        public void Undo()
        {
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