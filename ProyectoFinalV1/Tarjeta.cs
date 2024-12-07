using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalV1
{
    // Clase que representa toda la informacion de la tarjeta
    public class Tarjeta
    {
        string nombre;
        long numero;
        int mes;
        int ano;
        int year;
        int cvv;

        // Constructor por parametros
        public Tarjeta(string nombre, long numero, int mes, int year, int cvv)
        {
            this.nombre = nombre;
            this.numero = numero;
            this.mes = mes;
            this.year = year;
            this.cvv = cvv;
        }

        // Propiedadaes
        public string Nombre { get => nombre; set => nombre = value; }
        public long Numero { get => numero; set => numero = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Year { get => year; set => year = value; }
        public int Cvv { get => cvv; set => cvv = value; }
    }
}
