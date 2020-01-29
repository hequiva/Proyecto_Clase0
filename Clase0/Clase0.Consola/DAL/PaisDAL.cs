using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0.Consola.DAL
{
    public class PaisDAL
    {
        string[] codPais;
        string[] nombrePais;

        int cantDatos = 3;
        public void instanciaDatos()
        {
            codPais = new string[cantDatos];
            nombrePais = new string[cantDatos];
        }

        public void llenadoDatos()
        {
            codPais[0] = "C001_RD";
            nombrePais[0] = "República Dominicana";

            codPais[1] = "C002_BL";
            nombrePais[1] = "Bolivia";

            codPais[2] = "C003_CR";
            nombrePais[2] = "Costa Rica";
        }

        public void listarPaises()
        {
            Console.WriteLine("\nCódigo         Nombre");
            for (int i = 0; i < cantDatos; i++)
            {
                Console.WriteLine(codPais[i] + " - " + nombrePais[i]);
            }
        }
    }
}
