using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using DrawingColor = System.Drawing.Color;

namespace S03
{
    enum Color { White, Gray, Black };

    class Graph
    {
        /// <summary>
        /// Список всех вершин графа
        /// </summary>
        private List<Node> nodes { get; set; }

        public Node this[int index]
        {
            get { return nodes[index]; }
        }

        public int Count { get { return nodes.Count; } }

        public IEnumerable<Node> Nodes
        {
            get
            {
                foreach (var n in nodes) yield return n;
            }
        }

        public Node this[string name]
        {
            get { return Nodes.Where(z => z.Name == name).First(); }
        }

        /// <summary>
        /// Создает объект класса Graph
        /// </summary>
        public Graph(int verticesCount)
        {
            nodes = new List<Node>();
            for (int i = 0; i < verticesCount; i++)
                nodes.Add(new Node(i));
        }
    }


    class Node
    {
        public int Index { get; private set; }

        public Color Color { get; set; }

        DrawingColor DrawingColor { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Список вершин, инцидентных данной
        /// </summary>
        public List<Node> Neighbours { get; private set; }
        
        public Node(int index)
        {
            Neighbours = new List<Node>();
            this.Index = index;
        }
    }



    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g">Граф который надо обойти</param>
        static void BreadthSearch(Graph g)
        {
            var node=g[4];
        }

        
    }
}
