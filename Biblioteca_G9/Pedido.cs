using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Pedido
    {
        //public Detalle_Pedido detalle_pedido = new Detalle_Pedido();

        private int numeroPedido { get; set; }
        private int cantidad { get; set; }
        private int precio { get; set; }
        private int precioTotal { get; set; }
        private string fecha { get; set; }
        private Detalle_Pedido dp = null;

        public Pedido(int numeroPedido, int cantidad, int precio, int precioTotal, string fecha)
        {
            this.numeroPedido = numeroPedido;
            this.cantidad = cantidad;
            this.precio = precio;
            this.precioTotal = precioTotal;
            this.fecha = fecha;
            this.dp = new Detalle_Pedido(cantidad,precio);
        }
        public void mostrarDetalles_Pedido()
        {
            if (dp != null)
            {
                Console.WriteLine("{0} tiene", numeroPedido);
                dp.ToString();
            }
            else
            {
                Console.WriteLine("{0} no tiene detalles de pedido", numeroPedido);
            }
        }
        public override string ToString()
        {
            return $"(N){numeroPedido}, (T){precioTotal}, (F){fecha}, (Detalles){dp}";
        }
    }
}
