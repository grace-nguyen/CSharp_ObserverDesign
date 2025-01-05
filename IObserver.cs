using System;

namespace ObserverDataModel;

public interface IObserver
{
    void Update(DataModel data);
}
