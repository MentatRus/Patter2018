using System.Collections.Generic;

namespace MarsRover
{
    class Rover
    {
        public int X = 0;
        public int Y = 0;
        public Stack<RoverCommand> _commands = new Stack<RoverCommand>();
        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}