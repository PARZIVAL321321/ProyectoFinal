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
    }
}

