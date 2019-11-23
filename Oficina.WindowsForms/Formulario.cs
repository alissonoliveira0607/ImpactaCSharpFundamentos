using System;
using System.Windows.Forms;

namespace Oficina.WindowsForms
{
    internal class Formulario
    {
        internal static bool Validar(Form formulario, ErrorProvider provedorErros)
        {
            var validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag == null)
                {
                    continue;

                }

                if (controle.Tag.ToString().Contains("*") && controle.Text == string.Empty)
                {
                    provedorErros.SetError(controle, "Campo Obrigatório");
                    validacao = false;
                }
            }
            return validacao;
        }
    }
}