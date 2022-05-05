using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Consulta
    {
        public string codigo { get; set; }
        private string mensaje { get; set; }
        private string fecha { get; set; }
        private string respuesta { get; set; }
        private string pendiente { get; set; }
        public Consulta(string cod,string mens, string date, string answer, string status)
        {
            this.codigo=cod;
            this.mensaje = mens;
            this.fecha = date;
            this.respuesta = answer;
            this.pendiente = status;
        }
        public override string ToString()
        {
            return $"{codigo}|{mensaje} | {fecha} | {respuesta} | {pendiente}";
        }
    }
}
