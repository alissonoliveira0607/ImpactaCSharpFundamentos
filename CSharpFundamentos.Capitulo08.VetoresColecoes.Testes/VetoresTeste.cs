using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentos.Capitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializaçãoTeste()
        {

            var inteiros = new int[5];
            inteiros[0] = 14;
            //inteiros[5] = 4;

            var decimais = new decimal[] { 0.4m, 0.9m, 4, 7.8m };

            string[] nomes = { "Alisson", "Oliveira" };

            foreach (var item in decimais)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"O Tamanho do vetor {nameof(decimais)} é {decimais.Length}");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {

            var decimais = new decimal[] { 0.5m, 7m, 8.9m };

            Array.Resize(ref decimais, 5);

        }

        [TestMethod]
        public void OrdenacaoTeste()
        {

            var decimais = new decimal[] { 0.5m, 7m, 0.9m, -1.4m };

            Array.Sort(decimais);
            /*ORDENA O VETOR*/

            Assert.AreEqual(decimais[0], -1.4m);
            /*AFIRMA SE É AQUELE O CONTEUDO DO VETOR DA POSIÇÃO[I]*/



        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 0.5m, 7m, 0.9m, -1.4m };
            Console.WriteLine(Media(decimais));
            Console.WriteLine(Media(1.5m, 8, 0.5m, 25));

        }

        [TestMethod]
        private decimal Media(decimal valor1, decimal valor2)
        {
            decimal media = (valor1 + valor2) / 2;

            return media;
        }

        private decimal Media(params decimal[] valores)
        /*A PALAVRA RESERVADA PARAMS PERMITE QUE VOCE PASSE OS VALORES 
         POR PARAMETROS DIRETO PELOS METODOS*/
        {
            var soma = 0m;

            var quantidade = valores.Length;

            foreach (var item in valores)
            {
                soma += item;
            }

            return soma / quantidade;
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Alisson";
            Assert.AreEqual(nome[0], 'A');

            foreach (var @char in nome)
            {
                Console.WriteLine(@char);
            }

        }

    }

}

