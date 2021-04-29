using System;

class MainClass {
    // static void Main()
  public static void Main (string[] args) {
    // Console.WriteLine ("Hello World");
        var vegetable1 = new Vegetable();
        Console.WriteLine(vegetable1.Materials);

        // Call the constructor that has one parameter.
        Console.WriteLine("Vegetable Class :");
        var vegetable2 = new Vegetable("Parsley");
        Console.WriteLine(vegetable2.Materials);
        vegetable2 = new Vegetable("Beets");
        Console.WriteLine(vegetable2.Materials);
        vegetable2 = new Vegetable("Zucchini");
        Console.WriteLine(vegetable2.Materials);

        // Get the string representation of the person2 instance.
        Console.WriteLine("Spice Class :");
        Console.WriteLine(vegetable2);
        var spice2 = new Spice("Oregano");
        Console.WriteLine(spice2.Materials);
        spice2 = new Spice("Pepper");
        Console.WriteLine(spice2.Materials);
        spice2 = new Spice("Coriander");
        Console.WriteLine(spice2.Materials);

        Console.WriteLine("Recipes Class :");
        var recipes2 = new Recipes("Oregano","Biryani", "10" );
        Console.WriteLine(recipes2.Materials);
        Console.WriteLine(recipes2.Dishname);
        Console.WriteLine(recipes2.Quantities);


        int key1= Int32.Parse(recipes2.Quantities);
        recipes2 = new Recipes("Oregano","Biryani", "5" );
        Console.WriteLine(recipes2.Materials);
        Console.WriteLine(recipes2.Dishname);
        Console.WriteLine(recipes2.Quantities);


        int key2= Int32.Parse(recipes2.Quantities);



        // cast string to int cshrap

        Console.WriteLine("Ingredients is : "+ recipes2.Materials+ " dishname : "+ recipes2.Dishname+ " quantities : "+ recipes2.Quantities );

        // public Recipes(string materials, string dishname, int quantities)


        Console.WriteLine("BinarySearcher Class :");

        BinaryTree binaryTree = new BinaryTree();
        
        binaryTree.Add(key1);
        binaryTree.Add(key2);

        Node node = binaryTree.Find(5);
        int depth = binaryTree.GetTreeDepth();
        
        Console.WriteLine("PreOrder Traversal:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine();
        
        Console.WriteLine("InOrder Traversal:");
        binaryTree.TraverseInOrder(binaryTree.Root);
        Console.WriteLine();
        
        Console.WriteLine("PostOrder Traversal:");
        binaryTree.TraversePostOrder(binaryTree.Root);
        Console.WriteLine();
        
        // binaryTree.Remove(7);
        // binaryTree.Remove(8);
        
        Console.WriteLine("PreOrder Traversal After Removing Operation:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine();






        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
  }
}