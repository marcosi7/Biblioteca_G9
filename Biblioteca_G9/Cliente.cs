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

        ListaEnlazada miLista = new ListaEnlazada();

        #region Metodos
        public void llevarLibro()
        {
            Console.WriteLine("Ingrese Nombre del Pedido");
            string holas = Console.ReadLine();

            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = holas;

            miLista.AgregarInicio(nuevoNodo);

            miLista.AgregarItem(miLista.Inicio);

        }
        public void devolverLibro()
        {

        }
        public void hacerConsulta()
        {
            Console.WriteLine("Escriba su consulta: ");
            string mensaje = Console.ReadLine();

            string fecha = DateTime.Now.ToString();  
            string respuesta = " - ";
            bool pendiente = true;

            //Consulta consulta = new Consulta(mensaje,fecha,respuesta,pendiente);
            //Console.WriteLine("consulta");

        }
        public void hacerSugerencia()
        {
            Console.WriteLine("Escriba su sugerencia: ");
            string mensaje = Console.ReadLine();

            string fecha = DateTime.Now.ToString();

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

            //Sugerencia sugerencia = new Sugerencia(mensaje,fecha,importancia);

        }
        #endregion

    }
}
