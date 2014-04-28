using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using DrawingColor = System.Drawing.Color;

namespace S04
{
    enum Color { White, Gray, Black };

    class Graph<T>
        where T : new()
    {
        /// <summary>
        /// Список всех вершин графа
        /// </summary>
        private List<Node<T>> nodes { get; set; }

        public Node<T> this[int index]
        {
            get { return nodes[index]; }
        }

        public int Count { get { return nodes.Count; } }

        public IEnumerable<Node<T>> Nodes
        {
            get
            {
                foreach (var n in nodes) yield return n;
            }
        }

        

        /// <summary>
        /// Создает объект класса Graph
        /// </summary>
        public Graph(int verticesCount)
        {
            nodes = new List<Node<T>>();
            for (int i = 0; i < verticesCount; i++)
                nodes.Add(new Node<T>(i));
        }
    }

    class AdditionalInfo
    {
        public Color Color { get; set; }
    }

    class Node<T>
        where T : new()
    {
        public int Index { get; private set; }

        public T Info { get; private set; }


        /// <summary>
        /// Список вершин, инцидентных данной
        /// </summary>
        public List<Node<T>> Neighbours { get; private set; }
        
        public Node(int index)
        {
            Neighbours = new List<Node<T>>();
            this.Index = index;
            this.Info = new T();
        }
    }



    class Program
    {


        static void MainX(string[] args)
        {
            var graph = new Graph<AdditionalInfo>(5);
            
        }
    }
}
