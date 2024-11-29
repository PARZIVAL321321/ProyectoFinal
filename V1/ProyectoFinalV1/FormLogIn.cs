using MySql.Data.MySqlClient;
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
            // Creamos nuestra variable para la base de datos, y pasamos nuestra informacion
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
            // Abrimos nuestra base de datos
            conexion.Open();

            // Linea de comando en SQL para buscar nuestra cuenta, haciendo uso de la informacion que tenemos en nuestros textBox
            string consulta = "SELECT Cuenta FROM personas WHERE Cuenta='" + textBox_Cuenta.Text + "' AND Contra='" + textBox_Contra.Text + "'";

            // Realizamos nuestro comando
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            // Pasos para el mensaje de exito
            MySqlDataReader lector = comando.ExecuteReader();
            if (lector.HasRows == true)
            {
                MessageBox.Show("¡Bienvenido!");

                /*En este punto se abrira el nuevo form donde se mostraran los productos*/
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

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Puntodeventa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

