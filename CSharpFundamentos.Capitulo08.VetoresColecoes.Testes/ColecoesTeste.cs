using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentos.Capitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {

            var inteiros = new List<int>() { 1, 8, 33, 16, -78 };
            inteiros.Add(27);

            var maisInteiros = new List<int>() { 16, 38, -7, 8 };

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0, 50);/*insere um elemento passando como parametro o index e o conteudo*/

            inteiros.Remove(1);/*remove apenas a primeira ocorrência*/

            inteiros.RemoveAll(i => i ==16); /*Lambda expression*/

            //inteiros.RemoveAt(0); /*Remove os elementos pelo seu index*/

            //inteiros.RemoveRange(0, 3);

            inteiros.Sort();

            var primeiro = inteiros.First();

            var ultimo = inteiros[inteiros.Count - 1];

            ultimo = inteiros.Last();

            foreach (var numero in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(numero)}:{numero}");
            }

        }


        [TestMethod]
        public void DitionaryTeste()
        {
            var Feriados = new Dictionary<DateTime, string>();
            Feriados.Add(new DateTime(2019, 11, 15), "Proclamação da República");
            Feriados.Add(Convert.ToDateTime("20/11/2019"), "Conciência Negra");
            Feriados.Add(new DateTime(2020, 01, 25), "Aniversario de São Paulo");

            var proclamacao = Feriados[new DateTime(2019, 11, 15)];

            foreach (var feriado in Feriados)
            {

                Console.WriteLine($"Feriados{feriado.Key.ToShortDateString()} : {feriado.Value}");

            }

            Console.WriteLine(Feriados.ContainsKey(Convert.ToDateTime("20/11/2019")));
            //verifica se no dicionario contem a chave
            Console.WriteLine(Feriados.ContainsValue("Conciência Negra"));
            //verifica se contem o valor no dicionario
        }
    }


}
