using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Detalle_Pedido
    {
        private int cantidad { get; set; }
        private int precio { get; set; }
        public Detalle_Pedido(int cantidad, int precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }
        public override string ToString()
        {
            return $"{cantidad} | {precio}";
        }
    }
}
