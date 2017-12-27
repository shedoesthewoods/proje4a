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
    public partial class Form1 : Form
    {
        Program nesne = new Program();

        static int INF = int.MaxValue;

        int[,] matris = new int[,] { {0,8,INF,INF,7,4 },  //Matrisi kontrol edin!!!!
                                     {8,0,6,INF,INF,5 },
                                     {INF,6,0,11,INF,7 },
                                     {INF,INF,11,0,7,5 },
                                     {7,INF,INF,7,0,9 },
                                     {4,5,7,11,9,0 } };


        public Form1()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            this.Text = "GRAPH";
        }

        private void Dijkstra_Click(object sender, EventArgs e)
        {
            string metin1=textBox1.Text;

            string metin2 = textBox2.Text;

            int uzaklık= nesne.DijkstrasShortestPath(int.Parse(metin1),int.Parse(metin2),matris);

            Form yeniform = new Form();
            yeniform.Show();
        }

        private void Breadth_Click(object sender, EventArgs e)
        {

        }

        private void MinSpannig_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)  //Dijkstra textbox
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e) //Breadth textbox
        {

        }

        private void label1_Click(object sender, EventArgs e)  //Dijkstra label
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
