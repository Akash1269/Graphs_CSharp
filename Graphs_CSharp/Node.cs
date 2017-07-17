using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs_CSharp
{
    class Node
    {
        public int data { get; set; }
        public List<Node> adjecents { get; set; }

        public Node(int j)
        {
            data = j;
            adjecents = new List<Node>();
        }

    }
}
