using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Bibliotecario
    {
        ListaEnlazada miLista = new ListaEnlazada();

        #region Metodos
        public void actualizarStock()
        {

        }
        public void contestarConsulta()
        {
            

        }
        public void hacerPedido()
        {
            Console.WriteLine("Ingrese Nombre del Pedido");
            string holas = Console.ReadLine();

            Console.WriteLine("Ingrese Nombre del Pedido");
            string hh = Console.ReadLine();

            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = holas;

            Nodo nuevoNodo2 = new Nodo();
            nuevoNodo2.Dato = hh;

            miLista.AgregarInicio(nuevoNodo);
            miLista.AgregarFinal(nuevoNodo2);

            miLista.AgregarItem(miLista.Inicio);

            //Console.WriteLine(pedido);
            //Pedido pedido = new Pedido();

        }
        public void mostrarUsuarios()
        {

        }
        #endregion
    }
}
