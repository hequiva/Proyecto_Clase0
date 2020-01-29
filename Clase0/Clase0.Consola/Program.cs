using Clase0.Consola.BEAN;
using Clase0.Consola.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteDAL cDAL = new ClienteDAL();
            cDAL.instanciaDatos(); //Creación para inicializar arreglos
            PaisDAL pDAL = new PaisDAL();
            pDAL.instanciaDatos();
            pDAL.llenadoDatos();


            ClienteBEAN cliBEAN = new ClienteBEAN();
            Console.Write("Ingrese nombre: ");
            cliBEAN.Nombres = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            cliBEAN.Apellidos = Console.ReadLine();
            pDAL.listarPaises();
            Console.Write("Ingrese código de país: ");
            cliBEAN.CodPais = Console.ReadLine();
            int cont = 0;
            cDAL.GuardarClientes(cont, cliBEAN);//Método void con parametro con variable clase
            cDAL.ListarClientes();

            Console.Read();
            //Implementar sección de código para que pueda permitir preguntar si se desea continuar.
            //Implementar método para que no muestre el código del pais, si no el nombre del pais.
        }
    }
}
