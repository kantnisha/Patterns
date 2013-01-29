namespace Command.Interface
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}