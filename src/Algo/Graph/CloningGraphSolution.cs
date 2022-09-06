using System;
using Algo.Tree;

namespace Algo.Graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
    

    public class CloningGraphSolution
    {
        Dictionary<Node, Node> _visited = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null)
                return node;

            if (_visited.ContainsKey(node))
            {
                return _visited[node];
            }

            Node clonedNode = new Node(node.val);
            _visited.Add(node, clonedNode);

            foreach (var neighbor in node.neighbors)
            {
                clonedNode.neighbors.Add(CloneGraph(neighbor));
            }
            return clonedNode;
        }
    }
}

