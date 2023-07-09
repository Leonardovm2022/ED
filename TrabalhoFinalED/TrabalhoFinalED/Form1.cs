using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.CompilerServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TrabalhoFinalED
{
    public partial class Form1 : Form
    {
        public List<Node> graphData;
        public Form1()
        {
            InitializeComponent();


            graphData = new List<Node>();

            //Cidades e Coordenadas no Mapa
            Node Itumbiara = new Node(1, 280, 50, "Itumbiara");
            Node Capinopolis = new Node(2, 60, 210, "Capinópolis");
            Node Centralina = new Node(3, 287, 146, "Centralina");
            Node Tupaciguara = new Node(4, 583, 150, "Tupaciguara");
            Node Ituiutaba = new Node(5, 100, 400, "Ituiutaba");
            Node MonteAlegre = new Node(6, 565, 315, "Monte Alegre de Minas");
            Node Douradinhos = new Node(7, 582, 438, "Douradinhos");
            Node Uberlandia = new Node(8, 844, 358, "Uberlândia");
            Node Araguari = new Node(9, 895, 188, "Araguari");
            Node Indianopolis = new Node(10, 1075, 447, "Indianópolis");
            Node CascalhoRico = new Node(11, 1090, 149, "Cascalho Rico");
            Node Grupiara = new Node(12, 1200, 90, "Grupiara");
            Node EstrelaDoSul = new Node(13, 1200, 257, "Estrela do Sul");
            Node Romaria = new Node(14, 1248, 370, "Romaria");
            Node SaoJuliana = new Node(15, 1248, 560, "São Juliana");

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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Draw(Grafo);
        }

        public void Draw(Panel panel)
        {

            //Construcao do Grafo
            Graphics g = panel.CreateGraphics();

            //Desenha as Arestas
            Pen pen = new Pen(Color.DarkCyan, 4);
            foreach (Node node in graphData)
            {
                // code to draw the edges goes here
                foreach (var neighbour in node.neighbours)
                {
                    if (pathDisplayed && (neighbour.Item1.color == Color.Orange && node.color == Color.Orange))
                    {
                        g.DrawLine(new Pen(Color.Orange, 4), node.X + 25, node.Y + 23, neighbour.Item1.X + 25, neighbour.Item1.Y + 23);
                    }
                    else
                    {
                        g.DrawLine(pen, node.X + 25, node.Y + 23, neighbour.Item1.X + 25, neighbour.Item1.Y + 23);
                    }
                }
            }
            //Desenha os Vertices
            foreach (Node node in graphData)
            {
                Brush brush;
                if (pathDisplayed && node.color == Color.Orange)
                {
                    brush = new SolidBrush(Color.Orange);
                }
                else
                {
                    brush = new SolidBrush(node.color);
                }
                g.FillEllipse(brush, node.X, node.Y, 45, 45);
            }
        }

        int lastSelectedFirstCity = 0;
        Node primeiraCidade = null;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetNodes();
            switch (cb_FirstCity.SelectedItem.ToString())
            {
                case "Araguari":
                    foreach (Node node in graphData)
                    {
                        if(node.Id == 9)
                        {
                            node.color = Color.Red;
                            foreach(Node node2 in graphData)
                            {
                                if(node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 9;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Capinópolis":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 2)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 2;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Cascalho Rico":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 11)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 11;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Centralina":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 3)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 3;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Douradinhos":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 7)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 7;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Estrela do Sul":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 13)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 13;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Grupiara":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 12)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 12;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Indianópolis":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 10)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 10;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Ituiutaba":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 5)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 5;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Itumbiara":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 1)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 1;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Monte Alegre de Minas":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 6)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 6;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Romaria":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 14)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 14;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "São Juliana":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 15)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 15;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Tupaciguara":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 4)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 4;
                            primeiraCidade = node;
                        }
                    }
                    break;
                case "Uberlândia":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 8)
                        {
                            node.color = Color.Red;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedFirstCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedFirstCity = 8;
                            primeiraCidade = node;
                        }
                    }
                    break;
            }
            Refresh(); // call the Draw method again to repaint the form
        }

        Node segundaCidade = null;
        int lastSelectedSecondCity = 0;
        private void cb_SecondCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetNodes();
            switch (cb_SecondCity.SelectedItem.ToString())
            {
                case "Araguari":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 9)
                        {
                            node.color = Color.Green;
                            foreach(Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 9;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Capinópolis":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 2)
                        {
                            node.color = Color.Green;
                            foreach(Node node2 in graphData)
                            {
                                if(node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 2;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Cascalho Rico":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 11)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 11;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Centralina":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 3)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 3;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Douradinhos":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 7)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 7;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Estrela do Sul":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 13)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 13;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Grupiara":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 12)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 12;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Indianópolis":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 10)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 10;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Ituiutaba":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 5)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 5;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Itumbiara":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 1)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 1;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Monte Alegre de Minas":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 6)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 6;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Romaria":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 14)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 14;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "São Juliana":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 15)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 15;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Tupaciguara":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 4)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 4;
                            segundaCidade = node;
                        }
                    }
                    break;
                case "Uberlândia":
                    foreach (Node node in graphData)
                    {
                        if (node.Id == 8)
                        {
                            node.color = Color.Green;
                            foreach (Node node2 in graphData)
                            {
                                if (node2.Id == lastSelectedSecondCity)
                                {
                                    node2.color = Color.DarkCyan;
                                }
                            }
                            lastSelectedSecondCity = 8;
                            segundaCidade = node;
                        }
                    }
                    break;
            }
            Refresh();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Dijkstra(Node startNode)
        {
            // set the distance of the start node to 0
            startNode.Distance = 0;

            // create a priority queue to store the unvisited nodes
            PriorityQueue<Node> queue = new PriorityQueue<Node>();
            queue.Enqueue(startNode, startNode.Distance, startNode.Id);

            while (queue.Count > 0)
            {
                // dequeue the node with the smallest distance
                Node currentNode = queue.Dequeue();

                // mark the node as visited
                currentNode.Visited = true;

                // visit each neighbour of the current node
                foreach (var neighbour in currentNode.neighbours)
                {
                    Node neighbourNode = neighbour.Item1;
                    int weight = neighbour.Item2;

                    // if the neighbour has not been visited and the new distance is smaller than the previous distance
                    if (!neighbourNode.Visited && currentNode.Distance + weight < neighbourNode.Distance)
                    {
                        // update the neighbour's distance and previous node
                        neighbourNode.Distance = currentNode.Distance + weight;
                        neighbourNode.Previous = currentNode;

                        // enqueue the neighbour into the priority queue
                        queue.Enqueue(neighbourNode, neighbourNode.Distance, neighbourNode.Id);
                    }
                }
            }
        }

        private bool pathDisplayed = false;
        public void ShowShortestPath(Node startCity, Node endCity)
        {
            if (startCity == endCity)
            {
                tb_path.Text = "The start city and the end city are the same.";
                tb_distance.Text = "0";
                return;
            }

            // use the previous properties of the nodes to trace the path from the end city to the start city
            Node currentNode = endCity;
            Stack<Node> path = new Stack<Node>();
            while (currentNode != null)
            {
                path.Push(currentNode);
                currentNode = currentNode.Previous;
            }

            if (path.Count == 1)
            {
                tb_path.Text = "There is no path between the start city and the end city.";
                tb_distance.Text = "";
            }
            else
            {
                tb_distance.Text = endCity.Distance.ToString();
                // print the path from start city to end city

                Node startNode = startCity;
                Node endNode = endCity;
                startNode.color = Color.Red;
                endNode.color = Color.Green;

                while (path.Count > 0)
                {
                    Node city = path.Pop();
                    tb_path.Text += city.Name;
                    city.color = Color.Orange;
                    if (path.Count > 0)
                    {
                        tb_path.Text += " -> ";
                        Node nextCity = path.Peek();
                        foreach (var neighbour in city.neighbours)
                        {
                            if (neighbour.Item1.Id == nextCity.Id)
                            {
                                neighbour.Item1.color = Color.Red;
                            }
                        }
                    }
                }
                pathDisplayed = true;
                Grafo.Refresh();
                Draw(Grafo);
            }
        }

        public void ResetNodes()
        {
            foreach (Node node in graphData)
            {
                node.Distance = double.PositiveInfinity;
                node.Previous = null;
                node.Visited = false;
                if (pathDisplayed)
                {
                    node.color = Color.DarkCyan; // set the color back to the original color
                }
            }
            pathDisplayed = false;
            Grafo.Refresh();
            Draw(Grafo);
        }
        private void bt_calcula_Click_1(object sender, EventArgs e)
        {
            tb_distance.Text = "";
            tb_path.Text = "";
            ResetNodes();
            if (primeiraCidade == null || segundaCidade == null)
            {
                MessageBox.Show("Selecione as duas cidades.");
                return;
            }
            else
            {
                Dijkstra(primeiraCidade);
                ShowShortestPath(primeiraCidade, segundaCidade);
            }
        }
    }
}