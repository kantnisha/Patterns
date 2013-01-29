using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.Code;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var stereo = new Stereo();
            var stereoOn = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffWithCDCommand(stereo);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(2, stereoOn, stereoOff);
            remote.OnButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OnButtonWasPushed(2);

            remote.OffButtonWasPushed(0);
            remote.OffButtonWasPushed(1);
            remote.OffButtonWasPushed(2);

            remote.UndoButtonWasPushed();

            Console.ReadKey();
        }
    }
}
