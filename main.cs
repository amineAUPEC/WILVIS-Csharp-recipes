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
        // dish numb 1rst
        
        var recipes2 = new Recipes("Oregano","Biryani", "10" );
        Console.WriteLine(recipes2.Materials);
        Console.WriteLine(recipes2.Dishname);
        Console.WriteLine(recipes2.Quantities);


        int key1= Int32.Parse(recipes2.Quantities);



        var recipes2_2 = new Recipes("Coriander","Biryani", "5" );
        Console.WriteLine(recipes2_2.Materials);
        Console.WriteLine(recipes2_2.Dishname);
        Console.WriteLine(recipes2_2.Quantities);
        int key2= Int32.Parse(recipes2_2.Quantities);  

        
        // dish numb 2nd
        
        var recipes3 = new Recipes("paneer","palak paneer", "8" );
        Console.WriteLine(recipes3.Materials);
        Console.WriteLine(recipes3.Dishname);
        Console.WriteLine(recipes3.Quantities);


        int key3= Int32.Parse(recipes3.Quantities);


        
        var recipes3_2 = new Recipes("butter","palak paneer", "5" );
        Console.WriteLine(recipes3_2.Materials);
        Console.WriteLine(recipes3_2.Dishname);
        Console.WriteLine(recipes3_2.Quantities);


        int key4= Int32.Parse(recipes3_2.Quantities);
        
        
        
        
        // dish numb 3th
        var recipes4 = new Recipes("paneer","paneer dosai", "7" );
        Console.WriteLine(recipes4.Materials);
        Console.WriteLine(recipes4.Dishname);
        Console.WriteLine(recipes4.Quantities);


        int key5= Int32.Parse(recipes4.Quantities);


        
        var recipes4_2 = new Recipes("flour","paneer dosai", "5" );
        Console.WriteLine(recipes4_2.Materials);
        Console.WriteLine(recipes4_2.Dishname);
        Console.WriteLine(recipes4_2.Quantities);


        int key6= Int32.Parse(recipes4_2.Quantities); 
        
        var recipes4_3 = new Recipes("onion","paneer dosai", "1" );
        Console.WriteLine(recipes4_3.Materials);
        Console.WriteLine(recipes4_3.Dishname);
        Console.WriteLine(recipes4_3.Quantities);


        int key7= Int32.Parse(recipes4_3.Quantities);



        // cast string to int csharp

        Console.WriteLine("Ingredients is : "+ recipes2.Materials+ " dishname : "+ recipes2.Dishname+ " quantities : "+ recipes2.Quantities );
        Console.WriteLine("Ingredients is : "+ recipes3.Materials+ " dishname : "+ recipes3.Dishname+ " quantities : "+ recipes3_2.Quantities );
        Console.WriteLine("Ingredients is : "+ recipes3_2.Materials+ " dishname : "+ recipes3_2.Dishname+ " quantities : "+ recipes3_2.Quantities );
        Console.WriteLine("Ingredients is : "+ recipes4.Materials+ " dishname : "+ recipes4.Dishname+ " quantities : "+ recipes4.Quantities );
        Console.WriteLine("Ingredients is : "+ recipes4_2.Materials+ " dishname : "+ recipes4_2.Dishname+ " quantities : "+ recipes4_2.Quantities );
        Console.WriteLine("Ingredients is : "+ recipes4_3.Materials+ " dishname : "+ recipes4_3.Dishname+ " quantities : "+ recipes4_3.Quantities );

        // public Recipes(string materials, string dishname, int quantities)


        Console.WriteLine("BinarySearcher Class :");

        BinaryTree binaryTree = new BinaryTree();
        
        binaryTree.Add(key1);
        binaryTree.Add(key2);
        binaryTree.Add(key3);
        binaryTree.Add(key4);
        binaryTree.Add(key5);
        binaryTree.Add(key6);
        binaryTree.Add(key7);

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
        
        binaryTree.Remove(7);
        binaryTree.Remove(8);
        
        Console.WriteLine("PreOrder Traversal After Removing Operation:");
        binaryTree.TraversePreOrder(binaryTree.Root);
        Console.WriteLine();






        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
  }
}