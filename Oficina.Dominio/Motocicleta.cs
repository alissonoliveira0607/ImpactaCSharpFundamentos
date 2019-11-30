using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominio
{

    //Todo: OO - Herança(:)
    public class Motocicleta : Veiculo
    {
        public TipoQuadro TipoQuadro { get; set; }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
