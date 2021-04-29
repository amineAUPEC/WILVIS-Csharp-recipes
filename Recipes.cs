using System;

public class Spice
{
    // Constructor that takes no arguments:
    public Recipes()
    {
        // Materials = "unknown";
    }

    // Constructor that takes one argument:
    public Recipes(string materials)
    {
        Materials = materials;
    }

    // Auto-implemented readonly property:
    public string Materials { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Materials;
    }
}


// • Create recipes for some dish to be prepared. The recipes include the name of the dish, 
// the ingredients and the quantities needed.