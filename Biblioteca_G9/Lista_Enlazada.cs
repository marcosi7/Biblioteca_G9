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

        public void Push(string recibido)
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
        public void Append(string recibido)
        {
            Nodo tnodo = new Nodo(recibido);
            if (Inicio == null)
            {
                Inicio = tnodo;
            }
            else
            {
                Nodo aux = LastItem(Inicio);
                aux.Siguiente = tnodo;
            }
        }
        public Nodo LastItem(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return LastItem(unNodo.Siguiente);
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
        public void Display()
        {
            Nodo tnodo = Inicio;
            while (tnodo != null)
            {
                Console.WriteLine(tnodo.Dato + " | ");
                tnodo = tnodo.Siguiente;
            }
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
        public void Reverse()
        {
            Nodo current = Inicio;
            bool sw = true;
            Nodo temp =null ;

            while (current != null)
            {
                Nodo siguienteNodo =current.Siguiente ;
                if(sw){
                current.Siguiente = temp;
                temp = current;
                sw = false;
                }else{
                    current.Siguiente = temp;
                    temp = current;
                }
                current = siguienteNodo;
            }

            Inicio = temp;
        }
        public void printAllNodes()
        {
            int count = 0;
            Nodo current = Inicio;
            while (current != null)
            {
                Console.Write(current.Dato + "("+count+") - ");
            
                current = current.Siguiente;
                count=count +1;
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
