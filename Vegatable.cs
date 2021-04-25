using System;

public class Vegetable
{
    // Constructor that takes no arguments:
    public Vegetable()
    {
        materials = "todefine";
    }

    // Constructor that takes one argument:
    public Vegetable(string materials)
    {
        materials = materials;
    }

    // Auto-implemented readonly property:
    public string materials { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return materials;
    }
}
class TestVegetable
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        var Vegetable1 = new Vegetable();
        Console.WriteLine(Vegetable1.materials);

        // Call the constructor that has one parameter.
        var Vegetable2 = new Vegetable("Parsley");
        Console.WriteLine(Vegetable2.materials);
        var Vegetable2 = new Vegetable("Beets");
        Console.WriteLine(Vegetable2.materials);
        // Get the string representation of the Vegetable2 instance.
        Console.WriteLine(Vegetable2);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
// Output:
// unknown
// Sarah Jones
// Sarah Jones