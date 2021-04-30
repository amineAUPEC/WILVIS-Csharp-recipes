using System;

public class Player
{
  public string Materials { get; set; }
    // Constructor that takes no arguments:
    public Player()
    {
        // Materials = "unknown";
    }

    // Constructor that takes one argument:
    public Player(string materials)
    {
        Materials = materials;
    }

    // Auto-implemented readonly property:
    // public string Materials { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Materials;
    }
}