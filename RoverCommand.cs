namespace MarsRover
{
    class RoverCommand : ICommand
    {
        private char direction;
        private Rover rover;

        public RoverCommand(char direction, Rover rover)
        {
            this.direction = direction;
            this.rover = rover;
        }

        public void Execute()
        {
            switch (direction)
            {
                case 'l':
                    rover.X--;
                    break;
                case 'r':
                    rover.X++;
                    break;
                case 'u':
                    rover.Y++;
                    break;
                case 'd':
                    rover.Y--;
                    break;
            }
            rover._commands.Push(this);
        }

        public void Undo()
        {
            switch (direction)
            {
                case 'l':
                    rover.X++;
                    break;
                case 'r':
                    rover.X--;
                    break;
                case 'u':
                    rover.Y--;
                    break;
                case 'd':
                    rover.Y++;
                    break;
            }
        }
    }
}