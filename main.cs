using System;

class MainClass {
    // static void Main()
  public static void Main (string[] args) {
    // Console.WriteLine ("Hello World");
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