using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class ListaEnlazada
    {
        public Nodo Inicio;
        public Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        //append
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
        //2
        public void AgregarFinal(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;
            }
        }
        //listar
        public void AgregarItem(Nodo unNodo)
        {
            if (unNodo != null)
            {
                Console.WriteLine("Valor devuelto: " + unNodo.Dato);
                AgregarItem(unNodo.Siguiente);
            }
        }

    }

    public class Nodo
    {
        public string Dato;
        public Nodo Siguiente;
    }


}
