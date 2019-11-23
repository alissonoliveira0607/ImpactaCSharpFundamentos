using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        [TestMethod()]
        public void GetModeloTest()
        {
            var modeloRepositorios = new ModeloRepositorio();

            var modelos = modeloRepositorios.GetModelo(4);

            foreach (var modelo in modelos)
            {

                Console.WriteLine($"Marcas {modelo.Id} : {modelo.Nome} - {modelo.Marca.Nome}");
            }
        }

        [TestMethod()]
        public void GetModelosTest()
        {
            var modeloRepositorios = new ModeloRepositorio();

            var modelo = modeloRepositorios.GetModelos(1);
            Assert.AreEqual(modelo.Nome, "Argo");
            Console.WriteLine($"Marca Selecionada {modelo.Nome}");
        }
    }
}
