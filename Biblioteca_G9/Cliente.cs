using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    internal class Cliente : Usuario
    {
        //cliente hereda datos de usuario
        //cliente hace una consulta
        //cliente lleva un libro
        //cliente escribe una sugerencia
        public Cliente(int ci, string contraseña, string nombre, string apellidos, string email, string direccion) : base(ci, contraseña, nombre, apellidos, email, direccion)
        {
        }

        public static void llevarLibro()
        {
            Console.WriteLine("Hola");
        }
        static void devolverLibro()
        {

        }
        static void hacerConsulta()
        {

        }

    }
}
