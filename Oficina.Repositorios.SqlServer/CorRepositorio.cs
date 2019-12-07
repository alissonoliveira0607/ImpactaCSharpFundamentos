﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Oficina.Dominio.Interfaces;
using Oficina.Dominio;
using System.Configuration;

namespace Oficina.Repositorios.SqlServer
{
    public class CorRepositorio : ICorRepositorio
    {
        private string stringConexao = ConfigurationManager.ConnectionStrings["oficinaSqlServer"].ConnectionString;

        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cor cor)
        {
            throw new NotImplementedException();
        }

        public List<Cor> Ler()
        {

            var cores = new List<Cor>();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string instrucao = "SELECT id, nome FROM Cor ORDER BY nome";

                using (var comando = new SqlCommand(instrucao, conexao))
                {
                    using (var registros = comando.ExecuteReader())
                    {
                        while (registros.Read())
                        {
                            cores.Add(Mapear(registros));
                        }


                    }
                    

                }

                //conexao.Close();
            }


            return cores;
        }

        private Cor Mapear(SqlDataReader registro)
        {
            var cor = new Cor();

            cor.iD = Convert.ToInt32(registro["id"]);
            //cor.Nome = registro["nome"].ToString();
            cor.Nome = registro[nameof(cor.Nome)].ToString(); //AUTOMAPPER - COMPONENTE 


            return cor;


        }

        public Cor Ler(int id)
        {
            Cor cor = null;

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                const string nomeProcedure = "CorLer";

                using (var comando = new SqlCommand(nomeProcedure, conexao))
                {

                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);

                    using (var registros = comando.ExecuteReader())
                    {
                        if (registros.Read())
                        {

                            cor = (Mapear(registros));
                        }


                    }


                }

                //conexao.Close();
            }

            return cor;
          

        }

        public void Salvar(Cor cor)
        {
            throw new NotImplementedException();
        }
    }
}
