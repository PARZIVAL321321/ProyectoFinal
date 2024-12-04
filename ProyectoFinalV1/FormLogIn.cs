using MySql.Data.MySqlClient; // Para poder usar nuestra base de datos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinalV1
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        // Boton para verificar si el usuario puede entrar al punto de venta o no
        private void button_Acceder_Click(object sender, EventArgs e)
        {
            // Llamamos a nuestra funcion
            Validar_persona();
        }

        // Funcion para checar el tipo de persona que ha entrado al sistema
        private void Validar_persona()
        {
            // Creamos nuestra variable para la base de datos, y pasamos nuestra informacion
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
            // Abrimos nuestra base de datos
            conexion.Open();

            // Linea de comando en SQL para buscar nuestra cuenta, haciendo uso de la informacion que tenemos en nuestros textBox
            string consulta = "SELECT Cuenta FROM personas WHERE Cuenta='" + textBox_Cuenta.Text + "' AND Contra='" + textBox_Contra.Text + "'";

            // Cargamos nuestro comando
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // Realizamos el comando

            // Validamos segun el tipo de cuenta
            MySqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows == true)
            {

                // Mostramos mensaje de bienvenida si la persona pudo acceder al sistema
                MessageBox.Show("¡Bienvenido!");

                // Verificamos que tipo de cuenta ingreso
                switch (Obtener_Tipo_Cuenta())
                {
                    // En caso de que haya entrado el Admin
                    case 0:
                        // Creamos nuestro form
                        FormAdmin formAdmin = new FormAdmin();
                        // Ocultamos este form
                        this.Hide();
                        // Usamos el ShowDialog para cuando el usuario haga Logout
                        formAdmin.ShowDialog();
                        // Volvemos a mostrar este form
                        this.Show();

                        // Despues de regresar al Log-In, limpiamos los campos
                        textBox_Cuenta.Text = "";
                        textBox_Contra.Text = "";
                        break;
                    // En caso de que haya entrado un cliente/invitado
                    case 1:

                        // Creamos nuestro form (obtenemos el nombre de la persona que ingreso)
                        FormProductos formProductos = new FormProductos(Obtener_Nombre_Cuenta());
                        // Ocultamos este form
                        this.Hide();
                        // Usamos el ShowDialog para cuando el usuario haga Logout
                        formProductos.ShowDialog();
                        // Volvemos a mostrar este form
                        this.Show();

                        // Despues de regresar al Log-In, limpiamos los campos
                        textBox_Cuenta.Text = "";
                        textBox_Contra.Text = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            // Cerramos la conexion con nuestro servidor
            conexion.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Funcion para obtener el tipo de cuenta de la persona que quiere ingresar al sistema
        private int Obtener_Tipo_Cuenta()
        {
            // Creamos nuestra variable para la base de datos, y pasamos nuestra informacion
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
            // Abrimos nuestra base de datos
            conexion.Open();

            // Variable a retornar
            int regresar = 0;

            try
            {
                string consulta = "SELECT Tipo FROM personas WHERE Cuenta='" + textBox_Cuenta.Text + "' AND Contra='" + textBox_Contra.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Ejecutamos la consulta y leer los resultados
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) // Solo va a encontrar un registro (gracias a la consulta)
                {
                    // Guardamos el valor
                    regresar = Convert.ToInt32(reader["Tipo"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la base de datos: " + ex.Message);
            }

            // Cerramos la conexion
            conexion.Close();


            return regresar;
        }


        // Funcion para obtener el nombre de la persona que ha ingresado al sistema
        private string Obtener_Nombre_Cuenta()
        {
            // Creamos nuestra variable para la base de datos, y pasamos nuestra informacion
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
            // Abrimos nuestra base de datos
            conexion.Open();

            // Variable a retornar
            string regresar = "";

            try
            {
                string consulta = "SELECT Nombre FROM personas WHERE Cuenta='" + textBox_Cuenta.Text + "' AND Contra='" + textBox_Contra.Text + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Ejecutamos la consulta y leer los resultados
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) // Solo va a encontrar un registro (gracias a la consulta)
                {
                    // Guardamos el valor
                    regresar = Convert.ToString(reader["Nombre"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la base de datos: " + ex.Message);
            }

            // Cerramos la conexion
            conexion.Close();

            return regresar;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox_Cuenta_Enter(object sender, EventArgs e)
        {
            if (textBox_Cuenta.Text == "USUARIO")
            {
                textBox_Cuenta.Text = "";
                textBox_Cuenta.ForeColor = Color.LightGray;
            }
        }

        private void textBox_Cuenta_Leave(object sender, EventArgs e)
        {
            if (textBox_Cuenta.Text == "")
            {
                textBox_Cuenta.Text = "USUARIO";
                textBox_Cuenta.ForeColor = Color.DimGray;
            }
        }

        private void textBox_Contra_Enter(object sender, EventArgs e)
        {
            if (textBox_Contra.Text == "CONTRASEÑA")
            {
                textBox_Contra.Text = "";
                textBox_Contra.ForeColor = Color.LightGray;
                textBox_Contra.UseSystemPasswordChar = true;
            }
        }

        private void textBox_Contra_Leave(object sender, EventArgs e)
        {
            if (textBox_Contra.Text == "")
            {
                textBox_Contra.Text = "CONTRASEÑA";
                textBox_Contra.ForeColor = Color.DimGray;
                textBox_Contra.UseSystemPasswordChar = false;
            }
        }

        private void textBox_Contra_TextChanged(object sender, EventArgs e)
        {
            textBox_Contra.UseSystemPasswordChar = true;
        }
    }
}

