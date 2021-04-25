using System;

public class Vegetable
{
    // Constructor that takes no arguments:
    public Vegetable()
    {
        Materials = "unknown";
    }

    // Constructor that takes one argument:
    public Vegetable(string materials)
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
class TestVegetable
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        var vegetable1 = new Vegetable();
        Console.WriteLine(vegetable1.Materials);

        // Call the constructor that has one parameter.
        var vegetable2 = new Vegetable("Parsley");
        Console.WriteLine(vegetable2.Materials);
        vegetable2 = new Vegetable("Beets");
        Console.WriteLine(vegetable2.Materials);
        vegetable2 = new Vegetable("Zucchini");
        Console.WriteLine(vegetable2.Materials);

        // Get the string representation of the person2 instance.
        Console.WriteLine(vegetable2);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
// Output:
// unknown
// Sarah Jones
// Sarah Jones