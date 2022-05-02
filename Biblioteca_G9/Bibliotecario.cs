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
            /*Console.Clear();
            Console.WriteLine("Ingrese C.I.: ");
            int Nci = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Constraseña: ");
            string Ncontraseña = Console.ReadLine();

            Console.WriteLine("Ingrese Nombres: ");
            string Nnombre = Console.ReadLine();

            Console.WriteLine("Ingrese Apellidos: ");
            string Napellido = Console.ReadLine();

            Console.WriteLine("Ingrese Email: ");
            string Nemail = Console.ReadLine();

            Console.WriteLine("Ingrese Direccion: ");
            string Ndireccion = Console.ReadLine();

            Cliente cliente = new Cliente(Nci, Ncontraseña, Nnombre, Napellido, Nemail, Ndireccion);

            Console.WriteLine("Usuario: " + cliente);
            Console.ReadKey();*/
        }
        #endregion
    }
}
