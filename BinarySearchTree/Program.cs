using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        // Constructor for the Node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /* A node class consist of three things, the information,
     * references to the right child, and references to the left child*/

    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /* This Function search the currentnode of the specified Node as well
             as the current Node of this parents*/
            currentNode = ROOT;
            parent = null;
            while((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void insert(string element)/* Insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)/*Check if the node to be inserted already
                                     * inserted or not*/
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /* If the specified node is not present*/
            {
                tmp = new Node(element, null, null); /*creates as Node*/
                if (parent == null) /*if the trees is empty */
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }

        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return ;
            }
            if (ptr != null)
            {
                inorder(ptr.leftchild);
                Console.WriteLine(ptr.info + "");
                inorder(ptr.rightchild);
            }
        }
    }

}
