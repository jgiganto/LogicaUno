using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaUno
{
    public class ServicioContratoUno : IContratoUno
    {
        public int GetNumeroDoble(int num)
        {
            return num * 2;
        }
    }
}
