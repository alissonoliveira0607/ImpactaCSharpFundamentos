using System;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Variaveis
{
    public partial class VariaveisForm : Form
    {

        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void VariaveisForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aritméticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //CTRL K C COMENTA UM BLOCO DE CODIGOS
            //CTRL M L EXPANDE TODOS OS METODOS
            //CTRL M O CONTRAI OS MÉTODOS DO PROGRAMA
            //CTRL M M EXPANDE E CONTRAI O METODO QUE ESTA EM ABERTO
            //CTRL R M EXTRAIR METHODO
            resultadoListBox.Items.Clear();
            int numero1 = 42;
            int j = 0;
            string nome = "Alisson";
            DateTime dataNascimento = new DateTime(1995, 06, 07);
            DateTime dataAtual = DateTime.Now;
                      
            bool aprovado = true;
            
            var a = 2;
            int b = 6;
            var c = 10;
            var d = 13;

            decimal valor = 7.8m;
            var bimestre1 = 8.5;

            //if(j == 5)
            //{

            //}

            resultadoListBox.Items.Add("a = " + a);
            //resultadoListBox.Items.Add(string.Concat("b = ", b));//o string.concat te da a possibilidade de alterar a concatenação do + pela ,
            //resultadoListBox.Items.Add(string.Format("c = {0}" + c));//string.format te da a possibilidade de colocar todo valor dentro de {indice} e substitui o indice pelas variaveis
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add("c = " + c);
            resultadoListBox.Items.Add($"d = {d}");

            resultadoListBox.Items.Add($"c * d = {c * d}");
            resultadoListBox.Items.Add($"c / a = {c / a}");
            resultadoListBox.Items.Add($"d % a = {d % a}");



        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();
            var x = 5;
            resultadoListBox.Items.Add("X = " + x);

            //x = x - 3;
            x -= 3;

            resultadoListBox.Items.Add("X = " + x);
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resultadoListBox.Items.Clear();
            
            int a = 5;
            resultadoListBox.Items.Add("Exemplo de pré incremental ");
            resultadoListBox.Items.Add("A " + a);
            resultadoListBox.Items.Add($"2 + ++a = {2 + ++a}");
            resultadoListBox.Items.Add($"A = {a}");
            resultadoListBox.Items.Add("=====================");
            a = 5;
            resultadoListBox.Items.Add("Exemplo de PÓS incremental ");
            resultadoListBox.Items.Add("A " + a);
            resultadoListBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadoListBox.Items.Add($"A = {a}");


        }

        private void bOOLEANASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();

            ExibirValores();
            resultadoListBox.Items.Add($"W <= X {w <= x}");
            resultadoListBox.Items.Add($"X == Z {x == z}");
            resultadoListBox.Items.Add($"X != Z {x != z}");
        }

        private void ExibirValores()
        {
            resultadoListBox.Items.Clear();

            resultadoListBox.Items.Add($"X = {x}");
            resultadoListBox.Items.Add($"Y = {y}");
            resultadoListBox.Items.Add($"W = {w}");
            resultadoListBox.Items.Add($"Z = {z}");
            resultadoListBox.Items.Add(new string('-', 20));
            //método para adicionar o mesmo caracter varias vezes
        }

        private void lógicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoListBox.Items.Clear();
            ExibirValores();
            resultadoListBox.Items.Add($"W <= X || Y == 16 = {w <= x || y == 16}");
            resultadoListBox.Items.Add($"X == Z && X != Z = {x == z && x != z}");
            resultadoListBox.Items.Add($"!(Y > W) {!(y > w)}");



        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;
            ano = 2014;

            resultadoListBox.Items.Add ($"O ano {ano} é Bisexto? {(ano % 4 == 0 ? "Sim" : "Não")}.");

            ano = 2016;

            resultadoListBox.Items.Add($"O ano {ano} é Bisexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}.");





            //if (ano % 4 == 0)
            //{

            //}
            //else
            //{

            //}



        }
    }
   
}
