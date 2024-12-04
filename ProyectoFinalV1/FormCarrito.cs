using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalV1
{
    public partial class FormCarrito : Form
    {
        //Declaramos un folio para la compra
        private int folio;
        //Propiedad para el folio
        public int Folio { get; set; }

        // Creamos nuestra lista que va a almacenar la lista que nos llego en el constructor
        List<Juegos> carrito = new List<Juegos>();

        // Constructor vacio
        public FormCarrito()
        {
            InitializeComponent();
        }

        // Constructor por parametros (recibimos la lista que representa nuestro carrito de compras)
        public FormCarrito(List<Juegos> carrito_constructor)
        {
            // Llamamos a nuestra funcion importante
            InitializeComponent();

            // Guardamos la lista que nos llego a nuestra variable local
            carrito = carrito_constructor;

            // Llenamos el DataGridView con los datos del carrito
            LlenarDataGridView();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void FormCarrito_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btGenerarTicket_Click(object sender, EventArgs e)
        {
            GeneradorPdf generador = new GeneradorPdf(folio);
            generador.GenerarPDF();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_SeguirComprando_Click(object sender, EventArgs e)
        {
            // Cerramos este form, y regresamos al anterior
            this.Dispose();
        }

        // Método para llenar el DataGridView con los datos del carrito
        private void LlenarDataGridView()
        {
            // Agrupamos los juegos por nombre y plataforma, y contamos la cantidad de veces que se repiten
            var juegosAgrupados = carrito //Var es una palabra reservada de C# que nos permite declarar una variable sin especificar su tipo
                .GroupBy(j => new { j.Nombre, j.Plataforma, j.Precio })//GroupBy es una funcion de la libreria LINQ funciona para agrupar los datos
                .Select(g => new//Select es una funcion de la libreria LINQ funciona para seleccionar los datos
                {
                    Nombre = g.Key.Nombre,//Key es una propiedad de la clase GroupBy que nos permite acceder a la clave por la que se agruparon los datos
                    Plataforma = g.Key.Plataforma,//Key es una propiedad de la clase GroupBy que nos permite acceder a la clave por la que se agruparon los datos
                    Cantidad = g.Count(),//Count es una funcion de la libreria LINQ que nos permite contar los elementos de un grupo
                    Precio = g.Key.Precio* g.Count()//Count es una funcion de la libreria LINQ que nos permite contar los elementos de un grupo
                })
                .ToList();//ToList es una funcion de la libreria LINQ que nos permite convertir los datos a una lista

            // Llenamos el DataGridView con los datos agrupados
            foreach (var juego in juegosAgrupados)
            {
                dataGridView_CarritodeCompras.Rows.Add(juego.Nombre, juego.Plataforma, juego.Cantidad, juego.Precio);
            }
        }
    }
}
