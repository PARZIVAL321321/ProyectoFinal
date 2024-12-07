using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalV1
{


    // Clase que representa a las personas en nuestra base de datos
    public class Persona
    {
        int id;
        string nombre;
        string cuenta;
        string contra;
        int monto;
        int tipo;

        // Constructor por parametros
        public Persona(int id, string nombre, string cuenta, string contra, int monto, int tipo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cuenta = cuenta;
            this.Contra = contra;
            this.Monto = monto;
            this.Tipo = tipo;
        }

        // Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Monto { get => monto; set => monto = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
