using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Node
    {
       public string data;
       public bool visited;

       public Node(string data)
        {
            this.data = data;
        
        }
    }

    class BreadthFirstAlgorithm
    {
        static Queue<Node> queue = new Queue<Node>();
        static List<Node> nodes = new List<Node>();
        static List<Node> silinenler = new List<Node>();



        static List<Node> findNeighbours(int[,] adjacency_matrix, Node x,List<Node> diziNodes)

        {
            int nodeIndex = -1;

            List<Node> neighbours = new List<Node>();

            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Equals(x))
                {
                    nodeIndex = i;
                    break;
                }
            }

            if (nodeIndex != -1)
            {
                for (int j = 0; j<adjacency_matrix.GetLength(0); j++)   //Komşuları bulan for döngüsü
                {
                    if (adjacency_matrix[nodeIndex, j] == 1)           //İKİ DEFA ÇALIŞMAMA HATASINI DÜZELTMEK İÇİN DİZİ Bİ YERDE BOŞALTILMALI
                                                                        //COUNT 12 OLUYOR DEBUGTA
                    {
                        neighbours.Add(nodes[j]);
                    }
                }
            }
         
            return neighbours;
        }

        public static List<Node> bfs(int[,] adjacency_matrix, Node isim,List<Node> diziNodes)
        {
            //foreach (Node node in diziNodes)
            //{
            //    nodes.Add(node);

            //}

            nodes = diziNodes;
            queue.Enqueue(isim);
            isim.visited = true;
            while (queue.Count>0)
            {

                Node element = queue.Dequeue();
                silinenler.Add(element);
                List<Node> neighbours = findNeighbours(adjacency_matrix, element,nodes);
               

                for (int i = 0; i < neighbours.Count; i++)  //Komşuları queue'ya ekler
                {
                    Node n = neighbours[i];

                    if (n != null && !n.visited)
                    {
                        queue.Enqueue(n); 
                        n.visited = true;

                    }
                }

            }
            return silinenler;
        }
    }
}