using System;
using System.Collections.Generic;

class MainClass {
    // static void Main()
    
  public static void Main (string[] args) {
    // Console.WriteLine ("Hello World");
        var vegetable1 = new Vegetable();
        Console.WriteLine(vegetable1.Materials);

        // Call the constructor that has one parameter.

        //
        Console.WriteLine("Vegetable Class :");
        var vegetable2 = new Vegetable("Parsley");
        // var vegetable2_1 = new Vegetable("Parsley");
        var vegetable2_1 = new Vegetable("Parsley");
        //
        //gene:
        // string vegetable_c = (string)vegetable2_1;
        // var vegetable_b = new Vegetable();
        // var vegetable_a= vegetable2_1;
        // Console.WriteLine("vegetable_a.Materials");
        // Console.WriteLine(vegetable_a.Materials);
        //gen}
        //
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

        //
        // Cat cat = new Cat { Age = 10, Name = "Fluffy" };
        // Cat sameCat = new Cat("Fluffy"){ Age = 10 };

        List<Vegetable> cats = new List<Vegetable>
        {
            // new Vegetable { Materials = "Sylvester"},
            // new Vegetable { Materials = "Whiskers" },
            // new Vegetable { Materials = "Sasha" },
            vegetable2_1,
            vegetable2_2,
            vegetable2_3
        };

        // List<Cat> moreCats = new List<Cat>
        // {
        //     new Cat { Name = "Furrytail", Age = 5 },
        //     new Cat { Name = "Peaches", Age = 4 },
        //     null
        // };

        // Display results.
        // System.Console.WriteLine(cat.Materials);

        foreach (Vegetable c in cats)
            System.Console.WriteLine(c.Materials);
        // foreach (Vegetable c in moreCats)
        //     if (c != null)
        //         System.Console.WriteLine(c.Name);
        //     else
        //         System.Console.WriteLine("List element has null value.");
//
        List<Spice> spicy = new List<Spice>
        {
            spice2_1,
            spice2_2,
            spice2_3
        };

        foreach (Spice d in spicy)
            System.Console.WriteLine(d.Materials);
            



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
         
      //    /* output each array element's value */
      //    foreach (int j in n ) {
      //       int i = j-100;
      //       Console.WriteLine("Element[{0}] = {1}", i, j);
      //    }
         
        //  var abruti= new Vegetable.ToString(string);
        //  Console.WriteLine(abruti);
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
            // var numbers = new List<var>();
            // numbers.Add(vegetable2_a.Materials);
            // numbers.Add(3);
            // numbers.Add(5);
            // numbers.Add(7);
            // Console.WriteLine("LIST 1: " + numbers.Count);
            // List<string> authors = new List<string>(5);  

            // var authors = new List<var>(5);  
            // authors.Add(vegetable2_1);  
            // authors.Add(vegetable2_2);  
            // authors.Add(vegetable2_3);  
            // authors.Add(vegetable2_3);  
            // authors.Add(vegetable2_3);  





            // authors.Add("Naveen Sharma");  
            // authors.Add("Monica Rathbun");  
            // authors.Add("David McCarter");

            // foreach (string a in authors)  
            // Console.WriteLine(a);  


            // var random = new Random();
            // // var list = new List<string>{ "one","two","three","four"};
            // var list = new List<string>{ "one","two","three","four"};
            // // var list = new List<var>{ vegetable2_1};
            // int index = random.Next(list.Count);
            // Console.WriteLine(list[index]);


            // List<MainClass> AuthorList = new List<MainClass>();
            // AuthorList.Add(new Recipes("Mahesh Chand"));

            

        var player_A="false";
        var player_B="false";


        var random = new Random();
        int player_A_qty_1 = random.Next(1,5); 
        int player_A_qty_2 = random.Next(1,3); 
        int player_A_qty_3 = random.Next(1,2); 
        int player_A_qty_4 = random.Next(1,10); 
        int player_A_total = player_A_qty_1 + player_A_qty_2 + player_A_qty_3 + player_A_qty_4 ; 


        Console.WriteLine("player_A_qty_1 "+player_A_qty_1);
        Console.WriteLine("player_A_qty_2 "+player_A_qty_2);
        Console.WriteLine("player_A_qty_3 "+player_A_qty_3);
        Console.WriteLine("player_A_qty_4 "+player_A_qty_4);
        Console.WriteLine("player_A_total "+player_A_total);


        Console.WriteLine("player_B_qty_1 "+player_A_qty_1);
        Console.WriteLine("player_B_qty_2 "+player_A_qty_2);
        Console.WriteLine("player_B_qty_3 "+player_A_qty_3);
        Console.WriteLine("player_B_qty_4 "+player_A_qty_4);
        Console.WriteLine("player_B_total "+player_A_total);

        // List<Main> classy = new List<Main>
        // List<Playerqty> classy = new List<Playerqty>
        // {
        //     player_A_qty_1,
        //     player_A_qty_2,
        //     player_A_qty_3
        // };

        //     foreach (Playerqty d in classy)
        //         System.Console.WriteLine(d);

        // list var
        // shuffle list var and iterate with for or randomly iterate on the list
        //  or reuse player A total
        int index_1 = random.Next(cats.Count);
        int index_2 = random.Next(cats.Count);

        int index_3 = random.Next(spicy.Count);
        int index_4 = random.Next(spicy.Count);
        var unit_measure="";


        if (player_A=="false"){

          
          for (int i = 1; i < 5; i++)
          {
              if (i==1){
                  var player_A_ing_1=cats[index_1].ToString();
                  Console.WriteLine("First ing : "+player_A_ing_1);
                  Console.WriteLine("player_A_qty_1 : "+player_A_qty_1);


                    if (player_A_ing_1=="Parsley" || player_A_ing_1=="Pepper" ){
                        unit_measure="kg";
                    }
                    else if (player_A_ing_1=="Beets" || player_A_ing_1=="Oregano" ) {
                        unit_measure="dkg";
                    }
                    else{
                        unit_measure="€";
                    }

                    Console.WriteLine("First ing : "+player_A_ing_1+" with the amount of : "+player_A_qty_1+" in "+unit_measure);




              }
              else if (i==2){
                  // Console.WriteLine("Index_1 :  "+index_1);
                  // Console.WriteLine("Index_2 :  "+index_2);
                  
                  if (index_1!=index_2){
                    var player_A_ing_2=cats[index_2].ToString();
                    Console.WriteLine("DEBUG : Second ing : "+player_A_ing_2);
                    Console.WriteLine("DEBUG : player_A_qty_2 : "+player_A_qty_2);

                    if (player_A_ing_2=="Parsley" || player_A_ing_2=="Pepper" ){
                        unit_measure="kg";
                    }
                    else if (player_A_ing_2=="Beets" || player_A_ing_2=="Oregano" ) {
                        unit_measure="dkg";
                    }
                    else{
                        unit_measure="€";
                    }

                    Console.WriteLine("Second ing if : "+player_A_ing_2+" with the amount of : "+player_A_qty_2+" in "+unit_measure);




                  }
                  else {
                    var player_A_ing_2="Egg";
                    Console.WriteLine("DEBUG : Second ing : "+player_A_ing_2);
                    Console.WriteLine("DEBUG : player_A_qty_2 : "+player_A_qty_2);


                    if (player_A_ing_2=="Parsley" || player_A_ing_2=="Pepper" ){
                        unit_measure="kg";
                    }
                    else if (player_A_ing_2=="Beets" || player_A_ing_2=="Oregano" ) {
                        unit_measure="dkg";
                    }
                    else{
                        unit_measure="€";
                    }

                    Console.WriteLine("Second ing else : "+player_A_ing_2+" with the amount of : "+player_A_qty_2+" in "+unit_measure);


                  }
                  
              }

              else if (i==3){
                  var player_A_ing_3=spicy[index_3].ToString();
                  Console.WriteLine("Third ing : "+player_A_ing_3);
                  Console.WriteLine("player_A_qty_3 : "+player_A_qty_3);


                    if (player_A_ing_3=="Parsley" || player_A_ing_3=="Pepper" ){
                        unit_measure="kg";
                    }
                    else if (player_A_ing_3=="Beets" || player_A_ing_3=="Oregano" ) {
                        unit_measure="dkg";
                    }
                    else{
                        unit_measure="€";
                    }

                    Console.WriteLine("Third ing if : "+player_A_ing_3+" with the amount of : "+player_A_qty_3+" in "+unit_measure);
              }
              
              else if (i==4){
        
                  if (index_3!=index_4){
                    var player_A_ing_4=spicy[index_4].ToString();
                    Console.WriteLine("Fourth ing : "+player_A_ing_4);
                    Console.WriteLine("player_A_qty_4 : "+player_A_qty_4);

                    if (player_A_ing_4=="Parsley" || player_A_ing_4=="Pepper" ){
                        unit_measure="kg";
                    }
                    else if (player_A_ing_4=="Beets" || player_A_ing_4=="Oregano" ) {
                        unit_measure="dkg";
                    }
                    else{
                        unit_measure="€";
                    }
                    // Console.WriteLine(unit_measure);

                    // Console.WriteLine("Fourth ing if : "+player_A_ing_4+" player_A_qty_4 : "+player_A_qty_4);
                    Console.WriteLine("Fourth ing if : "+player_A_ing_4+" with the amount of : "+player_A_qty_4+" in "+unit_measure);

                  }
                  else {
                    var player_A_ing_4="Tikka";
                    Console.WriteLine("Fourth ing : "+player_A_ing_4);
                    Console.WriteLine("player_A_qty_4 : "+player_A_qty_4);

                    
                    if (player_A_ing_4=="Parsley" || player_A_ing_4=="Pepper" ){
                        unit_measure="kg";
                    }
                    else if (player_A_ing_4=="Beets" || player_A_ing_4=="Oregano" ) {
                        unit_measure="dkg";
                    }
                    else{
                        unit_measure="€";
                    }
                    // Console.WriteLine(unit_measure);
                    // Console.WriteLine("Fourth ing else : "+player_A_ing_4+" player_A_qty_4 : "+player_A_qty_4);
                    Console.WriteLine("Fourth ing : "+player_A_ing_4+" with the amount of : "+player_A_qty_4+" in "+unit_measure);


                  }
              }
          // Console.WriteLine("Fourth x ing : "+player_A_ing_4);

          // if (Selected_A=="Parsley" || Selected_A=="Pepper" ){
          //     unit_measure="kg";
          // }
          // else if (Selected_A=="Beets" || Selected_A=="Oregano" ) {
          //     unit_measure="dkg";
          // }
          // else{
          //     unit_measure="";
          // }



          }
          
        // Console.WriteLine("2 random ingredients from vegetable2_x and integers between 0 and 3 :");
        // for (int i = 0; i < cats.Count; i++)
        // {
        //     cats[i].Value++;
        //     // Console.WriteLine()
        // }








        }

//to do generated a different with while ing is index is different of second index
        Console.WriteLine();


        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
  }
}