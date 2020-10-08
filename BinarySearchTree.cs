using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BinarySearchTree
    {
        public Nodes root;

        public BinarySearchTree()
        {
            root = null; 
        }


        public void Insert (Nodes newNode)
        {
            if (root == null)
            {
                root = newNode;

            }
            else
            {
                Nodes CurrentNode = root;
                if(newNode.data > CurrentNode.data)
                {
                    if(CurrentNode.right == null)
                    {
                        CurrentNode.right = newNode;
                    }
                    else
                    {
                        CurrentNode = CurrentNode.right;
                    }
                    
                }
                else if (newNode.data < CurrentNode.data)
                {
                    if(CurrentNode.left == null)
                    {
                        CurrentNode.left = newNode; 
                    }
                    else
                    {
                        CurrentNode = CurrentNode.left; 
                    }
                }
            }
            
        }
        public bool Search(Nodes nodes, int search)
        {

            if (nodes == null)
            {
                return false;
            }
            else if (search < nodes.data)
            {
                return Search(nodes.left, search);

            }
            else if (search > nodes.data)
            {
                return Search(nodes.right, search);
            }
            else return true;  
        }
        
    }
}
