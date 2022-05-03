using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Sugerencia
    {
        private string mensaje { get; set; }
        private string fecha { get; set; }
        private string importancia { get; set; }
        private string tema { get; set; }
        public Sugerencia(string mensaje, string fecha, string importancia, string tema)
        {
            this.mensaje = mensaje;
            this.fecha = fecha;
            this.importancia = importancia;
            this.tema = tema;
        }
        public override string ToString()
        {
            return $"{mensaje} | {fecha} | {importancia} | {tema}";
        }
    }
}
