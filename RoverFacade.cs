using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

    //Система управления марсоходом
    class RoverFacade
    {
        //Экземпляр марсохода
        public Rover rover;

        //Конструктор по умолчанию
        public RoverFacade()
        {
            this.rover = new Rover();
            //Выбор режима вывода данных (консоль/файл/оба)
            Initialize();
        }

        //Задает настройки вывода, подписывая нужных наблюдателей
        public void Initialize()
        {
            Console.WriteLine("Добро пожаловать в программу управления марсоходом.\nВыберите способ вывода координат: 1 для вывода в консоль, 2 - в файл, 3 - оба");
            string input = Console.ReadLine();
            if(input == "1" || input == "3")
            {
                //Добавить наблюдателя для вывода в консоль
                var consoleObserver = new ConsoleCoordinatesObserver();
                rover.AddObserver(consoleObserver);
            }
            if (input == "2" || input == "3")
            {
                //Добавить наблюдателя для вывода в файл
                var fileObserver = new FileCoordinatesObserver();
                rover.AddObserver(fileObserver);
            }
            Console.WriteLine("Вводите u для перемещения вверх, d - вниз, l - влево, r - вправо");

        }

        //Выполняет введенную команду
        public void ExecuteCommand(string input)
        {
            if (input.Length == 1)
            {
                char commandDirection = input[0];
                //Отмена последней команды
                if (commandDirection == 'c')
                {
                    //Если стек команд не пуст
                    if (rover._commands.Count != 0)
                    {
                        //Взять и удалить последнюю команду из стека
                        ICommand c = rover._commands.Pop();
                        //Отменить эту команду
                        c.Undo();
                    }
                }
                else
                {
                    //Создать новую команду на передвижение
                    var command = new RoverCommand(commandDirection, rover);
                    //Выполнить ее
                    command.Execute();
                }
            }
        }
    }
}
