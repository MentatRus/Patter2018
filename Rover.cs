using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Rover: IObservable
    {
        //Текущее положение
        public int X = 0;
        public int Y = 0;

        //История команд
        public Stack<RoverCommand> _commands = new Stack<RoverCommand>();

        //Наблюдатели
        private List<IObserver> observers = new List<IObserver>();

        //Строковое представление положения марсохода
        public override string ToString()
        {
            return string.Format("({0}, {1})", X);
        }
        
        //Добавляет наблюдателя
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        //Уведомляет всех наблюдателей
        public void NotifyAllObservers()
        {
            foreach(var observer in observers)
            {
                observer.HandleEvent(X, Y);
            }
        }

        //Убирает наблюдателя
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

    }
}