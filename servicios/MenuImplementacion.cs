using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosCollection.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int respuestaUsuario()
        {
            int opcionIntroducida;
            Console.WriteLine("######################################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Introducir cliente");
            Console.WriteLine("2. Quitar cliente");
            Console.WriteLine("3. Ver cola");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
    }
}
