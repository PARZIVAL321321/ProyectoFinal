using MySql.Data.MySqlClient; // Para poder usar nuestra base de datos
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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Boton para "refrescar" la base de datos y mostrarla en el 
        private void button_MostrarInventario_Click(object sender, EventArgs e)
        {
            // Creamos nuestra variable para la base de datos, y pasamos nuestra informacion
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
            // Abrimos nuestra base de datos
            conexion.Open();

            // Linea de comando de SQL
            string consulta = "SELECT * from juegos";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);

            // Creamos nuestra tabla
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView_Inventario.DataSource = dt;

            // Cerremos nuestra base de datos
            conexion.Close();
        }

        // Boton para eliminar un producto
        private void button_EliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {

                // Creamos nuestra variable para la base de datos, y pasamos nuestra informacion
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=proyecto; User=root; Password=; Sslmode=none;");
                // Abrimos nuestra base de datos
                conexion.Open();

                // Linea de comando de SQL
                string consulta = "DELETE FROM juegos WHERE ID='" + Convert.ToInt32(textBox_IDBorrar.Text) + "'";
                // Cargamos nuestro comando
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Ejecutamos el comando
                comando.ExecuteNonQuery();

                MessageBox.Show("Producto eliminado correctamente");

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }

        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void FormAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxTITULOJUEGO_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGUARDARPRODUCTO_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSUBIRPRODUCTOS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTITULOJUEGO_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxMODALIDAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPLATAFORMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGENERO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPRECIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSTOCK_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCARGARIMAGEN_Click(object sender, EventArgs e)
        {

        }

        private void textBox_IDBorrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDENTIFYID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGAMETITLE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMODEMODIFY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPLATFORMMODIFY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGENREMODIFY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPRICEMODIFY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSTOCKMODIFY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
