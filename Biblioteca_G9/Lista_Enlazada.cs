﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class ListaEnlazada
    {
        public Nodo Inicio;
        static Nodo f;
        static Nodo t;

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
        public void MostrarLista()
        {
            Nodo tnodo = Inicio;
            while (tnodo != null)
            {
                Console.WriteLine("Valor devuelto: " + tnodo.Dato);
                tnodo = tnodo.Siguiente;
            }
        }

        public void Eliminar(string recibido)
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
        //********agregando nuevos metodos*************
          public void append(object datos)
    {
        Nodo toAdd = new Nodo();

        toAdd.Dato = datos;
        toAdd.Siguiente = Inicio;
        this.Inicio = toAdd;
    }
     
        //reverse()
         public void reverse(){
        //asisnamos los nuevos valores a los nodos
        Nodo current = Inicio;
        bool sw = true;
        Nodo temp =null ;
        while (current != null)
        {
            //para el primer y antiguo valor sin modificar
             Nodo siguienteNodo =current.Siguiente ;//siguiente nodo antigui que le sigue
            if(sw){
            current.Siguiente = temp;//primer nodo 1 a null
            temp = current;//guardamos el primer nodo con su nuevo siguiente 
            sw = false;
            }else{
                current.Siguiente = temp;
                temp = current;
            }
            current = siguienteNodo;
        }

        Inicio = temp;
    }
         //list.count(x)// la cantidad de repeticiones de un elemento x
        public int count(object obj) { 
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
         //list.index(x) *6
        //Returns the index of the first element with the specified value
        public int index(object data) { 
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
        //list.copy() *10
        public ListaEnlazada copy() {
            ListaEnlazada lista = new ListaEnlazada();
            lista.Inicio = Inicio;
            return lista;
        
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

        public Nodo(string d)
        {
            Dato = d;
            Siguiente = null;
        }
    }


}
