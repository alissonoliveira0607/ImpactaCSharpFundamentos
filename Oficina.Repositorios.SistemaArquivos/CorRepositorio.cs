﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {

        private string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];


        public List<Cor> GetCor()
        {

            var cores = new List<Cor>();

            //para cada linha em meu arquivo de texto execute essa ação            
            foreach (var linha in File.ReadAllLines("Dados\\Cor.txt"))
            {

                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var cor = new Cor();

                cor.iD = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);
                cores.Add(cor);
                
            }
            return cores;

        }

        public Cor GetCor(int id)
        {
            Cor cor = null;


            foreach (var linha in File.ReadAllLines("Dados\\Cor.txt"))
            {

                
                if (string.IsNullOrEmpty(linha))
                {
                    continue;
                }

                var linhaId = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaId)
                {
                     cor = new Cor();

                    cor.iD = linhaId;
                    cor.Nome = linha.Substring(5);

                    break;

                }

            }

            return cor;
          
        }

    }
}
