using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalEstructuraDeDatos
{
    class Series : Datos
    {
        public Series(string formato, string titulo, int año, string genero, string descripcion, int rating, int temporadas, string productor)
        {
            this.Formato = formato;
            this.Titulo = titulo;
            this.Año = año;
            this.Genero = genero;
            this.Descripcion = descripcion;
            this.Rating = rating;
            this.Temporadas = temporadas;
            this.Productor = productor;
        }
    }
}
