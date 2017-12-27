using Proje4A;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
     
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             
        }
      
        private void dijkstraButton_Click(object sender, EventArgs e)
        {

            DijkstraAlgorithm algo = new DijkstraAlgorithm();
            algo.add_vertex("John", new Dictionary<string, int> { { "Olivia", 7 }, { "Jack", 9 }, { "Chloe", 7 } });
            algo.add_vertex("Olivia", new Dictionary<string, int> { { "John", 7 }, { "Jack", 4 }, { "Celine", 8 } });
            algo.add_vertex("Celine", new Dictionary<string, int> { { "Olivia", 8 }, { "Jack", 5 }, { "Winston", 6 } });
            algo.add_vertex("Winston", new Dictionary<string, int> { { "Celine", 6 }, { "Jack", 7 }, { "Chloe", 11 } });
            algo.add_vertex("Chloe", new Dictionary<string, int> { { "Winston", 11 }, { "Jack", 5 }, { "John", 7 } });
            algo.add_vertex("Jack", new Dictionary<string, int> { { "Olivia", 4 }, { "John", 9 }, { "Chloe", 5 }, { "Celine", 5 }, { "Winston", 7 } });

            string sonuc = algo.ShortestPath(txtDikstra1.Text, txtDijkstra2.Text);
        
            MessageBox.Show(sonuc);
        }

        private List<Node> DiziNodesOluştur()
        {
           
            List<Node> sonuc = new List<Node>();
            

            Node node1 = new Node("Olivia");
            Node node2 = new Node("John");
            Node node3 = new Node("Chloe");
            Node node4 = new Node("Winston");
            Node node5 = new Node("Celine");
            Node node6 = new Node("Jack");


            List<Node> diziNodes = new List<Node>();

            sonuc.Add(node1);
            sonuc.Add(node2);
            sonuc.Add(node3);
            sonuc.Add(node4);
            sonuc.Add(node5);
            sonuc.Add(node6);

            
            return sonuc;
        }

        private void breadthFirstButton_Click(object sender, EventArgs e)
        {
            string bfs = "";
            Node isimInput = null;
            List<Node> sonucList = new List<Node>();


               
               int[,] matris = new int[,] { {0,1,0,0,1,1 },
                                          {1,0,1,0,0,1 },
                                          {0,1,0,1,0,1 },
                                          {0,0,1,0,1,1 },
                                          {1,0,0,1,0,1 },
                                          {1,1,1,1,1,0 } };
            List<Node> diziNodes = DiziNodesOluştur();
            foreach (Node node in diziNodes)
            {

                if ((txtBreadFirst.Text).Equals(node.data))

                    isimInput = node;

            }

            sonucList =BreadthFirstAlgorithm.bfs(matris, isimInput,diziNodes);
        
            foreach(Node isim in sonucList)
            {
                bfs += isim.data+" ";
            }
            sonucList.Clear();
          
            MessageBox.Show(bfs);

      
        }

        private void minSpanningTreeButton_Click(object sender, EventArgs e)
        {
            int[,] weightedGraph = new int[,] { {0,8,0,0,7,4 }, //Olivia
                                          {8,0,6,0,0,5 },//Celine
                                          {0,6,0,11,0,7 },//Winston
                                          {0,0,11,0,7,5 },//Chloe
                                          {7,0,0,7,0,9 },//John
                                          {4,5,7,5,9,0 } };//Jack

            List<string> nameList = new List<string>() {"Olivia","Celine","Winston","Chloe","John","Jack" };
            string[] liste = new string[3];
            string yazdır="";
            List<string> prim=MinSpanningTree.PrimsAlgorithm(weightedGraph,nameList.Count);

            foreach(string eleman in prim)
            {
               liste =eleman.Split(' ');
                
                    string name1 = nameList[int.Parse(liste[0])];
                    string name2 = nameList[int.Parse(liste[1])];
                    int weight = int.Parse(liste[2]);
                
                    yazdır += name1 +"-"+ name2 +"\t"+ weight+"\n";

            }

            MessageBox.Show(yazdır);
        }
    }
}

