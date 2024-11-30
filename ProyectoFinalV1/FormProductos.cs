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
        public FormProductos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

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

        private void pictureBox1Juego1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2Juego1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3Juego3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1Juego1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            ReleaseCapture();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImagenJuego3_Click(object sender, EventArgs e)
        {

        }
    }
}
