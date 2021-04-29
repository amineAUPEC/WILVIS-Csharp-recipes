using System;
using System.Collections.Generic;

class MainClass {
    // static void Main()
  public static void Main (string[] args) {
    // Console.WriteLine ("Hello World");
        var vegetable1 = new Vegetable();
        Console.WriteLine(vegetable1.Materials);

        // Call the constructor that has one parameter.
        Console.WriteLine("Vegetable Class :");
        var vegetable2 = new Vegetable("Parsley");
        var vegetable2_1 = new Vegetable("Parsley");
        Console.WriteLine(vegetable2_1.Materials);
        var vegetable2_2 = new Vegetable("Beets");
        Console.WriteLine(vegetable2_2.Materials);
        var vegetable2_3 = new Vegetable("Zucchini");
        Console.WriteLine(vegetable2_3.Materials);

        // var vegetableList = new List<Vegetable> { vegetable2_1, vegetable2_2, vegetable2_3 };



        // Get the string representation of the person2 instance.
        Console.WriteLine("Spice Class :");
        Console.WriteLine(vegetable2);
        var spice2_1 = new Spice("Oregano");
        Console.WriteLine(spice2_1.Materials);
        var spice2_2 = new Spice("Pepper");
        Console.WriteLine(spice2_2.Materials);
        var spice2_3 = new Spice("Coriander");
        Console.WriteLine(spice2_3.Materials);


        // var spiceList = new List<Spice> { spice2_1, spice2_2, spice2_3 };


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
        Console.WriteLine("Ingredients is : "+ recipes2_2.Materials+ " dishname : "+ recipes2_2.Dishname+ " quantities : "+ recipes2_2.Quantities );
        Console.WriteLine("Ingredients is : "+ recipes3.Materials+ " dishname : "+ recipes3.Dishname+ " quantities : "+ recipes3.Quantities );
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


      // at the start of the competition

      //  int []  n = new int[5] { 1, 2, 3, 4, 5 }; /* n is an array of 10 integers */
      //  string []  n = new int[5] { 1, 2, 3, 4, 5 }; /* n is an array of 10 integers */
         
      //    /* output each array element's value */
      //    foreach (int j in n ) {
      //       int i = j-100;
      //       Console.WriteLine("Element[{0}] = {1}", i, j);
      //    }

        // for (j = 0; j < 10; j++ ) {
        //     Console.WriteLine("Element[{0}] = {1}", j, n[j]);
        //  }


      //  foreach (int j in n ) {
      // {
      //       int i = j-100;

      //     Console.WriteLine("Element[{0}] = {1}", i, j);

      //     // System.Console.Write("{0} ", i);
      // }



            // int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // // Or use the short form:
            // // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            // foreach (int i in numbers2D)
            // {
            //     System.Console.Write("{0} ", i);
// }
        

        // Console.WriteLine("2 random ingredients from vegetable2_x and integers between 0 and 3 :");
        // for (int i = 0; i < vegetableList.Count; i++)
        // {
        //     vegetableList[i].Value++;
        // }


      //  var _var1 = new ValueStorage() { Value = 0 };
      //       var _var2 = new ValueStorage() { Value = 1 };
      //       var _var3 = new ValueStorage() { Value = 2 };

      //       var varList = new List<ValueStorage> { _var1, _var2, _var3 };
      //       for (int i = 0; i < varList.Count; i++)
      //       {
      //           varList[i].Value++;
      //       }

        Console.WriteLine();



        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
  }
}