using System;
using System.Collections.Generic;
using System.Text;

namespace SwDD2_BinarySearchTree
{
    delegate void CallbackFunction(object value);

    class BinarySearchTree<TValue, TKey> where TKey : IComparable
    {
        class BSTNode
        {
            public TValue value;
            public TKey key;
            public BSTNode leftChild;
            public BSTNode rightChild;

        }


        BSTNode root;

        public void Insert(TValue newValue, TKey newKey)
        {
            BSTNode NewNode = new BSTNode();
            NewNode.value = newValue;
            NewNode.key = newKey;
            NewNode.leftChild = null;
            NewNode.rightChild = null;

            Insert(NewNode, ref root);

        }
        private void Insert(BSTNode newNode, ref BSTNode currentRoot)
        {
            if (currentRoot == null)
            {   
                currentRoot = newNode;
            }
            else
            {
                if (currentRoot.key.CompareTo(newNode.key) < 0)
                {
                    Insert(newNode, ref currentRoot.rightChild);
                }
                else if (currentRoot.key.CompareTo(newNode.key) > 0)
                {
                    Insert(newNode, ref currentRoot.leftChild);
                }
                else
                {
                    throw new Exception("The key is already used");
                }
            }
        }


        public void Remove(TKey key)
        {
            Remove(key, ref root);
        }

        private void Remove(TKey key, ref BSTNode currentRoot)
        {
            if (currentRoot != null)
            {

                if (currentRoot.key.CompareTo(key) < 0)
                {
                    Remove(key, ref currentRoot.rightChild);    // search key on the right side
                }

                else if (currentRoot.key.CompareTo(key) > 0)
                {
                    Remove(key, ref currentRoot.leftChild);     // search key on the right side
                }

                else if (currentRoot.key.CompareTo(key) == 0)     // key found
                {
                    // it has no child
                    if (currentRoot.leftChild == null && currentRoot.rightChild == null)
                    {
                        currentRoot = null;
                    }

                    // it has only one child
                    else if (currentRoot.leftChild == null)
                    {
                        currentRoot = currentRoot.rightChild;
                    }
                    else if (currentRoot.rightChild == null)
                    {
                        currentRoot = currentRoot.leftChild;
                    }
                    // it has 2 children
                    else
                    {
                        RemoveWithTwoChildren(currentRoot, ref currentRoot.leftChild);
                    }
                }
            }
            else
            {
                throw new Exception("There is no element with that key.");
            }
        }


        private void RemoveWithTwoChildren(BSTNode nodeToRemove, ref BSTNode replacementNode)
        {
            if (replacementNode.rightChild != null)
            {
                RemoveWithTwoChildren(nodeToRemove, ref replacementNode.rightChild);
            }
            else
            {
                nodeToRemove.value = replacementNode.value;
                nodeToRemove.key = replacementNode.key;
                replacementNode = replacementNode.leftChild;
            }


        }


        public void InOrderTraversal(CallbackFunction callback)
        {
            InOrderTraversal(root, callback);
        }

        private void InOrderTraversal(BSTNode currentRoot, CallbackFunction callback)
        {
            if (currentRoot != null)
            {
                InOrderTraversal(currentRoot.leftChild, callback);
                // Console.WriteLine("Node reached: " + currentRoot.value);
                callback?.Invoke(currentRoot.value);
                InOrderTraversal(currentRoot.rightChild, callback);

            }

        }
    }
}
