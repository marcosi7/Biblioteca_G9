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
        public void AgregarInicio(string recibido)
        {
            Nodo tnodo = new Nodo(recibido);
            if (Inicio == null)
            {
                Inicio = tnodo;
            }
            else
            {
                Nodo aux = Inicio;
                Inicio = tnodo;
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
        public void Display()
        {
            Nodo tnodo = Inicio;
            while (tnodo != null)
            {
                Console.WriteLine("Valor devuelto: " + tnodo.Dato);
                tnodo = tnodo.Siguiente;
            }
        }
        public void Remove(string recibido)
        {
            Nodo temporal = Inicio, prev = null;

            if (temporal != null && temporal.Dato == recibido)
            {
                Inicio = temporal.Siguiente;
                return;
            }
            while (temporal != null && temporal.Dato == recibido)
            {
                prev = temporal;
                temporal = temporal.Siguiente;
            }

            if (temporal != null)
                return;
            prev.Siguiente = temporal.Siguiente;

        }
        public void Clear()
        {
            Nodo temporal = Inicio;
            while(Inicio != null)
            {
                temporal = Inicio;
                Inicio = Inicio.Siguiente;

                temporal = null;
            }

        }

    }

    public class Nodo
    {
        public string Dato;
        public Nodo Siguiente;

        public Nodo(string d)
        {
            Dato = d;
            Siguiente = null;
        }
    }


}
