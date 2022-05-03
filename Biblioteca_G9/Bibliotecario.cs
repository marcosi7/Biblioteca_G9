using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Bibliotecario : Usuario
    {
        public Bibliotecario(int ci, string nombre, string apellidos, string email, string direccion) : base(ci, nombre, apellidos, email, direccion)
        {

        }

        ListaEnlazada miLista = new ListaEnlazada();
        ListaEnlazada libros = new ListaEnlazada();
        ListaEnlazada pedidos = new ListaEnlazada();

        #region Metodos
        public void agregarLibros()
        {
            libros.Display();

            Console.WriteLine("Ingrese Nombre del Libro: ");
            string titulo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese Autor: ");
            string autor = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese Edicion: ");
            string edicion = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese Genero: ");
            Console.WriteLine("[1] Terror");
            Console.WriteLine("[2] Drama");
            Console.WriteLine("[3] Educativo");
            Console.WriteLine("[4] Ficcion");
            Console.WriteLine("[5] Otro");

            int input = int.Parse(Console.ReadLine());

            string genero = "";

            if (input == 1)
            {
                genero = "Terror";
            }
            else if (input == 2)
            {
                genero = "Drama";
            }
            else if (input == 3)
            {
                genero = "Educativo";
            }
            else if (input == 4)
            {
                genero = "Ficcion";
            }
            else if (input == 5)
            {
                genero = "Otro";
            }

            Console.Clear();

            Console.WriteLine("Ingrese Editorial: ");
            string editorial = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese numero Stock: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Clear();

            Libro libro = new Libro(titulo, autor, edicion, genero, editorial, stock);
            libros.Append(libro);

            Console.WriteLine("LIBROS: ");
            libros.Display();

        }
        public void contestarConsulta()
        {
            

        }
        public void hacerPedido()
        {
            libros.Display();

            Console.WriteLine("Ingrese numero pedido: ");
            int nPedido = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese Precio Bs.: ");
            int precio = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese Precio Total Bs.: ");
            int precioTotal = int.Parse(Console.ReadLine());
            Console.Clear();

            string fecha = DateTime.Now.ToString();

            Pedido pedido = new Pedido(nPedido,cantidad,precio,precioTotal,fecha);
            pedidos.Append(pedido);

            Console.WriteLine("Lista Pedidos: ");
            pedidos.Display();

        }
        #endregion
    }
}
