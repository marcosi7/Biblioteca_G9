using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Pedido
    {
        private int numeroPedido { get; set; }
        private int precioTotal { get; set; }
        private string fecha { get; set; }
        public Pedido(int numeroPedido, int precioTotal, string fecha)
        {
            this.numeroPedido = numeroPedido;
            this.precioTotal = precioTotal;
            this.fecha = fecha;
        }
        public override string ToString()
        {
            return $"{numeroPedido} | {precioTotal} | {fecha}";
        }
    }
}
