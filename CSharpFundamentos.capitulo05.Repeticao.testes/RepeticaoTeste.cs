using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpFundamentos.capitulo05.Repeticao.testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void TabuadaTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine("==============================");
                Console.Write(new string('=', 10) + "\n");


                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }

                //Console.WriteLine("==============================");
                Console.Write(new string('=', 10) + "\n");
            }
        }

        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;

            for (Console.WriteLine("INICIOU"); i <= 3; Console.WriteLine(i))
            {
                i++;
            }
            /*
             for(1. INICIALIZAÇÃO; 2 CONDIÇÃO; 4 PÓS EXECUÇÃO)
             {
             
                3 = EXECUÇÃO 
            
            }
             */
        }

        [TestMethod]
        public void ForApenasComCondicao()
        {
            var i = 1;

            for (; i <= 3 ; )
            {
                Console.WriteLine(i);
                i++;
            }
        }

        [TestMethod]
        public void ContinueTeste()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i <= 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTeste()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }

    }
}
