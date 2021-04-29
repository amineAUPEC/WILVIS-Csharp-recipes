using System;

public class Spice
{
    // Constructor that takes no arguments:
    public Spice()
    {
        // Materials = "unknown";
    }

    // Constructor that takes one argument:
    public Spice(string materials)
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