namespace MarsRover
{
    interface ICommand
    {
        //Выполнить команду
        void Execute();

        //Отменить команду
        void Undo();
    }
}