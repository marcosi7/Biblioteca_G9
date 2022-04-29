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
        private string contraseña { get; set; }
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private string email { get; set; }
        private string direccion { get; set; }

        public Usuario(int ci, string contraseña, string nombre, string apellidos, string email, string direccion)
        {
            this.ci = ci;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.direccion = direccion;
        }
        public override string ToString()
        {
            return $"{ci} | {contraseña} | {nombre} | {apellidos} | {email} | {direccion}";
        }
    }
}
