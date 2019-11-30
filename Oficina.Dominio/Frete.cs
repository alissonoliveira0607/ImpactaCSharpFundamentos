using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{
    public class Frete
    {

        //CTOR PARA CRIAR UM CONSTRUTOR
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="uf"></param>
        public Frete(decimal valor, UF uf)
        {
            this.Valor = Valor;
            this.UF = uf;
            Calcular();
        }


        public Cliente Cliente { get; set; }
        public decimal Valor { get; private set; }
        public UF UF { get; private set; }
        public decimal Percentual { get; private set; }
        public decimal Total { get; set; }

        private void Calcular()
        {

            switch (UF)
            {
                case UF.SP:
                    Percentual = 0.2M;
                    break;
                case UF.RJ:
                    Percentual = 0.3m;
                    break;
                case UF.MG:
                    Percentual = 0.35m;
                    break;
                case UF.AM:
                    Percentual  = 0.6m;
                    break;                            
                default:
                    Percentual = 0.7m;
                    break;
            }


            //switch (ufComboBox.Text.ToUpper())
            //{
            //    case "SP":
            //        percentualFrete = 0.2m;
            //        break;
            //    case "RJ":
            //        percentualFrete = 0.3m;
            //        break;
            //    case "MG":
            //        percentualFrete = 0.35m;
            //        break;
            //    case "AM":
            //        percentualFrete = 0.6m;
            //        break;
            //    default:
            //        percentualFrete = 0.75m;
            //        break;
            //}



            Total = ((1 + Percentual) * Valor);
        }

    }
}
