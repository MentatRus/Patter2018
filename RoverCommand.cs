namespace MarsRover
{
    class RoverCommand : ICommand
    {
        //Направление движения
        private char direction;

        //Марсоход-исполнитель
        private Rover rover;

        //Конструктор команды
        public RoverCommand(char direction, Rover rover)
        {
            this.direction = direction;
            this.rover = rover;
        }

        //Выполнить команду
        public void Execute()
        {
            switch (direction)
            {
                //Влево
                case 'l':
                    rover.X--;
                    break;
                //Вправо
                case 'r':
                    rover.X++;
                    break;
                //Вверх
                case 'u':
                    rover.Y++;
                    break;
                //Вниз
                case 'd':
                    rover.Y--;
                    break;
            }
            //Добавить в стек команд
            rover._commands.Push(this);
            //Опубликовать изменения
            rover.NotifyAllObservers();
        }

        //Отмена команды
        public void Undo()
        {
            switch (direction)
            {
                //Отмена команды влево
                case 'l':
                    rover.X++;
                    break;
                //Отмена команды вправо
                case 'r':
                    rover.X--;
                    break;
                //Отмена команды вверх
                case 'u':
                    rover.Y--;
                    break;
                //Отмена команды вниз
                case 'd':
                    rover.Y++;
                    break;
            }
            //Отправляет уведомления всем подписчикам
            rover.NotifyAllObservers();
        }
    }
}