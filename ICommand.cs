namespace MarsRover
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}