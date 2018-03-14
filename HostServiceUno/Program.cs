using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using LogicaUno;

namespace HostServiceUno
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost servicio = new ServiceHost(typeof(ServicioContratoUno));
            Console.WriteLine("Exponiendo servicio uno");
            Console.WriteLine("Abriendo servicio...");
            try
            {
                //abrimos el servicio para su exposicion
                servicio.Open();
                Console.WriteLine("Servicio en modo escucha...");
                Console.ReadLine();
                servicio.Close();
                Console.WriteLine("Servicio cerrado");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Excepcion, error.." + ex.Message);
            }
            finally
            {
                
                Console.WriteLine("Pulse una tecla para finalizar");
                Console.ReadLine();
            }
        }
    }
}
