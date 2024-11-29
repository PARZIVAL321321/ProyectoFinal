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
                        // Creamos nuestro form
                        FormProductos formProductos = new FormProductos();
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
    }
}

