using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrocoForm_Load(object sender, EventArgs e)
        {

        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {

            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            decimal valorPago = Convert.ToDecimal(valorPagotextBox.Text);
            var troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C");
            //trocoTextBox.Text = Convert.ToString("R$" + troco);

            //moedas1Real = Convert.ToInt32(troco);

            //ToDo: refatorar para usar estrutura de repetição
            //var moedas1Real = (int)troco / 1;
            //realizando um cast e convertendo o objeto troco em inteiro
            //troco = troco % 1;


            var moedas = new decimal[6] { 1, 0.5m, 0.25m, 0.10m, 0.05m, 0.01m };

            for (int i = 0; i < moedas.Length; i++)
            {
                moedasListView.Items[i].Text = ((int)(troco / moedas[i])).ToString();
                troco %= moedas[i];
            }



            //troco %= 1;

            //var moedas50cent = (int)(troco / 0.5m);
            //troco %= 0.5m;

            //var moedas25cent = (int)(troco / 0.25m);
            //troco %= 0.25m;

            //var moedas10cent = (int)(troco / 0.10m);
            //troco %= 0.10m;

            //var moedas5cent = (int)(troco / 0.05m);
            //troco %= 0.05m;

            //var moedas01cent = (int)(troco / 0.01m);
            //troco %= 0.01m;

            //moedasListView.Items[0].Text = moedas1Real.ToString();  //convertendo o obj moedalistview da posição 0 para string e assim sucessivamente
            //moedasListView.Items[1].Text = moedas50cent.ToString();
            //moedasListView.Items[2].Text = moedas25cent.ToString();
            //moedasListView.Items[3].Text = moedas10cent.ToString();
            //moedasListView.Items[4].Text = moedas5cent.ToString();
            //moedasListView.Items[5].Text = moedas01cent.ToString();



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            valorCompraTextBox.Clear();
            valorPagotextBox.Clear();
            trocoTextBox.Clear();
            moedasListView.Items.Clear();
        }
    }
}
