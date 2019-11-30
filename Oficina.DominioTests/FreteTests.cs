using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio.Tests
{
    [TestClass()]
    public class FreteTests
    {
        [TestMethod()]
        public void FreteTest()
        {

            var Frete = new Frete(100m, UF.SP);
            //calcularFrete.Valor = 100;
            //calcularFrete.UF = UF.SP;
            
            //calcularFrete.Calcular();
            Assert.AreEqual(Frete.Percentual, 0.2m);
            Assert.IsTrue(Frete.Total == 120);

        }
    }
}