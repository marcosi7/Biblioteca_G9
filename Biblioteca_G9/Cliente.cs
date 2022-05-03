using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Cliente : Usuario
    {
        public Cliente(int ci, string nombre, string apellidos, string email, string direccion) : base(ci, nombre, apellidos, email, direccion)
        {

        }

        //ListaEnlazada miLista = new ListaEnlazada();
        ListaEnlazada consultas = new ListaEnlazada();
        ListaEnlazada sugerencias = new ListaEnlazada();

        #region Metodos
        public void llevarLibro()
        {

        }
        public void devolverLibro()
        {

        }
        public void hacerConsulta()
        {
            consultas.Display();
            Console.WriteLine("Escriba su consulta: ");

            string mensaje = Console.ReadLine();
            string fecha = DateTime.Now.ToString();  
            string respuesta = " - ";
            string pend = "PENDIENTE";

            Console.Clear();
            Consulta consulta = new Consulta(mensaje,fecha,respuesta,pend);
            consultas.Append(consulta);

            consultas.Display();

        }
        public void hacerSugerencia()
        {
            Console.WriteLine("Escriba su sugerencia: ");
            string mensaje = Console.ReadLine();

            string fecha = DateTime.Now.ToString();

            Console.Clear();

            Console.WriteLine("Porfavor seleccione nivel de importancia.");
            Console.WriteLine("[ 1 ] Muy Importante");
            Console.WriteLine("[ 2 ] Poco Importante");

            int input = int.Parse(Console.ReadLine());

            string importancia = "";

            if (input == 1)
            {
                importancia = "Muy Importante";
            }

            else if (input == 2)
            {
                importancia = "Poco Importante";
            }

            Console.Clear();

            Console.WriteLine("Escriba el tema: ");
            string tema = Console.ReadLine();

            Console.Clear();
            Sugerencia sugerencia = new Sugerencia(mensaje,fecha,importancia,tema);
            sugerencias.Append(sugerencia);

            sugerencias.Display();

        }
        #endregion

    }
}
