using System.Diagnostics;

namespace MapSearch
{
    public class Node
    {
        public Node LeftChild;
        public Node RightChild;
        public float top;
        public float bottom;
        public float right;
        public float left;

        public Node(float top, float bottom, float right, float left)
        {
            this.top = top;
            this.bottom = bottom;
            this.right = right;
            this.left = left;
        }
    }
}