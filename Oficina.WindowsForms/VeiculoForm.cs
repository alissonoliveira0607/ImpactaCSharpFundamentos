using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    public partial class VeiculoForm : Form
    {

        //contrustor metodo com o mesmo nome da classe
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
            if (Formulario.Validar(this, veiculoErrorProvider))
            {

              
                GravarVeiculo();
            }
        }

        private void GravarVeiculo()
        {
           
        }
    }
}
