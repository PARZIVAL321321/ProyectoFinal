using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalV1
{

    // Clase para representar la informacion de nuestros juegos
    public class Juegos
    {
        // Miembros de la clase (datos que estan en nuestra base de datos)
        int id;
        string nombre;
        string imagen;
        string genero;
        string plataforma;
        string modalidad;
        int precio;
        int stock;

        // Constructor por parametros
        public Juegos(int id, string nombre, string imagen, string genero, string plataforma, string modalidad, int precio, int stock)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Imagen = imagen;
            this.Genero = genero;
            this.Plataforma = plataforma;
            this.Modalidad = modalidad;
            this.Precio = precio;
            this.Stock = stock;
        }

        // Propiedades de nuestros miembros
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Plataforma { get => plataforma; set => plataforma = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
