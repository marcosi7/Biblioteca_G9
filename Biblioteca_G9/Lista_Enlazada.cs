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

        public void Push(object recibido)
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
        public void Append(object recibido)
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
        //public void Remove(object recibido)
        //{
        //    Nodo temporal = Inicio, prev = null;

        //    if (temporal != null && temporal.Dato == recibido)
        //    {
        //        Inicio = temporal.Siguiente;
        //        return;
        //    }
        //    while (temporal != null && temporal.Dato == recibido)
        //    {
        //        prev = temporal;
        //        temporal = temporal.Siguiente;
        //    }

        //    if (temporal != null)
        //        return;
        //    prev.Siguiente = temporal.Siguiente;

        //}
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
            Nodo temp = null;

            while (current != null)
            {
                Nodo siguienteNodo = current.Siguiente;
                if (sw)
                {
                    current.Siguiente = temp;
                    temp = current;
                    sw = false;
                }
                else
                {
                    current.Siguiente = temp;
                    temp = current;
                }
                current = siguienteNodo;
            }

            Inicio = temp;
        }
        public int Count(object obj) { 
            int cantidad = 0;

            //int count = 0;
            Nodo current = Inicio;
            while (current != null)
            {
                
                //if (current.Dato == obj) {
                    if (obj.Equals(current.Dato)){
                        cantidad = cantidad + 1;
                }
                current = current.Siguiente;
            }
            return cantidad;
        }
        public int Index(object data)
        { 
            int index = 0;
            Nodo current = Inicio;
            while (current != null)
            {
                
                if (data.Equals(current.Dato))
                {
                    break; 
                }
                index = index + 1;
                current = current.Siguiente;
            }
            return index;
        }
        //retorna el objeto encontrado 
        public Libro retornaOBJBuscaNomLibro(string data)
        {
            Libro index = null;
            Nodo current = Inicio;
            while (current != null)
            {
                Libro obj = (Libro)current.Dato;
                if (data.Equals(obj.titulo))
                {
                    index = (Libro) obj;
                    break;
                }
                
                current = current.Siguiente;
            }
            return index;
        }

          public Consulta retornaOBJBETOconsulta(string data)
        {
            Consulta index = null;
            Nodo current = Inicio;
            while (current != null)
            {
                Consulta obj = (Consulta)current.Dato;
                if (data.Equals(obj.codigo))
                {
                    index = (Consulta) obj;
                    break;
                }
                
                current = current.Siguiente;
            }
            return index;
        }

        public ListaEnlazada Copy()
        {
            ListaEnlazada lista = new ListaEnlazada();
            lista.Inicio = Inicio;
            return lista;
        
        }
        //eliminar
        public void Remove(object data)
        {


            Nodo current = Inicio;
            Nodo tnodo = null;
            Nodo node2 = null;

            while (current != null)
            {

                if (!(data.Equals(current.Dato)))
                {
                    node2 = new Nodo(null);
                    node2.Dato = current.Dato;//insertamos el nuevo dato
                    node2.Siguiente = tnodo;//ponemos como siguiente
                    tnodo = node2;//ultimo nodo
                }
                current = current.Siguiente;
            }
            Inicio = node2;

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
        public object Dato;
        public Nodo Siguiente;

        public Nodo(object d)
        {
            Dato = d;
            Siguiente = null;
        }
    }


}
