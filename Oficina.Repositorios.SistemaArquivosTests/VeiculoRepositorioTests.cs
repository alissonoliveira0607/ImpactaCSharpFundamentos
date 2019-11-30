using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new VeiculoPasseio();

            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Observacao = "Completo";
            veiculo.Placa = "ABC1533";

            var cores = new CorRepositorio();
            veiculo.Cor = cores.GetCor(1);

            veiculo.Modelo = new ModeloRepositorio().GetModelos(1); //instanciando um objeto anonimo

            new VeiculoRepositorio().Inserir(veiculo);


        }
    }
}