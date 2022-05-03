using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string edicion;
        private string genero;
        private string editorial;
        private int stock;

        public Libro(string titulo, string autor, string edicion, string genero, string editorial, int stock)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.edicion = edicion;
            this.genero = genero;
            this.editorial = editorial;
            this.stock = stock;
        }
        public override string ToString()
        {
            return $"{titulo} | {stock}";
        }

    }
}
