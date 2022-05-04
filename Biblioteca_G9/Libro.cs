using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_G9
{
    public class Libro
    {
        public string titulo { get; set; }
        private string autor { get; set; }
        private string edicion { get; set; }
        private string genero { get; set; }
        private string editorial { get; set; }
        private int stock { get; set; }

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
            return $"(T){titulo}, (A){autor}, (E){edicion}, (G){genero}, (E){editorial}, (S){stock}";
        }

    }
}
