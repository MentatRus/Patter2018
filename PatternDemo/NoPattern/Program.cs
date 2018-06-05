/*----------------------------------------------
 * ProjectType: Win32 Console Application
 * Project Name: Mars Rover
 * File Name: Program.cs
 * Programmer: Dolgopolov Nickolay
 * Modified by: Dolgopolov Nickolay
 * Liter Source: refactoring.guru/ru/design-patterns/catalog
 * Created:29.05.2018
 * Last Revision: 30.05.2018
 * Comments: Демонстрация работы без паттернов
 ***********************************************/
using System;
using System.IO;
namespace NoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Координаты марсохода
            int x = 0;
            int y = 0;
            //Выбор способа вывода
            Console.WriteLine("Добро пожаловать в программу управления марсоходом.\nВыберите способ вывода координат: 1 для вывода в консоль, 2 - в файл, 3 - оба");
            string outputType = Console.ReadLine();
            Console.WriteLine("Вводите u для перемещения вверх, d - вниз, l - влево, r - вправо");

            //Чтение команд вывода
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 1)
                {
                    char commandDirection = input[0];
                    switch (commandDirection)
                    {
                        //Влево
                        case 'l':
                            x--;
                            break;
                        //Вправо
                        case 'r':
                            x++;
                            break;
                        //Вверх
                        case 'u':
                            y++;
                            break;
                        //Вниз
                        case 'd':
                            y--;
                            break;
                        //Отмена предыдущей команды
                        case 'c':
                            Console.WriteLine("Невозможно отменить команду");
                            break;
                    }
                    //Вывод координат
                    string output = string.Format("({0}, {1})", x, y);
                    if (outputType == "1" || outputType == "3")
                    {
                        //Вывод в консоль
                        Console.WriteLine(output);
                    }
                    if (outputType == "2" || outputType == "3")
                    {
                        //Вывод в файл
                        using (StreamWriter sw = File.AppendText("out.txt"))
                        {
                            sw.WriteLine(output);
                        }
                    }


                }
            }
        }
    }
}
