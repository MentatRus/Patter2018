/*----------------------------------------------
 * ProjectType: Win32 Console Application
 * Project Name: Mars Rover
 * File Name: Program.cs
 * Programmer: Dolgopolov Nickolay
 * Modified by: Dolgopolov Nickolay
 * Liter Source: refactoring.guru/ru/design-patterns/catalog
 * Created:29.05.2018
 * Last Revision: 30.05.2018
 * Comments: Демонстрация паттернов Command, Observer и Facade
 ***********************************************/

using System;
namespace MarsRover
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            //Создание экземпляра фасадного класса, инкапсулирующего логику программы
            RoverFacade facade = new RoverFacade();

            //Чтение ввода пользователя
            while (true)
            {
                string input = Console.ReadLine();
                facade.ExecuteCommand(input);

            }
        }
    }
}