﻿using System;
using System.Collections.Generic;

namespace Oficina.Dominio
{

    //ToDo: OO - Classe ou Abstração(:)
    public abstract class Veiculo
    {
        private string placa;

      public string Placa
      {
          get { return placa.ToUpper(); }

          set { placa = value.ToUpper(); }

      }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public string Observacao { get; set; }
        public Modelo Modelo { get; set; }
        public Cambio Cambio { get; set; }
        public Combustivel Combustivel { get; set; }

        //public string Placa
        //{
        //    get
        //    {
        //        return placa.ToUpper();
        //    }

        //    set
        //    {
        //        placa = value.ToUpper();
        //    }
        //}

        public abstract List<string> Validar();


        //protected acessivel apenas para as derivadas
        protected List<string> ValidarBase()
        {
            var erros = new List<string>();

            if (Ano < 1980 || (Ano - DateTime.Now.Year) > 1)
            {
                erros.Add($"O Ano Informado {Ano} não é Valido");
            }

            return erros;
        }


    }
}
