using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Cliente : Usuario
    {
        ListaEnlazada mislibros = new ListaEnlazada();
        public Cliente(int ci, string nombre, string apellidos, string email, string direccion) : base(ci, nombre, apellidos, email, direccion)
        {

        }

        //ListaEnlazada miLista = new ListaEnlazada();
        ListaEnlazada consultas = new ListaEnlazada();
        ListaEnlazada sugerencias = new ListaEnlazada();

        #region Metodos
        public void llevarLibro()//prestar libro -- coger libro
        {
            Console.WriteLine("Seleccione un libro: ");
            Global.biblioteLibros.Display();
            Console.WriteLine("Ingrese el nombre del libro: ");
            string seleccion = Console.ReadLine();
            Console.Clear();
            Libro agregarMi =  Global.biblioteLibros.retornaOBJBuscaNomLibro(seleccion);
            mislibros.Append(agregarMi);
            Global.biblioteLibros.Remove(agregarMi);
            //listamos biblioteca
            Console.WriteLine("LIBROS: ");
            Global.biblioteLibros.Display();
            //listamos mis libros

            Console.WriteLine("MIS LIBROS: ");
            mislibros.Display();
            //
            //imprimos la lista global [se debe mostrar sin el libro]

            //imprimos la lista del cliente con el unico libro [se debe mostrar sin el libro]

            //1ro tendria que listar los libros disponibles
            //seleccionar 1 libro [agregar](LO PONEMOS NO disponible en la lista general)
            //seguir seleccionando
            //salir
            //Console.WriteLine(Global.name);
        }
        public void devolverLibro()
        {

            Console.WriteLine("Seleccione el libro a devolver libro: ");
            mislibros.Display();
            Console.WriteLine("Ingrese el nombre del libro: ");
            string seleccion = Console.ReadLine();
            Console.Clear();
            //primero buscamos el libro en mi lista
            Libro agregarMi =mislibros.retornaOBJBuscaNomLibro(seleccion);
            //eliminamos de milista
            mislibros.Remove(agregarMi);
            //agregamos a la biblioteca general

            Global.biblioteLibros.Append(agregarMi);
           
            //listamos biblioteca
            Console.WriteLine("LIBROS: ");
            Global.biblioteLibros.Display();
            //listamos mis libros
            Console.WriteLine("MIS LIBROS: ");
            mislibros.Display();
            //Devolviendo los libros
            //lista de libros prestados
            //seleccione el libro que desea devolver[eliminamos de nuestra lista cliente]
            //(lo agregamos a la lista global)
            //imprimimos la lista actual de prestamo sin ese libro 
            //ponemos opcion salir

        }
        public void hacerConsulta()
        {
            consultas.Display();
            Console.WriteLine("ingrese un Codigo");
            string cod = Console.ReadLine();
            
            Console.WriteLine("Escriba su consulta: ");
            string mensaje = Console.ReadLine();
            string fecha = DateTime.Now.ToString();  
            string respuesta = " - ";
            string pend = "PENDIENTE";

            Console.Clear();
            Consulta consulta = new Consulta(cod,mensaje,fecha,respuesta,pend);
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
