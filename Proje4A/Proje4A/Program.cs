using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje4A
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    
        static void DijkstrasShortestPath(int vertex1, int vertex2, int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int[] distances = new int[n];
            Distances(matrix, distances, vertex1);

            for (int i = 0; i < n; ++i)
                if (i == vertex2)
                    Console.Write("Shortest path from " + vertex1 + " to " + vertex2 + " is " + distances[i]);
        }
        static void Distances(int[,] cost, int[] distances, int source)
        {
            int infinity = 1000;
            int w, v, min, n = distances.Length;
            bool[] visited = new bool[n];

            distances[source] = 0;

            for(v = 0; v < n; ++v)
            {
                if(v == source)
                {
                    distances[v] = 0;
                    visited[v] = true;
                }
                else
                {
                    visited[v] = false;
                    distances[v] = cost[source, v];
                }
            }

            for(int i = 0; i < n; ++i)
            {
                min = infinity;
                for (w = 0; w < n; w++)
                    if (!visited[w])
                        if (distances[w] < min)
                        {
                            v = w;
                            min = distances[w];
                        }

                visited[v] = true;

                for (w = 0; w < n; w++)
                    if (!visited[w])
                        if (min + cost[v, w] < distances[w])
                            distances[w] = min + cost[v, w];
            }
        }
        static void BreadthFirstTraverse()
        {

        }
        static void MinSpanningTree()
        {

        }
    }
}
