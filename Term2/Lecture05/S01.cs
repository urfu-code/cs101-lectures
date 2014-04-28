using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01
{

    class Graph
    {
        /// <summary>
        /// Список всех вершин графа
        /// </summary>
        public List<Node> Nodes { get; private set; }

        /// <summary>
        /// Создает объект класса Graph
        /// </summary>
        public Graph(int verticesCount)
        {
            Nodes = new List<Node>();
            for (int i = 0; i < verticesCount; i++)
                Nodes.Add(new Node(i));
        }
    }

    class Node
    {
        public int Index { get; private set; }
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
        }
    }
}
