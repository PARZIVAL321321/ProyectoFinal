using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization; // Para que detecte la region en la que estamos

namespace ProyectoFinalV1
{
    public partial class FormGrafica : Form
    {
        public FormGrafica()
        {
            InitializeComponent();
            // Llamamos a nuestra grafica para mostrar nuestra grafica al mostrar este form
            Cargar_Grafica();
        }

        private void Cargar_Grafica()
        {
            // Indicamos nuestra conexion a la base de datos
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
            // Nos conectamos a nuestra base de datos
            conexion.Open();

            // Linea de comando SQL (solamente seleccionamos el monto de las cuentas que son clientes)
            string consulta = "SELECT nombre, monto FROM personas WHERE Tipo = 1";
            // Cargamos nuestro comando
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            // Ejecutamos nuestro comando
            MySqlDataReader lector = comando.ExecuteReader();

            // Al iniciar la grafica, se limpian los datos
            chart_Admin.Series.Clear();
            // Creamos nuestra serie para la grafica y la llamamos "Montos por Usuario"
            Series serie = new Series("Montos por Usuario");
            // Declaramos el tipo de grafico que vamos a usar, en este caso de pastel
            serie.ChartType = SeriesChartType.Pie;

            // Variable para almacenar el valor de las ventas totales
            double total_monto = 0;

            // Mientras haya algo que leer en nuestra base de datos
            while (lector.Read())
            {
                // Extraemos el valor Nombre de nuestra base de datos, el cual usaremos como nuestra leyenda
                string nombre = lector["Nombre"].ToString();
                // Extraemos el valor Monto de nuestra base de datos, el cual convertimos a double para que sea mejor trabajar con el en el grafico
                double monto = Convert.ToDouble(lector["Monto"]);

                total_monto += monto;

                // Agregamos esta informacion a la grafica (creamos un nuevo punto para la grafica)
                DataPoint punto = new DataPoint(0, monto);  // Al ser una grafica de pastel, no hay categorias por lo que se manda un "0"
                punto.LegendText = nombre;  // Asignamos el nombre a la leyenda
                serie.Points.Add(punto);    // Añadimos el punto al gráfico
            }

            // Tras haber llenado nuestra serie con la informacion necesaria, la agregamos a la grafica para que esta se muestre
            chart_Admin.Series.Add(serie);

            // Mostramos la leyenda en la parte inferior
            chart_Admin.Legends[0].Docking = Docking.Bottom;

            // Quitamos los nombres (etiquetas) para que estos no se muestren sobre nuestra grafica
            foreach (var point in serie.Points)
            {
                point.IsValueShownAsLabel = false;
            }

            // Muestra el total en un Label con formato de moneda de nuestra region
            label_VentaTotal.Text = "Venta total: " + total_monto.ToString("C", new CultureInfo("es-MX"));

        }

        // Boton para regresar al formAdmin
        private void button_Regresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chart_Admin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
