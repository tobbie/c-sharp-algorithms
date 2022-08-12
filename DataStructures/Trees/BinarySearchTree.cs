using static System.Console;

namespace DataStructures.Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
       // private Node _currentNode { get;set; }
       
        public BinarySearchTree()
        {
            this.Root = null;
            this.Insert(9);
            this.Insert(4);
            this.Insert(6);
            this.Insert(20);
            this.Insert(170);
            this.Insert(15);
            this.Insert(1);
        }

        public Node Insert(int value) {
            var newNode = new Node(value);

            if (this.Root == null){
                this.Root = newNode;
                return Root;
            }
           else{
               var currentNode = this.Root;
                while (true) {
                    if (newNode.Value < currentNode.Value)
                    {
                       
                        //go left
                        
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = newNode;
                            return this.Root;
                        }
                        currentNode = currentNode.Left;
                       
                    }
                    else
                    {
                        //go right
                        if (currentNode.Right == null) {
                            currentNode.Right = newNode;
                            return this.Root;
                        }
                        currentNode = currentNode.Right;

                    }

                }
            }

           

        
        }

        private Node InsertLeft(Node node) {

            return null;
        }

        private Node InsertRight(Node node)
        {
            return null;

        }

        public Node Lookup(int value) {
            //get currentNode
            var currentNode = this.Root;
            while (currentNode != null) {

                if (currentNode.Value == value)
                    return currentNode;
                else {
                    //traverse
                    if (value < currentNode.Value)
                    {
                        currentNode = currentNode.Left;
                    }
                    else {
                        currentNode = currentNode.Right;
                    }
                }
                
            }
            return null;
        }

        public void PreOrderTraversal(Node root) {
            if (root == null)
                return;
            WriteLine($"Preorder Traversal at node {root.Value}");
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }
    }

    public class Node {

        public Node Left;
        public Node Right;
        public int Value;

        public Node(int value) {
            this.Value = value;
        }
    }
}
