using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_del_sena.Models
{
    public class Libro : Publicacion
    {
        public Guid ISBN { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public double Precio { get; set; }


        public Libro(string titulo, string autor, string genero, int fechaDePublicacion, double precio)
        {
            this.ISBN = Guid.NewGuid();
            this.Titulo = titulo;
            this.Autor = autor;
            this.Genero = genero;
            this.FechaDePublicacion = new DateOnly(fechaDePublicacion, 1, 1);
            this.Precio = precio;
        }

        public void MostrarLibro()
        {

        }






    }

}