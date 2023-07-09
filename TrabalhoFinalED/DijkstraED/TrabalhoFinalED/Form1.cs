using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace TrabalhoFinalED
{
    public partial class Form1 : Form
    {
        private List<Node> graphData;
        public Form1()
        {
            InitializeComponent();


            graphData = new List<Node>();

            //Cidades e Coordenadas no Mapa
            Node Itumbiara = new Node(1, 280, 50);
            Node Capinopolis = new Node(2, 60, 210);
            Node Centralina = new Node(3, 287, 146);
            Node Tupaciguara = new Node(4, 583, 150);
            Node Ituiutaba = new Node(5, 100, 400);
            Node MonteAlegre = new Node(6, 565, 315);
            Node Douradinhos = new Node(7, 582, 438);
            Node Uberlandia = new Node(8, 844, 358);
            Node Araguari = new Node(9, 895, 188);
            Node Indianopolis = new Node(10, 1075, 447);
            Node CascalhoRico = new Node(11, 1090, 149);
            Node Grupiara = new Node(12, 1200, 90);
            Node EstrelaDoSul = new Node(13, 1200, 257);
            Node Romaria = new Node(14, 1248, 370);
            Node SaoJuliana = new Node(15, 1248, 560);

            //Vizinhos e Pesos (Distancias)
            Itumbiara.AddNeighbour(Centralina, 20);
            Itumbiara.AddNeighbour(Tupaciguara, 55);

            Capinopolis.AddNeighbour(Centralina, 40);
            Capinopolis.AddNeighbour(Ituiutaba, 30);

            Centralina.AddNeighbour(Itumbiara, 20);
            Centralina.AddNeighbour(Capinopolis, 40);
            Centralina.AddNeighbour(MonteAlegre, 75);

            Tupaciguara.AddNeighbour(Itumbiara, 55);
            Tupaciguara.AddNeighbour(MonteAlegre, 44);
            Tupaciguara.AddNeighbour(Uberlandia, 60);

            Ituiutaba.AddNeighbour(Capinopolis, 30);
            Ituiutaba.AddNeighbour(MonteAlegre, 85);
            Ituiutaba.AddNeighbour(Douradinhos, 90);

            MonteAlegre.AddNeighbour(Centralina, 75);
            MonteAlegre.AddNeighbour(Tupaciguara, 44);
            MonteAlegre.AddNeighbour(Uberlandia, 60);
            MonteAlegre.AddNeighbour(Douradinhos, 28);
            MonteAlegre.AddNeighbour(Ituiutaba, 85);

            Douradinhos.AddNeighbour(Ituiutaba, 90);
            Douradinhos.AddNeighbour(MonteAlegre, 28);
            Douradinhos.AddNeighbour(Uberlandia, 63);

            Uberlandia.AddNeighbour(Tupaciguara, 60);
            Uberlandia.AddNeighbour(MonteAlegre, 60);
            Uberlandia.AddNeighbour(Douradinhos, 63);
            Uberlandia.AddNeighbour(Araguari, 30);
            Uberlandia.AddNeighbour(Romaria, 78);
            Uberlandia.AddNeighbour(Indianopolis, 45);

            Araguari.AddNeighbour(Uberlandia, 30);
            Araguari.AddNeighbour(CascalhoRico, 28);
            Araguari.AddNeighbour(EstrelaDoSul, 34);

            Indianopolis.AddNeighbour(Uberlandia, 45);
            Indianopolis.AddNeighbour(SaoJuliana, 40);

            CascalhoRico.AddNeighbour(Araguari, 28);
            CascalhoRico.AddNeighbour(Grupiara, 32);

            Grupiara.AddNeighbour(CascalhoRico, 32);
            Grupiara.AddNeighbour(EstrelaDoSul, 38);

            EstrelaDoSul.AddNeighbour(Grupiara, 38);
            EstrelaDoSul.AddNeighbour(Araguari, 34);
            EstrelaDoSul.AddNeighbour(Romaria, 27);

            Romaria.AddNeighbour(EstrelaDoSul, 27);
            Romaria.AddNeighbour(Uberlandia, 78);
            Romaria.AddNeighbour(SaoJuliana, 28);

            SaoJuliana.AddNeighbour(Romaria, 28);
            SaoJuliana.AddNeighbour(Indianopolis, 40);

            //Adicionar Cidades na Lista de Dados do Grafo
            graphData.Add(Itumbiara);
            graphData.Add(Capinopolis);
            graphData.Add(Centralina);
            graphData.Add(Tupaciguara);
            graphData.Add(Ituiutaba);
            graphData.Add(MonteAlegre);
            graphData.Add(Douradinhos);
            graphData.Add(Uberlandia);
            graphData.Add(Araguari);
            graphData.Add(Indianopolis);
            graphData.Add(CascalhoRico);
            graphData.Add(Grupiara);
            graphData.Add(EstrelaDoSul);
            graphData.Add(Romaria);
            graphData.Add(SaoJuliana);

            foreach (Node node in graphData)
            {
                var button = new Button();
                button.Location = new Point(node.X - 10, node.Y - 10);
                button.Size = new Size(20, 20);
                button.Click += Button_Click;
                this.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            // logic of what you want to do when the button is clicked
            MessageBox.Show("Button clicked!");
            // you can use the button variable to do something with the specific button that was clicked
            button.BackColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graph graph = new Graph();
            graph.Draw(Grafo,graphData);
        }
        public class Graph
        {
            public void Draw(Panel panel, List<Node> graphData)
            {
                
                //Construcao do Grafo
                Graphics g = panel.CreateGraphics();

                //Desenha os Vertices
                foreach (Node node in graphData)
                { 
                    g.FillEllipse(Brushes.DarkCyan, node.X, node.Y, 45, 45);
                }

                //Desenha as Arestas
                Pen pen = new Pen(Color.DarkCyan, 4);
                foreach (Node node in graphData)
                {
                    // code to draw the edges goes here
                    foreach (var neighbor in node.neighbours)
                    {
                        g.DrawLine(pen, node.X+25, node.Y+23, neighbor.Item1.X+25, neighbor.Item1.Y+23);
                    }
                }
            }
        }



        public class Node
        {
            public int Id { get; set; }
            public double Distance { get; set; }
            public Node Previous { get; set; }
            public List<Tuple<Node, int>> neighbours = new List<Tuple<Node, int>>();
            public void AddNeighbour(Node node, int weight)
            {
                neighbours.Add(new Tuple<Node, int>(node, weight));
            }
            public int X { get; set; }
            public int Y { get; set; }

            public Node(int id, int x, int y)
            {
                Id = id;
                Distance = double.PositiveInfinity;
                Previous = null;
                X = x;
                Y = y;
            }
        }//Fim da classe Node

        
    }
}