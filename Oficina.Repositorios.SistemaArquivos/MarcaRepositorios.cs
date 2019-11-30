using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class MarcaRepositorios : RepositorioBase
    {
        //private string caminhoArquivo = ConfigurationManager.AppSettings[RepositorioBase()];

        //ctor criar contrustor
        public MarcaRepositorios() : base("caminhoArquivoMarca")
        {
        }



        //ToDo: OO - Polimorfismo por sobrecarga.
        public List<Marca> GetMarca()
        {

            var Marcas = new List<Marca>();

            //para cada linha em meu arquivo de texto execute essa ação            
            foreach (var linha in File.ReadAllLines(CaminhoArquivo))
            {

                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var propriedades = linha.Split('|');

                var Marca = new Marca();

                Marca.Id = Convert.ToInt32(propriedades[0]);
                Marca.Nome = propriedades[1];
                Marcas.Add(Marca);

            }
            return Marcas;

        }

        public Marca GetMarca(int id)
        {
            Marca Marca = null;


            foreach (var linha in File.ReadAllLines(CaminhoArquivo))
            {


                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var propriedades = linha.Split('|');

                var linhaId = Convert.ToInt32(propriedades[0]);

                if (id == linhaId)
                {
                    Marca = new Marca();

                    Marca.Id = linhaId;
                    Marca.Nome = propriedades[1];

                    break;

                }

            }

            return Marca;

        }


    }
}
