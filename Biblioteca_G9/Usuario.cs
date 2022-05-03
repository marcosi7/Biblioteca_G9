using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Usuario
    {
        private int ci { get; set; }
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private string email { get; set; }
        private string direccion { get; set; }

        public Usuario(int ci, string nombre, string apellidos, string email, string direccion)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.direccion = direccion;
        }
        public override string ToString()
        {
            return $"Id Usuario: {ci} | Nombres y Apellidos: {nombre} {apellidos} | Email: {email}";
        }
    }
}
