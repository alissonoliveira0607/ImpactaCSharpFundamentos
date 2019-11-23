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
    public class CorRepositorioTests
    {

        CorRepositorio corRepositorio = new CorRepositorio();

        [TestMethod()]
        public void GetCorTest()
        {
            //instanciando o objeto da classe corRepositorio
            var cores = corRepositorio.GetCor();


            foreach (var cor in cores)
            {
                Console.WriteLine($"Cores : {cor.iD} : {cor.Nome}");
            }


        }

        [TestMethod()]
        public void GetIdTest()
        {
            var cor = corRepositorio.GetCor(3);
            Assert.AreEqual(cor.Nome, "Branco");
            Console.WriteLine($"Cor Selecionada : {cor.Nome}");
        }
    }
}