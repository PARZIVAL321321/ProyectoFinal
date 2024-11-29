using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalV1
{
    // Clase para representar la tabla Personas en nuestra base de datos
    public class Personas
    {
        // Miembros de la clase (que son parte de la tabla de la base de datos)
        private int id;
        private string nombre;
        private string cuenta;
        private string contra;
        private int monto;
        private int tipo;

        // Constructor vacio de la clase
        public Personas()
        {
            nombre = string.Empty;
            cuenta = string.Empty;
            contra = string.Empty;
        }

        // Constructor por parametros de la clase
        public Personas(int id, string nombre, string cuenta, string contra, int monto, int tipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Monto = monto;
            this.Tipo = tipo;
        }

        // Propiedades de los miembros de la clase
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
