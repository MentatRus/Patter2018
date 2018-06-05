using System;
using System.IO;

namespace MarsRover
{
    public interface IObserver
    {
        void HandleEvent(int x, int y);
    }

    //Наблюдатель для вывода в консоль
    public class ConsoleCoordinatesObserver : IObserver
    {
        //Обработчик  события, пишет координаты в консоль 
        public void HandleEvent(int x, int y)
        {
            Console.WriteLine(string.Format("({0}, {1})", x, y));
        }
    }

    //Наблюдатель для вывода в файл
    public class FileCoordinatesObserver : IObserver
    {
        //Адрес файла вывода
        string fileName = "out.txt";


        //Очистка файла при инициализации программы, если он уже сущетсвует
        public FileCoordinatesObserver()
        {
            if (File.Exists("out.txt"))
            {
                File.Delete("out.txt");
            }

        }

        //Обработчик  события, пишет координаты в консоль 
        public void HandleEvent(int x, int y)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(string.Format("({0}, {1})", x, y));
            }
     
        }
    }
}