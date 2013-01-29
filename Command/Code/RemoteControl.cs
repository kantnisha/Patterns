using System.Text;
using Command.Interface;

namespace Command.Code
{
    public class RemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];
            var noCommand = new NoComand();
            for (int i = 0; i < 7; i++)
            {
                _offCommands[i] = noCommand;
                _onCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }
         public void UndoButtonWasPushed()
         {
             _undoCommand.Undo();
         }
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\n----Remote Control----\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] "+ _onCommands[i].GetType().Name +" " + _offCommands[i].GetType().Name + "\n");
            }
            return stringBuilder.ToString();
        }

    }
}