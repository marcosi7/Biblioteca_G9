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
            string titulo = Console.ReadLine();
            string autor = Console.ReadLine();
            string genero = Console.ReadLine();
            string editorial = Console.ReadLine();
            string edicion = Console.ReadLine();
            int stock = int.Parse(Console.ReadLine());

            Libro libra = new Libro(titulo,autor,genero,editorial,edicion,stock);

            Console.WriteLine(libra);

        }
        public void contestarConsulta()
        {

        }
        public void hacerPedido()
        {
            Console.WriteLine("Ingrese numero pedido: ");
            int nPedido = int.Parse(Console.ReadLine());
            int precioTotal = int.Parse(Console.ReadLine());
            string fecha = DateTime.Now.ToString();


            Pedido pedido = new Pedido(nPedido,precioTotal,fecha);

        }
        #endregion
    }
}
