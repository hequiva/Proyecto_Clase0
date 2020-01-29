using Clase0.Consola.BEAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0.Consola.DAL
{
    public class ClienteDAL
    {
        //Creación de variables en una clase DAO
        int[] id ;
        string[] nombres;
        string[] apellidos;
        string[] codPais;

        int cantDatos = 10;
        public void instanciaDatos()
        {
            id = new int[cantDatos];
            nombres = new string[cantDatos];
            apellidos = new string[cantDatos];
            codPais = new string[cantDatos];
        }

        public void GuardarClientes(int num, ClienteBEAN cliBean)
        {
            id[num] = num;
            nombres[num] = cliBean.Nombres;
            apellidos[num] = cliBean.Apellidos;
            codPais[num] = cliBean.CodPais;
        }

        public void ListarClientes()
        {
            Console.WriteLine("\nLista de Clientes");
            for (int i = 0; i < cantDatos; i++)
            {
                if (nombres[i] != null)
                {
                    Console.Write((id[i] + 1) + " ");
                    Console.Write(nombres[i] + " ");
                    Console.Write(apellidos[i] + " ");
                    Console.Write(codPais[i] + "\n");
                }
            }
        }
    }
}
