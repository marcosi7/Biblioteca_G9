using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Cliente
    {
        //cliente hereda datos de usuario
        //cliente hace una consulta
        //cliente lleva un libro
        //cliente escribe una sugerencia

        ListaEnlazada miLista = new ListaEnlazada();

        void AgregarItem(Nodo unNodo)
        {
            if (unNodo != null)
            {
                Console.WriteLine(unNodo.Nombre);
                AgregarItem(unNodo.Siguiente);
            }
        }

        #region Metodos
        public void llevarLibro()
        {
            Console.WriteLine("Ingrese Nombre del Pedido");
            string holas = Console.ReadLine();

            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Nombre = holas;

            miLista.AgregarInicio(nuevoNodo);

            AgregarItem(miLista.Inicio);
        }
        public void devolverLibro()
        {

        }
        public void hacerConsulta()
        {

        }
        public void hacerSugerencia()
        {

        }
        #endregion

    }
}
