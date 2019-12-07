using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    public partial class VeiculoForm : Form
    {

        //construtor metodo com o mesmo nome da classe
        //executado automaticamente(new)
        public VeiculoForm()
        {
            InitializeComponent();

            PopularControles();
        }

        private void PopularControles()
        {
           marcaComboBox.DataSource = new MarcaRepositorios().GetMarca();
           marcaComboBox.DisplayMember = "Nome";
           marcaComboBox.ValueMember = "Id";
           marcaComboBox.SelectedIndex = -1;

           corComboBox.DataSource = new CorRepositorio().GetCor();
           corComboBox.DisplayMember = "Nome";
           corComboBox.ValueMember = "Id";
           corComboBox.SelectedIndex = -1;


            cambioComboBox.DataSource = Enum.GetValues(typeof(Cambio));
            cambioComboBox.SelectedIndex = -1;

            combustivelComboBox.DataSource = Enum.GetValues(typeof(Combustivel));
            combustivelComboBox.SelectedIndex = -1;






        }


        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (marcaComboBox.SelectedIndex == -1)
            {
                return;
            }

           var marca = (Marca)marcaComboBox.SelectedItem;
           modeloComboBox.DataSource = new ModeloRepositorio().GetModelo(marca.Id);
           modeloComboBox.ValueMember = "Nome";
           modeloComboBox.ValueMember = "Id";
           modeloComboBox.SelectedIndex = -1;
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {


            try
            {
                if (Formulario.Validar(this, veiculoErrorProvider))
                {


                    GravarVeiculo();
                    MessageBox.Show("Veiculo Cadastrado Com Sucesso");
                    Formulario.Limpar(this);
                    placaMaskedTextBox.Focus();
                }
            }

            catch (FileNotFoundException excecao)
            {
                MessageBox.Show($"O arquivo {excecao.FileName} não foi encontrado.");
            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show($"O arquivo Veiculo XML está com o atributo somente leitura");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Eita! Algo deu errado e em breve teremos uma solução");
                
            }

            finally
            {
                //É EXECUTADO SEMPRE MESMO QUE HAJA ALGUM RETURN NO CÓDIGO
            }
        }

        private void GravarVeiculo()
        {
            //ctrl k, s envolve um bloco de comando dentro de outro bloco

                var veiculo = new VeiculoPasseio();
                veiculo.Ano = Convert.ToInt32(anoMaskedTextBox.Text);
                veiculo.Cambio = (Cambio)cambioComboBox.SelectedItem;
                veiculo.Carroceria = Carroceria.Hatch;
                veiculo.Combustivel = (Combustivel)combustivelComboBox.SelectedItem;
                veiculo.Cor = (Cor)corComboBox.SelectedItem;
                veiculo.Modelo = (Modelo)modeloComboBox.SelectedItem;
                veiculo.Observacao = observacaoGroupBox.Text;
                veiculo.Placa = placaMaskedTextBox.Text;
            
                new VeiculoRepositorio().Inserir(veiculo);
             
        }

        private void limparButton_Click(object sender, EventArgs e)
        {


            Formulario.Limpar(this);
            }
        }
    }

