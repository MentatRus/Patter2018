using System;

namespace MarsRover
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Rover rover = new Rover();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char commandDirection = input[0];
                    if (commandDirection == 'c')
                    {
                        if (rover._commands.Count != 0)
                        {
                            ICommand c = rover._commands.Pop();
                            c.Undo();
                        }
                    }
                    else
                    {
                        var command = new RoverCommand(commandDirection,rover);
                        command.Execute();
                    }
                }
                Console.WriteLine(rover);

            }
        }
    }
}