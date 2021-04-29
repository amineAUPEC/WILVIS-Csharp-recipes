using System;

namespace SwDD2_BinarySearchTree
{


    class Program
    {
        static void WriteToScreen(object obj)
        {
            Console.WriteLine(obj as string);
            Console.Beep(1000, 100* int.Parse(obj as string));
        }
        static void Main(string[] args)
        {
            // Since TTKey has to implement the compareto because it implements the IComparable interface, the second paramater has to implement the function compareto
            BinarySearchTree<string, int> myBST = new BinarySearchTree<string, int>();
            myBST.Insert("9", 9);
            myBST.Insert("4", 4);
            myBST.Insert("12", 12);
            myBST.Insert("2", 2);
            myBST.Insert("5", 5);
            myBST.Insert("11", 11);
            myBST.Insert("16", 16);
            myBST.Insert("10", 10);
            myBST.Insert("14", 14);

            myBST.InOrderTraversal(WriteToScreen);

            myBST.Remove(9);

            Console.WriteLine("After removal");
            myBST.InOrderTraversal(WriteToScreen);


            BinarySearchTree<string, int> myBST2 = new BinarySearchTree<string, int>();

        }
    }
}
