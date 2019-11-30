using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    internal static class Formulario
    {
        internal static bool Validar(Form formulario, ErrorProvider provedorErro)
        {
            var validacao = true;
            var bunifu = formulario.Controls[0];
            provedorErro.Clear();

            foreach (Control controle in bunifu.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;

                }

                if (controle.Tag.ToString().Contains("*") && controle.Text == string.Empty)
                {
                    validacao = DefinirErro(provedorErro, controle, "Campo Obrigatório");
                }
                else
                {
                    validacao = ValidarTipoDado(controle, provedorErro);
                }
            }

            return validacao;
        }

        private static bool DefinirErro(ErrorProvider provedorErro, Control controle, string mensagem)
        {
            provedorErro.SetError(controle, mensagem);
            controle.Focus();

            return false;
        }

        private static bool ValidarTipoDado(Control controle, ErrorProvider provedorErro)
        {
            var validacao = true;
            var controleTag = controle.Tag.ToString().ToUpper();

            if (controleTag.Contains("PLACA"))
            {
                if (!Regex.IsMatch(controle.Text, @"^[A-Z]{3}[0-9]{4}$"))
                {
                    validacao = DefinirErro(provedorErro, controle, "Digite a Placa no Formato AAA-1234");
                }
            }
            else if (controleTag.Contains("ANO"))
            {
                if (!Regex.IsMatch(controle.Text, @"^[\d]{4}$"))
                {
                    validacao = DefinirErro(provedorErro, controle, "Digite O ANO no Formato AAAA ");
                }


            }


            return validacao;
        }

        //internal static void Limpar(Form formulario)
        //{

        //    var bunifu = formulario.Controls[0];
        //    foreach (Control controle in bunifu.Controls)
        //    {
        //        if (controle is TextBox || controle is MaskedTextBox)
        //        {
        //            controle.Text = string.Empty;
        //        }
        //        else if (controle is ComboBox)
        //        {
        //            ((ComboBox)controle).SelectedIndex = -1;
        //        }

        //    }
        //}

        public static void Limpar(Control controle)
        {
            foreach (Control controleFor in controle.Controls)
            {
                if (controleFor is TextBox || controleFor is MaskedTextBox || controleFor is ComboBox)
                {
                    controleFor.ResetText();
                }

                Limpar(controleFor);
            }
        }
    }

}


