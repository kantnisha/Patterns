using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.Code;
using Command.Interface;

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
            var ceilingFan = new CeilingFan("Living Room");
            var ceilingFanHighOn = new CeilingFanHighCommand(ceilingFan);

            var macro = new MacroCommand(new ICommand[] {lightOn, stereoOn});

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(2, stereoOn, stereoOff);
            remote.SetCommand(3, ceilingFanHighOn, new NoComand());
            remote.SetCommand(4, macro, new NoComand());
            remote.OnButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            

            remote.OffButtonWasPushed(0);
            remote.OffButtonWasPushed(1);
            remote.OffButtonWasPushed(2);

            remote.UndoButtonWasPushed();

            remote.OnButtonWasPushed(3);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(4);
            remote.UndoButtonWasPushed();

            Console.ReadKey();
        }
    }
}
