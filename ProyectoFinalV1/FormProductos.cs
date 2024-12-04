using MySql.Data.MySqlClient; // Para poder usar nuestra base de datos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace ProyectoFinalV1
{
    public partial class FormProductos : Form
    {
        // Creamos nuestra lista de tipo Juegos, la cual nos servira para mostrar los juegos
        List<Juegos> lista = new List<Juegos>();

        // Creamos otra lista donde se va a guardar el carrito de compras
        List<Juegos> carrito = new List<Juegos>();

        // Variable para llevar un conteo de los objetos que han sido agregados al carrito
        int conteo_carrito;

        public FormProductos()
        {
            InitializeComponent();
        }

        // Constructor por parametros (recibe el nombre de la persona que ingreso)
        public FormProductos(string nombre)
        {
            // Llamamos la funcion importante
            InitializeComponent();
            // Ponemos le nombre recibido en nuestro textBox
            textBox_Nombre.Text = nombre;
            // Al iniciar el form, cargamos los juegos
            Cargar_Juegos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormProductos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            ReleaseCapture();
        }

        // Funcion para ir al form de nuestro carrito
        private void button_Carrito_Click(object sender, EventArgs e)
        {
            // Creamos nuestro form para el carrito
            FormCarrito formCarrito = new FormCarrito(carrito);

            // Ocultamos el form actual
            this.Hide();
            
            // Mostramos el nuevo form (usando ShowDialog)
            formCarrito.ShowDialog();

            // Volvemos a mostrar este form
            this.Show();
        }

        // Funcion para mostrar nuestros juegos
        private void Cargar_Juegos()
        {

            int id = 0;

            try
            {
                // Creamos nuestra variable para la base de datos, y pasamos nuestra informacion
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
                // Abrimos nuestra base de datos
                conexion.Open();

                // Linea de comando de SQL
                string consulta = "SELECT * FROM juegos";
                // Cargamos nuestro comando
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Ejecutamos el comando
                MySqlDataReader lector = comando.ExecuteReader();

                // Mientras haya algo que leer
                while (lector.Read())
                {
                    // Creamos las variables que vamos a usar
                    string nombre;
                    string imagen;
                    string genero;
                    string plataforma;
                    string modalidad;
                    int precio;
                    int stock;

                    // Asignamos los valores recuperados a nuestras variables
                    nombre = lector["Nombre"].ToString();
                    imagen = lector["Imagen"].ToString();
                    genero = lector["Genero"].ToString();
                    plataforma = lector["Plataforma"].ToString();
                    modalidad = lector["Modalidad"].ToString();
                    // Convertimos el valor recuperado a string, para despues pasarlo a entero
                    precio = int.Parse(lector["Precio"].ToString());
                    stock = int.Parse(lector["Stock"].ToString());

                    // Creamos el objeto de nuestra clase
                    Juegos temp = new Juegos(id++, nombre, imagen, genero, plataforma, modalidad, precio, stock);

                    // Agregamos este objeto a nuestra lista
                    lista.Add(temp);
                }

                // Recorremos nuestra lista
                for (int i = 0; i < lista.Count; i++)
                {
                    // Para el primer elemento de nuestra lista
                    if (i == 0)
                    {
                        // Para nuestro primer objeto
                        TituloJuego1.Text = lista[i].Nombre;
                        ModalidadJuego1.Text = lista[i].Modalidad;
                        GeneroJuego1.Text = lista[i].Genero;
                        PlataformaJuego1.Text = lista[i].Plataforma;
                        StockJuego1.Text = lista[i].Stock.ToString();
                        PrecioJuego1.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego1.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego1.Image = null;
                        }
                    }
                    // Para el segundo elemento de nuestra lista
                    else if (i == 1)
                    {
                        // Para nuestro primer objeto
                        TituloJuego2.Text = lista[i].Nombre;
                        ModalidadJuego2.Text = lista[i].Modalidad;
                        GeneroJuego2.Text = lista[i].Genero;
                        PlataformaJuego2.Text = lista[i].Plataforma;
                        StockJuego2.Text = lista[i].Stock.ToString();
                        PrecioJuego2.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego2.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego2.Image = null;
                        }

                    }
                    // Para el tercer elemento de nuestra lista
                    else if (i == 2)
                    {
                        // Para nuestro primer objeto
                        TituloJuego3.Text = lista[i].Nombre;
                        ModalidadJuego3.Text = lista[i].Modalidad;
                        GeneroJuego3.Text = lista[i].Genero;
                        PlataformaJuego3.Text = lista[i].Plataforma;
                        StockJuego3.Text = lista[i].Stock.ToString();
                        PrecioJuego3.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego3.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego3.Image = null;
                        }

                    }
                    // Para el cuarto elemento de nuestra lista
                    else if (i == 3)
                    {
                        // Para nuestro primer objeto
                        TituloJuego4.Text = lista[i].Nombre;
                        ModalidadJuego4.Text = lista[i].Modalidad;
                        GeneroJuego4.Text = lista[i].Genero;
                        PlataformaJuego4.Text = lista[i].Plataforma;
                        StockJuego4.Text = lista[i].Stock.ToString();
                        PrecioJuego4.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego4.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego4.Image = null;
                        }

                    }
                    // Para el quinto elemento de nuestra lista
                    else if (i == 4)
                    {
                        // Para nuestro primer objeto
                        TituloJuego5.Text = lista[i].Nombre;
                        ModalidadJuego5.Text = lista[i].Modalidad;
                        GeneroJuego5.Text = lista[i].Genero;
                        PlataformaJuego5.Text = lista[i].Plataforma;
                        StockJuego5.Text = lista[i].Stock.ToString();
                        PrecioJuego5.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego5.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego5.Image = null;
                        }

                    }
                    // Para el sexto elemento de nuestra lista
                    else if (i == 5)
                    {
                        // Para nuestro primer objeto
                        TituloJuego6.Text = lista[i].Nombre;
                        ModalidadJuego6.Text = lista[i].Modalidad;
                        GeneroJuego6.Text = lista[i].Genero;
                        PlataformaJuego6.Text = lista[i].Plataforma;
                        StockJuego6.Text = lista[i].Stock.ToString();
                        PrecioJuego6.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego6.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego6.Image = null;
                        }

                    }
                    // Para el septimo elemento de nuestra lista
                    else if (i == 6)
                    {
                        // Para nuestro primer objeto
                        TituloJuego7.Text = lista[i].Nombre;
                        ModalidadJuego7.Text = lista[i].Modalidad;
                        GeneroJuego7.Text = lista[i].Genero;
                        PlataformaJuego7.Text = lista[i].Plataforma;
                        StockJuego7.Text = lista[i].Stock.ToString();
                        PrecioJuego7.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego7.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego7.Image = null;
                        }

                    }
                    // Para el octavo elemento de nuestra lista
                    else if (i == 7)
                    {
                        // Para nuestro primer objeto
                        TituloJuego8.Text = lista[i].Nombre;
                        ModalidadJuego8.Text = lista[i].Modalidad;
                        GeneroJuego8.Text = lista[i].Genero;
                        PlataformaJuego8.Text = lista[i].Plataforma;
                        StockJuego8.Text = lista[i].Stock.ToString();
                        PrecioJuego8.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego8.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego8.Image = null;
                        }

                    }
                    // Para el noveno elemento de nuestra lista
                    else if (i == 8)
                    {
                        // Para nuestro primer objeto
                        TituloJuego9.Text = lista[i].Nombre;
                        ModalidadJuego9.Text = lista[i].Modalidad;
                        GeneroJuego9.Text = lista[i].Genero;
                        PlataformaJuego9.Text = lista[i].Plataforma;
                        StockJuego9.Text = lista[i].Stock.ToString();
                        PrecioJuego9.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego9.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego9.Image = null;
                        }

                    }
                    // Para el decimo elemento de nuestra lista
                    else if (i == 9)
                    {
                        // Para nuestro primer objeto
                        TituloJuego10.Text = lista[i].Nombre;
                        ModalidadJuego10.Text = lista[i].Modalidad;
                        GeneroJuego10.Text = lista[i].Genero;
                        PlataformaJuego10.Text = lista[i].Plataforma;
                        StockJuego10.Text = lista[i].Stock.ToString();
                        PrecioJuego10.Text = lista[i].Precio.ToString();

                        // Cargamos la imagen
                        // Construimos la ruta hacia la carpeta donde estan las imagenes de los juegos
                        string rutaImagenes = System.IO.Path.Combine(Application.StartupPath, "Juegos");

                        // Construimos la ruta completa donde se encuentra nuestra imagen a buscar
                        string rutaCompleta = System.IO.Path.Combine(rutaImagenes, lista[i].Imagen);

                        // Si hay un archivo con esta direccion en especifico
                        if (System.IO.File.Exists(rutaCompleta))
                        {
                            // Cargamos la imagen a nuestro picture box
                            ImagenJuego10.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            // En caso de que la imagen no exista, entonces mostramos mensaje de error
                            MessageBox.Show("No se encontro la imagen deseada 1");

                            // Si habia una imagen en el pictureBox, la quitamos
                            ImagenJuego10.Image = null;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
            }

        }

        /* Funciones para agregar al carrito los juegos respectivos */
        private void buttonComprarJuego1_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[0].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[0]);

                // Mensaje de exito
                MessageBox.Show($"{lista[0].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[0].Nombre}");
            }
        }

        private void buttonComprarJuego2_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[1].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[1]);

                // Mensaje de exito
                MessageBox.Show($"{lista[1].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[1].Nombre}");
            }
        }

        private void buttonComprarJuego3_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[2].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[2]);

                // Mensaje de exito
                MessageBox.Show($"{lista[2].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[2].Nombre}");
            }
        }

        private void buttonComprarJuego4_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[3].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[3]);

                // Mensaje de exito
                MessageBox.Show($"{lista[3].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[3].Nombre}");
            }
        }

        private void buttonComprarJuego5_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[4].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[4]);

                // Mensaje de exito
                MessageBox.Show($"{lista[4].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[4].Nombre}");
            }
        }

        private void buttonComprarJuego6_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[5].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[5]);

                // Mensaje de exito
                MessageBox.Show($"{lista[5].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[5].Nombre}");
            }
        }

        private void buttonComprarJuego7_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[6].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[6]);

                // Mensaje de exito
                MessageBox.Show($"{lista[6].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[6].Nombre}");
            }
        }

        private void buttonComprarJuego8_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[7].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[7]);

                // Mensaje de exito
                MessageBox.Show($"{lista[7].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[7].Nombre}");
            }
        }

        private void buttonComprarJuego9_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[8].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[8]);

                // Mensaje de exito
                MessageBox.Show($"{lista[8].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[8].Nombre}");
            }
        }

        private void buttonComprarJuego10_Click(object sender, EventArgs e)
        {
            // Verificamos si hay stock disponible 
            if (lista[9].Stock > 0)
            {
                // Agregamos este objeto a nuestro carrito
                carrito.Add(lista[9]);

                // Mensaje de exito
                MessageBox.Show($"{lista[9].Nombre} fue agregado correctamente al carrito");

                // Aumentamos el contador del carrito
                conteo_carrito++;

                // Mostramos el nuevo valor del contador
                textBox_ConteoCarrito.Text = conteo_carrito.ToString();
            }
            else
            {
                MessageBox.Show($"No hay stock disponible del juego {lista[9].Nombre}");
            }
        }
    }
}
