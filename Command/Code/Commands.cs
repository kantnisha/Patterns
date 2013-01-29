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

    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.CHigh:
                    _ceilingFan.High();
                    break;
                case CeilingFan.CMedium:
                    _ceilingFan.Medium();
                    break;
                case CeilingFan.CLow:
                    _ceilingFan.Low();
                    break;
                default:
                    _ceilingFan.Off();
                    break;
            }
        }
    }

    public class MacroCommand : ICommand
    {
        private ICommand[] _commands;
        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            Console.WriteLine("---Pushing Macro On---");
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
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
}