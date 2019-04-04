using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    
    // tree class hold the root node of the tree, and provide operations
    class MyBinaryTree
    {
        public enum TraversalOrder
        {
            PreOrder,
            InOrder,
            PostOrder
        }
        public MyBinaryTreeNode Root;

        public MyBinaryTree ()
        {
            this.Root = null;
        }

        // Method: Cut
        // Description: Search for the given element and cut the tree. 
        //              The given element become the root of the new tree
        // Parameters: 
        //    element: the element to cut from
        // Return value: 
        //    return the new tree
        public MyBinaryTree Cut (MyBinaryTreeNode element)
        {
            MyBinaryTree subTree = new MyBinaryTree();

            

            return subTree;
        }

        // Method: Search
        // Description: Search for the given value and return the first node found,
        // Parameters: 
        //    value: the value of node to be searched
        // Return value: 
        //    return the first node found, or null
        public MyBinaryTreeNode Search(int value)
        {
            MyBinaryTreeNode nodeFound = null;

            // Challenge for student

            // ...
            // Write your code here
            // ...

            return nodeFound;
        }


        public void Traversal (TraversalOrder order)
        {
            switch (order)
            {
                case TraversalOrder.PreOrder:
                    TraversalPreOrder(this.Root);
                    break;
                case TraversalOrder.InOrder:
                    TraversalInOrder(this.Root);
                    break;
                case TraversalOrder.PostOrder:
                    TraversalPostOrder(this.Root);
                    break;
                default:
                    break;
            }
            Console.Write("\n");
            return;
        }

        // Method: TraversalPreOrder
        // Description: Traversal the tree using PreOrder
        private void TraversalPreOrder(MyBinaryTreeNode node)
        {
            if (node != null)
            {
                Console.Write($"{node.Data} -> ");
                TraversalPreOrder(node.Left);
                TraversalPreOrder(node.Right);
            }
            return;
           
        }

        // Method: TraversalInOrder
        // Description: Traversal the tree using InOrder
        private void TraversalInOrder(MyBinaryTreeNode node)
        {
            if (node != null)
            {
                TraversalInOrder(node.Left);
                Console.Write($"{node.Data} -> ");
                TraversalInOrder(node.Right);
            }
            return;
        }

        // Method: TraversalPostOrder
        // Description: Traversal the tree using PostOrder
        private void TraversalPostOrder(MyBinaryTreeNode node)
        {

            // Challenge for student

            // ...
            // Write your code here
            if (node != null)
            {
                TraversalPostOrder(node.Left);
                TraversalPostOrder(node.Right); // I did this :)
                Console.Write($"{node.Data} ->");
            }
            // ...

            return;
        }

        // Method: Dump
        // Description: Dump the tree by calling PrintTree against root
        public void Dump()
        { 
            this.PrintTree(this.Root, 0);
            return;
        }

        // Method: PrintTree
        // Description: Print a tree using following format
        //    ──  Root  1
        //          └──  left   2
        //                  ├──  left   4
        //                  │    ├──  left   null
        //                  │    └──  right  10
        //                  │         ├──  left   null
        //                  │         └──  right  null
        //                  └──  right  5
        //                       ├──  left   null
        //                       └──  right  null
        // Parameters: 
        //      node:   root node of subtree
        //      role:   0 - root; -1 - left; 1 - right
        //      indent: indicate the level of tree, no need to set this 
        private void PrintTree(MyBinaryTreeNode node, int role, string indent = "")
        {
            string prefix = "";
            switch (role)
            {
                case 0: // root node
                    prefix = "──  Root ";
                    break;
                case -1: // left node
                    prefix = indent + "├──  left  ";
                    break;
                case 1: // right node
                    prefix = indent + "└──  right ";
                    break;
                default:
                    break;
            }
            if (role != 0)
            {
                Console.WriteLine($"{indent}│");
            }
            if (node == null)
            {
                Console.WriteLine($"{prefix} null");
            }
            else
            {
                Console.WriteLine($"{prefix} {node.Data}");
                string padding = (role == -1) ? "│    " : "     ";

                this.PrintTree(node.Left, -1, indent + padding);
                this.PrintTree(node.Right, 1, indent + padding);
            }
            
            //log.debug(prefix + nodeConnection + nodeName);
            return;
        }
    }


    // Node of tree
    class MyBinaryTreeNode
    {
        public int Data;
        public MyBinaryTreeNode Left;
        public MyBinaryTreeNode Right;

        public MyBinaryTreeNode()
        {
            this.Data = 0;
            this.Left = null;
            this.Right = null;
        }
        public MyBinaryTreeNode(int value)
        {
            this.Data = value;
            this.Left = null;
            this.Right = null;
        }
    }
}
