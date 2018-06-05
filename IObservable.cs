namespace MarsRover
{
    public interface IObservable
    {
        //Добавляет наблюдателя
        void AddObserver(IObserver observer);

        //Удаляет наблюдателя
        void RemoveObserver(IObserver observer);

        //Оповещает всех наблюдателей
        void NotifyAllObservers();
    }
}