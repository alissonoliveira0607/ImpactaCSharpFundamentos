using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamento.Capitulo4.Frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            clienteTextBox.Clear();
            valorTextBox.Clear();
            ufComboBox.Text = "";
            freteTextBox.Clear();
            resultadoTextBox.Clear();

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Calcular()
        {
            var percentualFrete = 0m;
            var valor = Convert.ToDecimal(valorTextBox.Text);

            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentualFrete = 0.2m;
                    break;
                case "RJ":
                    percentualFrete = 0.3m;
                    break;
                case "MG":
                    percentualFrete = 0.35m;
                    break;
                case "AM":
                    percentualFrete = 0.6m;
                    break;                                                 
                default:
                    percentualFrete = 0.75m;
                    break;
            }



            freteTextBox.Text = percentualFrete.ToString("P2");
            decimal calculoFrete = (1 + percentualFrete) * valor;
            resultadoTextBox.Text = calculoFrete.ToString("c");
            //resultadoTextBox.Text = ((1 + percentualFrete) * valor).ToString("c");
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            if (clienteTextBox.Text == string.Empty)
            {

                erros.Add("O Campo Cliente é  Obrigatório");
                
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione um UF");
            }

            //if(string.IsNullOrEmpty(valorTextBox.Text))
            if (valorTextBox.Text == string.Empty)
            {

                erros.Add("O campo valor é Obrigatório");

            }
            else
            {

                decimal valorConvertido;

                if (!decimal.TryParse(valorTextBox.Text, out valorConvertido))
                {
                    erros.Add("O Campo Valor deve Ser Numérico");
                }

            }

            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            clienteTextBox.Clear();
            valorTextBox.Clear();
            ufComboBox.Text = "";
            freteTextBox.Clear();
            resultadoTextBox.Text = string.Empty;
            //freteTextBox.Text = string.Empty;
            //freteTextBox.Text = null;
            //ufComboBox.SelectedIndex = -1;


        }
    }
}
