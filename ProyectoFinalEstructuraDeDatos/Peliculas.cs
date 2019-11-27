using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class Peliculas : Datos
    {
        public Peliculas(string formato, string titulo, int año, string genero, string descripcion, int rating)
        {
            this.Formato = formato;
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Descripcion = descripcion;
            this.Rating = rating;
        }
    }
}
