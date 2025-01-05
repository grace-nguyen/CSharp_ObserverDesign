using System;
using System.Collections.Generic;

namespace ObserverDataModel;

internal class Program
{
    static void Main()
    {
        DataModel dataModel = new DataModel();
        UIElement ui1 = new UIElement("Screen 1");
        UIElement ui2 = new UIElement("Screen 2");

        // Register UIElements as observers of DataModel
        dataModel.Attach(ui1);
        dataModel.Attach(ui2);

        // Change the data in DataModel, which will notify all observers
        Console.WriteLine("Changing data in DataModel...");
        dataModel.Data = "Hello, World!";

        // Unregister one of the UIElements
        dataModel.Detach(ui1);

         // Change the data in DataModel, which will notify all observers
        Console.WriteLine("Changing data in DataModel...");
        dataModel.Data = "New data";
    }
}