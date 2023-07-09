using System.Drawing.Drawing2D;

namespace TrabalhoFinalED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Grafo = new System.Windows.Forms.Panel();
            this.cb_FirstCity = new System.Windows.Forms.ComboBox();
            this.cb_SecondCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.tb_distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_calcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Grafo
            // 
            this.Grafo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Grafo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Grafo.BackgroundImage")));
            this.Grafo.Location = new System.Drawing.Point(12, 31);
            this.Grafo.Name = "Grafo";
            this.Grafo.Size = new System.Drawing.Size(1336, 613);
            this.Grafo.TabIndex = 2;
            this.Grafo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_FirstCity
            // 
            this.cb_FirstCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FirstCity.Items.AddRange(new object[] {
            "Araguari",
            "Capinópolis",
            "Cascalho Rico",
            "Centralina",
            "Douradinhos",
            "Estrela do Sul",
            "Grupiara",
            "Indianópolis",
            "Ituiutaba",
            "Itumbiara",
            "Monte Alegre de Minas",
            "Romaria",
            "São Juliana",
            "Tupaciguara",
            "Uberlândia"});
            this.cb_FirstCity.Location = new System.Drawing.Point(12, 671);
            this.cb_FirstCity.Name = "cb_FirstCity";
            this.cb_FirstCity.Size = new System.Drawing.Size(208, 28);
            this.cb_FirstCity.TabIndex = 0;
            this.cb_FirstCity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_SecondCity
            // 
            this.cb_SecondCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SecondCity.FormattingEnabled = true;
            this.cb_SecondCity.Items.AddRange(new object[] {
            "Araguari",
            "Capinópolis",
            "Cascalho Rico",
            "Centralina",
            "Douradinhos",
            "Estrela do Sul",
            "Grupiara",
            "Indianópolis",
            "Ituiutaba",
            "Itumbiara",
            "Monte Alegre de Minas",
            "Romaria",
            "São Juliana",
            "Tupaciguara",
            "Uberlândia"});
            this.cb_SecondCity.Location = new System.Drawing.Point(12, 723);
            this.cb_SecondCity.Name = "cb_SecondCity";
            this.cb_SecondCity.Size = new System.Drawing.Size(208, 28);
            this.cb_SecondCity.TabIndex = 3;
            this.cb_SecondCity.SelectedIndexChanged += new System.EventHandler(this.cb_SecondCity_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione a primeira cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 702);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecione a segunda cidade:";
            // 
            // bt_Sair
            // 
            this.bt_Sair.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Sair.Location = new System.Drawing.Point(1254, 722);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(94, 29);
            this.bt_Sair.TabIndex = 6;
            this.bt_Sair.Text = "SAIR";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // tb_path
            // 
            this.tb_path.BackColor = System.Drawing.Color.White;
            this.tb_path.Location = new System.Drawing.Point(406, 672);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(919, 27);
            this.tb_path.TabIndex = 7;
            // 
            // tb_distance
            // 
            this.tb_distance.BackColor = System.Drawing.Color.White;
            this.tb_distance.Location = new System.Drawing.Point(406, 722);
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.ReadOnly = true;
            this.tb_distance.Size = new System.Drawing.Size(145, 27);
            this.tb_distance.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(406, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Caminho percorrido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(406, 702);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Distância percorrida:";
            // 
            // bt_calcula
            // 
            this.bt_calcula.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_calcula.Location = new System.Drawing.Point(260, 698);
            this.bt_calcula.Name = "bt_calcula";
            this.bt_calcula.Size = new System.Drawing.Size(94, 29);
            this.bt_calcula.TabIndex = 11;
            this.bt_calcula.Text = "Calcular";
            this.bt_calcula.UseVisualStyleBackColor = true;
            this.bt_calcula.Click += new System.EventHandler(this.bt_calcula_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 763);
            this.Controls.Add(this.bt_calcula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_distance);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_SecondCity);
            this.Controls.Add(this.cb_FirstCity);
            this.Controls.Add(this.Grafo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dijkstra Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel Grafo;
        private ComboBox cb_FirstCity;
        private ComboBox cb_SecondCity;
        private Label label1;
        private Label label2;
        private Button bt_Sair;
        private TextBox tb_path;
        private TextBox tb_distance;
        private Label label3;
        private Label label4;
        private Button bt_calcula;
    }
}