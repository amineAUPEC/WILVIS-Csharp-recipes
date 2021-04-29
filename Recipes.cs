using System;

public class Recipes
{
    // Constructor that takes no arguments:
    public Recipes()
    {
        // Materials = "unknown";
    }

    // Constructor that takes one argument:
    public Recipes(string materials, string dishname, int quantities)
    {
        Materials = materials;
        Dishname = dishname;
        Quantities = quantities;
    }

    // Auto-implemented readonly property:
    public string Materials { get; }
    public string Dishname { get; }
    public string Quantities { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Materials;
        return Dishname;
    }
}


// • Create recipes for some dish to be prepared. The recipes include the name of the dish, 
// the ingredients and the quantities needed.


//  name, the ingredients and the quantities needed.