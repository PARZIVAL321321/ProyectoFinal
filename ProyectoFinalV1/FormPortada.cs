using System.Runtime.InteropServices;
namespace ProyectoFinalV1
{
    public partial class FormPortada : Form
    {
        public FormPortada()
        {
            InitializeComponent();
        }


        // Una vez que se haya apretado el boton de "Log-In" mostramos el siguiente form
        private void button_LogIn_Click(object sender, EventArgs e)
        {
            // Creamos un objeto del siguiente form a mostrar
            FormLogIn form = new FormLogIn();

            // Ocultamos el form actual en el que estamos (FormPortada)
            this.Hide();

            // Mostramos ahora el siguiente form (FormLogIn)
            form.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPortada_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_Puntodeventa_Click(object sender, EventArgs e)
        {

        }

        private void FormPortada_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}