using System;

namespace ObserverDataModel;

public class DataModel : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _data;

    public string Data 
    { 
        get { return _data; }
        set 
        {
            _data = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify() 
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}
