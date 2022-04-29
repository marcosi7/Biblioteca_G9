using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    internal class Bibliotecario : Usuario
    {
        //bibliotecario hereda datos de usuario
        //bibliotecario hace un pedido
        //bibliotecario contesta consulta
        public Bibliotecario(int ci, string contraseña, string nombre, string apellidos, string email, string direccion) : base(ci, contraseña, nombre, apellidos, email, direccion)
        {
        }

        static void actualizarStock()
        {

        }
        static void contestarConsulta()
        {

        }
        static void hacerPedido()
        {

        }
    }
}
