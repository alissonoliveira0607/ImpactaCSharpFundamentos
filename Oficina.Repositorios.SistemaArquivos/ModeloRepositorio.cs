﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio : RepositorioBase
    {
        private XDocument arquivoXml;

        public ModeloRepositorio() : base("caminhoArquivoModelo")
        {
            arquivoXml = XDocument.Load(CaminhoArquivo);
        }

        //a classe XDocument server para manipular arquivos xml


        public List<Modelo> GetModelo(int marcaId)
        {
            MarcaRepositorios marca = new MarcaRepositorios();
            var modelos = new List<Modelo>();
            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if (marcaId.ToString() == elemento.Element("marcaid").Value)
                {
                    Modelo modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;
                    modelo.Marca = marca.GetMarca(marcaId);

                    modelos.Add(modelo);
                }
            }


            return modelos;
        }

        public Modelo GetModelos(int id)
        {
            Modelo modelos = null;


            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {

                if (id.ToString() ==  elemento.Element("id").Value)
                {
                    modelos = new Modelo();
                    modelos.Id = id;
                    modelos.Nome = elemento.Element("nome").Value;

                    var marcaRepositorio = new MarcaRepositorios();

                    modelos.Marca = marcaRepositorio.GetMarca(Convert.ToInt32(elemento.Element("id").Value));

                    break;
                }

            }

            return modelos;

        }


    }
}
