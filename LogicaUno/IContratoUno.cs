using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace LogicaUno
{
    [ServiceContract]
    public interface IContratoUno
    {
        [OperationContract]
        int GetNumeroDoble(int num);
    }
}
