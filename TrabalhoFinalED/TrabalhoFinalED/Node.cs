using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalED
{
    public class Node
    {
        public int Id { get; set; }
        public double Distance { get; set; }
        public Node Previous { get; set; }

        public string Name { get; set; }
        public bool Visited { get; set; }
        public Color color { get; set; }

        public List<Tuple<Node, int>> neighbours = new List<Tuple<Node, int>>();
        public void AddNeighbour(Node node, int weight)
        {
            neighbours.Add(new Tuple<Node, int>(node, weight));
        }
        public int X { get; set; }
        public int Y { get; set; }

        public Node(int id, int x, int y, string name)
        {
            Id = id;
            Distance = double.PositiveInfinity;
            Previous = null;
            X = x;
            Y = y;
            color = Color.DarkCyan;
            Name = name;
            Visited = false;
        }

        public Node(int id, int x, int y, Color color, string name)
        {
            Id = id;
            Distance = double.PositiveInfinity;
            Previous = null;
            X = x;
            Y = y;
            this.color = color;
            Name = name;
            Visited = false;
        }
    }
}
