using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    #region Prueba Lista Enlazada
    class ListaEnlazada
    {
        public Nodo Inicio;

        public void AgregarInicio(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;
            }
        }
    }
    class Nodo
    {
        public string Nombre;
        public Nodo Siguiente;
    }
    #endregion
    public class Bibliotecario
    {
        //bibliotecario hereda datos de usuario
        //bibliotecario hace un pedido
        //bibliotecario contesta consulta

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
            nuevoNodo.Nombre = holas;

            Nodo nuevoNodo2 = new Nodo();
            nuevoNodo2.Nombre = hh;

            miLista.AgregarInicio(nuevoNodo);
            miLista.AgregarInicio(nuevoNodo2);

            AgregarItem(miLista.Inicio);

            Pedido pedido = new Pedido();
            //Console.WriteLine(pedido);


            //Pedido pedido = new Pedido();

        }
        public void mostrarUsuarios()
        {

        }
        #endregion
    }
}
