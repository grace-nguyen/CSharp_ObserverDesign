# Practice Challenge: Observer Pattern
## Problem: 
You have an application that needs to update multiple user interface elements when a data model changes.

### Current Code:

```csharp
public class DataModel
{
    public string Data { get; set; }
}

public class UIElement //Screen
{
    public void Update(DataModel data)
    {
        // Update UI based on model data
    }
}
`
## Task: 
Refactor the DataModel and UIElement classes to use the Observer pattern, where UIElement observes changes in DataModel.