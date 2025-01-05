using System;

namespace ObserverDataModel;

public class UIElement : IObserver
{
    private string _name;

    public UIElement(string name)
    {
        _name = name;
    }
    public void Update(DataModel data)
    {
        // Update the UI element based on model data
        Console.WriteLine("UI Element " + _name + " update with data: " + data.Data);
    }

}
