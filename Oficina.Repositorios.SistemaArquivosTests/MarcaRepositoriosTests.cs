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
    public class MarcaRepositoriosTests
    {
        [TestMethod()]
        public void GetMarcaTest()
        {
            var marcaRepositorio = new MarcaRepositorios();

            var marcas = marcaRepositorio.GetMarca();

            foreach (var marca in marcas)
            {

                Console.WriteLine($"Marcas {marca.Id} : {marca.Nome}");
            }
        }

        [TestMethod()]
        public void GetMarcaTest1()
        {
            var marcaRepositorio = new MarcaRepositorios();

            var marcas = marcaRepositorio.GetMarca(1);
            Assert.AreEqual(marcas.Nome, "Fiat");
            Console.WriteLine($"Marca Selecionada {marcas.Nome}");
        }
    }
}